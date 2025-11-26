using PhumlaKamnandiProject.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PhumlaKamnandiProject.Business.Booking;

namespace PhumlaKamnandiProject.Data
{
    public class RoomDA:BaseDA
    {
        #region Data Members
        //private string connectionString;
        //private SqlConnection connection;  Already Inherits from BaseDA
        #endregion

        #region Constructor
        public RoomDA():base()
        {
            //connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PhumlaKamnandiDB;Integrated Security=True";
            //connection = new SqlConnection(connectionString);
        }

        #endregion

        #region CRUD Operations

        // Creates a new room in the database
        public int Create(Room room)
        {
            int roomID = 0;

            string query = @"INSERT INTO Room 
                (RoomNumber, RoomRate, Available)
                VALUES 
                (@RoomNumber, @RoomRate, @Available);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                command.Parameters.AddWithValue("@RoomRate", room.RatePerNight);
                command.Parameters.AddWithValue("@Available", room.Available);
                roomID = (int)command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error creating room: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return roomID;
        }

        // Reads a room from the database by RoomID
        public Room ReadRoom(int roomID)
        {
            Room room = new Room();

            string query = @"SELECT *
                FROM Room WHERE RoomID = @RoomID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", roomID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    room.RoomID = (int)reader["RoomID"];  
                    room.RoomNumber = (string)reader["RoomNumber"];
                    room.Available = (bool)reader["Available"];
                    room.RatePerNight = (decimal)reader["RoomRate"];
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading room: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return room;
        }

        // Updates an existing room in the database
        public bool UpdateRoom(Room room)
        {
            bool success = false;

            string query = @"UPDATE Room SET 
                RoomNumber = @RoomNumber,
                RoomRate = @RatePerNight,
                Available = @Available
                WHERE RoomID = @RoomID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@RoomID", room.RoomID);
                command.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                command.Parameters.AddWithValue("@RatePerNight", room.RatePerNight);
                command.Parameters.AddWithValue("@Available", room.Available);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating room: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return success;
        }
        // Deletes a room from the database (soft delete - sets IsActive to false)
        public bool Delete(int roomID)
        {
            bool success = false;

            string query = "UPDATE Room SET Available = 0 WHERE RoomID = @RoomID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", roomID);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting room: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return success;
        }
        #endregion

        #region Query Methods
        // Gets room by room number
        public Room GetRoomByNumber(string roomNumber)
        {
            Room room = null;

            string query = @"SELECT RoomID, RoomNumber,
                RoomRate, Available
                FROM Room WHERE RoomNumber = @RoomNumber";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    room = new Room(
                     reader.GetInt32(0),      // RoomID
                     reader.GetString(1),     // RoomNumber
                     reader.GetBoolean(2), //Avaialble
                    reader.GetDecimal(3) // RoomRate
                    );
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading room: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return room;
        }

        // Gets all active rooms
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            string query = @"SELECT RoomID, RoomNumber, RoomType, Capacity, 
                RatePerNight, IsActive, CreatedDate
                FROM Rooms WHERE IsActive = 1 ORDER BY RoomNumber";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Room room = new Room(
                     reader.GetInt32(0),      // RoomID
                     reader.GetString(1),     // RoomNumber
                     reader.GetBoolean(2), //Avaialble
                     reader.GetDecimal(3) // RoomRate
                    );
                    rooms.Add(room);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading rooms: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return rooms;
        }

        // Gets available rooms for a date range (not booked or booking is cancelled)
        public List<Room> GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            List<Room> rooms = new List<Room>(); // Removed Availability

            string query = @"SELECT r.RoomID, r.RoomNumber,  
                r.RoomRate, r.Available
                FROM Room r
                WHERE r.RoomID NOT IN (
                    SELECT b.Room 
                    FROM Booking b
                    WHERE b.BookingStatus != @CancelledStatus
                    AND (
                        (b.CheckInDate <= @CheckOutDate AND b.CheckOutDate >= @CheckInDate)
                    )
                )
                ORDER BY r.RoomNumber";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                command.Parameters.AddWithValue("@CancelledStatus", (int)StatusOfBooking.Cancelled);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int roomId = (int)reader["RoomID"];
                    string roomNumber = (string)reader["RoomNumber"];
                    bool Available = (bool)reader["Available"];
                    decimal roomRate = (decimal)reader["RoomRate"];
                    Room room = new Room(roomId, roomNumber, Available, roomRate); 
                    rooms.Add(room);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading available rooms: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return rooms;
        }

        // Checks if a specific room is available for a date range
        public bool IsRoomAvailable(int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            bool isAvailable = false;

            string query = @"SELECT COUNT(*) 
                FROM Booking 
                WHERE RoomID = @RoomID
                AND BookingStatus != @CancelledStatus
                AND (CheckInDate <= @CheckOutDate AND CheckOutDate >= @CheckInDate)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", roomID);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                command.Parameters.AddWithValue("@CancelledStatus", (int)StatusOfBooking.Cancelled);

                int conflictCount = (int)command.ExecuteScalar();
                isAvailable = conflictCount == 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error checking room availability: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return isAvailable;
        }

        // Gets total number of rooms in the hotel
        public int GetTotalRoomCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM Room WHERE Available = 1";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                count = (int)command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting room count: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return count;
        }
        #endregion
    }
}
