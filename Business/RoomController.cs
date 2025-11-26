using PhumlaKamnandiProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiProject.Business
{
    public class RoomController
    {
        #region Data Members
        private RoomDA roomDataAccess;
        #endregion

        #region Constructor
        public RoomController()
        {
            roomDataAccess = new RoomDA();
        }

        #endregion

        #region Main Operations

        // Adds a new room to the system
        public int AddRoom(Room room)
        {
            try
            {
                if (!ValidateRoom(room))
                {
                    throw new Exception("Invalid room details.");
                }

                // Check for duplicate room number
                Room existing = roomDataAccess.GetRoomByNumber(room.RoomNumber);
                if (existing != null)
                {
                    throw new Exception("A room with this number already exists.");
                }

                return roomDataAccess.Create(room);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding room: " + ex.Message);
            }
        }

        // Updates an existing room
        public bool UpdateRoom(Room room)
        {
            try
            {
                //if (!ValidateRoom(room))
                //{
                //    throw new Exception("Invalid room details.");
                //}

                //Room existing = roomDataAccess.ReadRoom(room.RoomID);
                //if (existing == null)
                //{
                //    throw new Exception("Room not found.");
                //}
                room.UpdateRoomStatus();

                return roomDataAccess.UpdateRoom(room);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating room: " + ex.Message);
            }
        }

        // Gets a room by ID
        public Room GetRoom(int roomID)
        {
            try
            {
                return roomDataAccess.ReadRoom(roomID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving room: " + ex.Message);
            }
        }

        // Gets a room by room number
        public Room GetRoomByNumber(string roomNumber)
        {
            try
            {
                return roomDataAccess.GetRoomByNumber(roomNumber);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving room: " + ex.Message);
            }
        }


        // Gets all active rooms
        public List<Room> GetAllRooms()
        {
            try
            {
                return roomDataAccess.GetAllRooms();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving rooms: " + ex.Message);
            }
        }


        // Deactivates a room (soft delete)
        public bool DeactivateRoom(int roomID)
        {
            try
            {
                Room room = roomDataAccess.ReadRoom(roomID);
                if (room == null)
                {
                    throw new Exception("Room not found.");
                }

                return roomDataAccess.Delete(roomID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deactivating room: " + ex.Message);
            }
        }

        // Gets available rooms for a date range
        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                if (checkOut <= checkIn)
                {
                    throw new Exception("Check-out date must be after check-in date.");
                }

                return roomDataAccess.GetAvailableRooms(checkIn, checkOut);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting available rooms: " + ex.Message);
            }
        }

        // Checks if a specific room is available for dates
        public bool IsRoomAvailable(int roomID, DateTime checkIn, DateTime checkOut)
        {
            try
            {
                return roomDataAccess.IsRoomAvailable(roomID, checkIn, checkOut);
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking room availability: " + ex.Message);
            }
        }

        // Gets the room rate based on date (seasonal pricing)
        public decimal GetRoomRate(DateTime date)
        {
            // December pricing based on test data specification
            if (date.Month == 12)
            {
                int day = date.Day;

                // Low Season: 1-7 Dec
                if (day >= 1 && day <= 7)
                    return 550.00m;

                // Mid Season: 8-15 Dec
                if (day >= 8 && day <= 15)
                    return 750.00m;

                // High Season: 16-31 Dec
                if (day >= 16 && day <= 31)
                    return 995.00m;
            }

            // Default rate for other months
            return 550.00m;
        }

        // Calculates total cost for a stay
        public decimal CalculateStayCost(DateTime checkIn, DateTime checkOut)
        {
            decimal total = 0;
            DateTime current = checkIn;

            while (current < checkOut)
            {
                total += GetRoomRate(current);
                current = current.AddDays(1);
            }

            return total;
        }


        // Gets total room count
        public int GetTotalRoomCount()
        {
            try
            {
                return roomDataAccess.GetTotalRoomCount();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting room count: " + ex.Message);
            }
        }

        // Gets occupancy percentage for a date range
        public decimal GetOccupancyRate(DateTime startDate, DateTime endDate)
        {
            try
            {
                int totalRooms = GetTotalRoomCount();
                if (totalRooms == 0) return 0;

                TimeSpan duration = endDate - startDate;
                int days = Math.Max(1, duration.Days);
                int totalRoomNights = totalRooms * days;

                // Get all bookings in date range
                BookingController bookingController = new BookingController();
                List<Booking> bookings = bookingController.GetBookingsByDateRange(startDate, endDate);

                int bookedNights = 0;
                foreach (Booking booking in bookings)
                {
                    // Calculate overlap with query range
                    DateTime bookingStart = booking.CheckInDate > startDate ? booking.CheckInDate : startDate;
                    DateTime bookingEnd = booking.CheckOutDate < endDate ? booking.CheckOutDate : endDate;

                    TimeSpan overlap = bookingEnd - bookingStart;
                    bookedNights += Math.Max(0, overlap.Days);
                }

                return totalRoomNights > 0 ? (decimal)bookedNights / totalRoomNights * 100 : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculating occupancy: " + ex.Message);
            }
        }
        #endregion

        #region Validation

        private bool ValidateRoom(Room room)
        {
            if (string.IsNullOrWhiteSpace(room.RoomNumber))
                return false;

            //if (string.IsNullOrWhiteSpace(room.Available))
            //    return false;

            if (room.RatePerNight <= 0)
                return false;

            return true;
        }
        #endregion
    }
}
