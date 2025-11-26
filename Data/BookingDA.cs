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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhumlaKamnandiProject.Data
{
    public class BookingDA:BaseDA
    {
        #region Data Members
        //private string connectionString;
        //private SqlConnection connection;  // Already inherits from BaseDA 
        #endregion

        #region Constructor
        public BookingDA() : base()
        {
            
        }

 
        #endregion

        #region CRUD Operations
        public int CreateBooking(Booking booking)
        {
            bool success = false;
            int bookingID = 0;

            string query = @"INSERT INTO Booking 
                (BookingReference, Guest, Room, CheckInDate, CheckOutDate, 
                NoOfAdults, BookingTotalAmount, DepositAmount, BookingStatus, 
                NoOfChildren,DepositReceivedDate, Requests)
                VALUES 
                (@BookingReference, @GuestID, @RoomID, @CheckInDate, @CheckOutDate, 
                @NoOfAdults, @BookingTotalAmount, @DepositAmount, @BookingStatus, 
                @NoOfChildren,@DepositReceivedDate, @Requests)
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingReference", booking.BookingReference);
                command.Parameters.AddWithValue("@GuestID", booking.Guest.GuestID);
                command.Parameters.AddWithValue("@RoomID", booking.Room.RoomID);
                command.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate);
                command.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate);
                command.Parameters.AddWithValue("@NoOfAdults", booking.NoOfAdults);
                command.Parameters.AddWithValue("@NoOfChildren", booking.NoOfChildren);
                command.Parameters.AddWithValue("@BookingTotalAmount", booking.TotalAmount);
                command.Parameters.AddWithValue("@DepositAmount", booking.DepositAmount);
                command.Parameters.AddWithValue("@DepositReceivedDate",
      booking.DepositPaidDate == DateTime.MinValue ? (object)DBNull.Value : booking.DepositPaidDate);
                command.Parameters.AddWithValue("@BookingStatus", (int)booking.Status);
                command.Parameters.AddWithValue("@Requests",
                    string.IsNullOrEmpty(booking.Requests) ? (object)DBNull.Value : booking.Requests);
                bookingID = (int)command.ExecuteScalar();
                //int rowsAffected = command.ExecuteNonQuery();
                success = bookingID > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error creating booking: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return bookingID;
        }

        public Booking Read(int bookingID)
        {
            Booking booking = null;

            string query = @"SELECT *
                FROM Booking WHERE BookingID = @BookingID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingID", bookingID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    booking = MapBooking(reader);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading booking: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return booking;
        }

        public bool Update(Booking booking) // Look for Available Rooms when updating checkin and checkout date
        {
            bool success = false;


            string query = @"UPDATE Booking SET 
                CheckInDate = @CheckIn,
                CheckOutDate = @CheckOut,
                NoOfAdults = @NoOfAdults,
                NoOfChildren = @NoOfChildren,
                BookingTotalAmount = @TotalAmount,
                DepositAmount = @DepositAmount,
                DepositReceivedDate = @DepositPaidDate,
                BookingStatus = @BookingStatus,
                Requests = @Requests
                WHERE BookingID = @BookingID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@BookingID", booking.BookingID);
                command.Parameters.AddWithValue("@CheckIn", booking.CheckInDate);
                command.Parameters.AddWithValue("@CheckOut", booking.CheckOutDate);
                command.Parameters.AddWithValue("@NoOfAdults", booking.NoOfAdults);
                command.Parameters.AddWithValue("@NoOfChildren", booking.NoOfChildren);
                command.Parameters.AddWithValue("@TotalAmount", booking.TotalAmount);
                command.Parameters.AddWithValue("@DepositAmount", booking.DepositAmount);
                command.Parameters.AddWithValue("@DepositPaidDate",
                    booking.DepositPaidDate == DateTime.MinValue ? (object)DBNull.Value : booking.DepositPaidDate);
                command.Parameters.AddWithValue("@BookingStatus", (int)booking.Status);
                command.Parameters.AddWithValue("@Requests",
                    string.IsNullOrEmpty(booking.Requests) ? (object)DBNull.Value : booking.Requests);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating booking: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return success;
        }

        public bool Delete(int bookingID)
        {
            bool success = false;

            // Soft delete - set status to Cancelled
            string query = @"UPDATE Booking SET 
                BookingStatus = @CancelledStatus
                WHERE BookingID = @BookingID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingID", bookingID);
                command.Parameters.AddWithValue("@CancelledStatus", (int)StatusOfBooking.Cancelled);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error cancelling booking: " + ex.Message);
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
        public Booking GetBookingByReference(string bookingRef)
        {
            Booking booking = null;

            string query = @"SELECT *
                FROM Booking WHERE BookingReference = @BookingRef";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingRef", bookingRef);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    booking = MapBooking(reader);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading booking: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return booking;
        }

        public List<Booking> GetBookingsByGuest(int guestID)
        {
            List<Booking> bookings = new List<Booking>();

            string query = @"SELECT *
                FROM Booking
                WHERE Guest = @GuestID
                ORDER BY CheckInDate DESC";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guestID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bookings.Add(MapBooking(reader));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading bookings: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return bookings;
        }

        public List<Booking> GetAllBookings()
        {
            List<Booking> bookings = new List<Booking>();

            string query = @"SELECT BookingID, BookingReference, Guest, Room, CheckInDate, CheckOutDate, 
                     NoOfAdults, BookingTotalAmount, DepositAmount, BookingStatus, 
                     DateCreated, NoOfChildren, DepositReceivedDate, Requests
                     FROM Booking
                     ORDER BY CheckInDate DESC";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bookings.Add(MapBooking(reader));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading bookings: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return bookings;
        }

        public List<Booking> GetBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            List<Booking> bookings = new List<Booking>();

            string query = @"SELECT BookingID, BookingReference, Guest, Room, CheckInDate, CheckOutDate, 
                     NoOfAdults, BookingTotalAmount, DepositAmount, BookingStatus, 
                     DateCreated, NoOfChildren, DepositReceivedDate, Requests
                     FROM Booking 
                     WHERE BookingStatus != @CancelledStatus
                     AND (CheckInDate <= @EndDate AND CheckOutDate >= @StartDate)
                     ORDER BY CheckInDate";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                command.Parameters.AddWithValue("@CancelledStatus", (int)StatusOfBooking.Cancelled);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bookings.Add(MapBooking(reader)); // Refer to the bottom of this page . 
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading bookings: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return bookings;
        }
        #endregion

        #region Helper Methods
        private Booking MapBooking(SqlDataReader reader) {

            int bookingID = Convert.ToInt32(reader["BookingID"]);
            string bookingReference = reader["BookingReference"].ToString().Trim();
            string guestID = reader["Guest"].ToString();
            int roomID = Convert.ToInt32(reader["Room"]);
            DateTime checkIn = Convert.ToDateTime(reader["CheckInDate"]);
            DateTime checkOut = Convert.ToDateTime(reader["CheckOutDate"]);
            int noOfAdults = Convert.ToInt32(reader["NoOfAdults"]);
            DateTime dateCreated = Convert.ToDateTime(reader["DateCreated"]);
            decimal depositAmount = Convert.ToDecimal(reader["DepositAmount"]);
            int bookingStatusValue = Convert.ToInt32(reader["BookingStatus"]);
            int noOfChildren = Convert.ToInt32(reader["NoOfChildren"]);
            decimal bookingTotalAmount = Convert.ToDecimal(reader["BookingTotalAmount"]);
            DateTime? depositReceivedDate = reader["DepositReceivedDate"] == DBNull.Value
                ? (DateTime?)null
                : Convert.ToDateTime(reader["DepositReceivedDate"]);
            string requests = reader["Requests"] == DBNull.Value
                ? "None"
                : reader["Requests"].ToString().Trim();
            StatusOfBooking bookingStatus = StatusOfBooking.Unconfirmed; // I got eror
            switch (bookingStatusValue)
            {
                case 0:
                    bookingStatus = StatusOfBooking.Unconfirmed;
                    break;
                case 1:
                    bookingStatus = StatusOfBooking.Confirmed;
                    break;
                case 2:
                    bookingStatus = StatusOfBooking.CheckedIn;
                    break;
                case 3:
                    bookingStatus= StatusOfBooking.Unconfirmed;
                    break;
                case 4:
                    bookingStatus = StatusOfBooking.Cancelled;
                    break;
                case 5:
                    bookingStatus = StatusOfBooking.NoShow;
                    break;
            }
            //Guest guest = new GuestDA().FindById(guestId); **idk the method
            Room room = new RoomDA().ReadRoom(roomID);
            Guest guest = new GuestDA().ReadGuest(guestID);

            if (guest == null || guest.GuestID != guestID )
            { throw new Exception("Guest not found"); }

            if (room == null || room.RoomID != roomID)
            { throw new Exception("Room not found."); }

            if (checkOut <= checkIn)
            { throw new Exception("Check-out date must be after check-in date."); }

            Booking readBooking = new Booking(bookingID, bookingReference, guest, room,
               checkIn, checkOut, noOfAdults, noOfChildren,
              bookingTotalAmount, depositAmount, depositReceivedDate,
              bookingStatus, dateCreated, requests);


            
            return readBooking; 

        }
    #endregion
 }
}
