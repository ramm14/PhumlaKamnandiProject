using PhumlaKamnandiProject.Business;
using PhumlaKamnandiProject.Data;
using PhumlaKamnandiProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PhumlaKamnandiProject.Business.Booking;


namespace PhumlaKamnandiProject.Business
{
    public class BookingController
    {
        #region Data Members
        private BookingDA bookingDataAccess;
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDataAccess = new BookingDA();
        }

        #endregion

        #region Main Operations

        // Creates a new booking for a guest
        public int MakeBooking(Guest guest, Room room, DateTime checkIn, DateTime checkOut, int noOfAdults, int noOfChildren,decimal bookingCost)
        {
            try
            {
                // Validate booking dates
                if (!ValidateBookingDates(checkIn, checkOut))
                {
                    throw new Exception("Invalid booking dates. Check-out must be after check-in.");
                }

                // Create new booking object


                // Calculate amounts
                Booking booking = new Booking(guest, room, checkIn,checkOut,noOfAdults, noOfChildren,bookingCost);
                return bookingDataAccess.CreateBooking(booking);

            }
            catch (Exception ex)
            {
                throw new Exception("Error making booking: " + ex.Message);
            }
        }

        public bool UpdateBookingDeposit(Booking booking , DateTime dateOfDepositPayment)
        {
            //booking.UpdateDepositDetails(dateOfDepositPayment);
            booking.Status = StatusOfBooking.Confirmed;
            booking.DepositPaidDate = dateOfDepositPayment;
            return bookingDataAccess.Update(booking);
        }

        // Changes an existing booking
        public bool ChangeBooking(int bookingID, DateTime newCheckInDate,
                                  DateTime newCheckOutDate, int noOfAdults, int noOfChildren, decimal newRoomRate , string requests)
        {
            try
            {
                // Retrieve existing booking
                Booking booking = bookingDataAccess.Read(bookingID);

                if (booking == null)
                {
                    throw new Exception("Booking not found.");
                }

                // Check if booking can be modified
                if (booking.Status == StatusOfBooking.Cancelled)
                {
                    throw new Exception("Cannot modify a cancelled booking.");
                }

                // Validate new dates
                if (!ValidateBookingDates(newCheckInDate, newCheckOutDate))
                {
                    throw new Exception("Invalid booking dates.");
                }

                // Update booking details
                booking.CheckInDate = newCheckInDate;
                booking.CheckOutDate = newCheckOutDate;
                booking.NoOfAdults = noOfAdults;
                booking.NoOfChildren = noOfChildren;
                booking.Requests = requests;

                // Recalculate amounts
                booking.CalculateTotalAmount(newRoomRate);
                booking.CalculateDepositAmount();



                // Save changes
                return bookingDataAccess.Update(booking);
            }
            catch (Exception ex)
            {
                throw new Exception("Error changing booking: " + ex.Message);
            }
        }

        // Cancels an existing booking
        public bool CancelBooking(int bookingID)
        {
            try
            {
                // Retrieve existing booking
                Booking booking = bookingDataAccess.Read(bookingID);

                if (booking == null)
                {
                    throw new Exception("Booking not found.");
                }

                // Check if booking can be cancelled
                if (!booking.CanBeCancelled())
                {
                    throw new Exception("Booking cannot be cancelled. Either it's already cancelled or check-in date has passed.");
                }

                // Cancel the booking (soft delete)
                return bookingDataAccess.Delete(bookingID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error cancelling booking: " + ex.Message);
            }
        }

        // Gets booking details by booking ID 
        public Booking GetBookingDetails(int bookingID)
        {
            try
            {
                return bookingDataAccess.Read(bookingID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving booking details: " + ex.Message);
            }
        }

        // Gets booking details by booking reference
        public Booking GetBookingByReference(string bookingReference)
        {
            try
            {
                return bookingDataAccess.GetBookingByReference(bookingReference);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving booking: " + ex.Message);
            }
        }

        // Gets all bookings for a specific guest
        public List<Booking> GetGuestBookings(int guestID)
        {
            try
            {
                return bookingDataAccess.GetBookingsByGuest(guestID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving guest bookings: " + ex.Message);
            }
        }

        /// Gets all bookings
        public List<Booking> GetAllBookings()
        {
            try
            {
                return bookingDataAccess.GetAllBookings();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving all bookings: " + ex.Message);
            }
        }

        // Updates booking status to confirmed when deposit is paid
        public bool ConfirmBooking(int bookingID)
        {
            try
            {
                Booking booking = bookingDataAccess.Read(bookingID);

                if (booking == null)
                {
                    throw new Exception("Booking not found.");
                }

                booking.Status = StatusOfBooking.Confirmed;
                booking.DepositPaidDate = DateTime.Now;

                return bookingDataAccess.Update(booking);
            }
            catch (Exception ex)
            {
                throw new Exception("Error confirming booking: " + ex.Message);
            }
        }
        #endregion

        #region Helper Methods

        // Validates that check-out date is after check-in date
        // and that check-in date is not in the past
        public bool ValidateBookingDates(DateTime checkInDate, DateTime checkOutDate)
        {
            // Check-out must be after check-in
            if (checkOutDate <= checkInDate)
            {
                return false;
            }

            // Check-in date must not be in the past (allow today)
            if (checkInDate.Date < DateTime.Now.Date)
            {
                return false;
            }

            return true;
        }

        // Calculates deposit amount (10% of total)
        public decimal CalculateDeposit(decimal totalAmount)
        {
            return totalAmount * 0.10m;
        }

        // Gets bookings for a date range (for occupancy reports)
        public List<Booking> GetBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return bookingDataAccess.GetBookingsByDateRange(startDate, endDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving bookings by date range: " + ex.Message);
            }
        }

        // Checks if a booking exists by reference number
        public bool BookingExists(string bookingReference)
        {
            try
            {
                Booking booking = bookingDataAccess.GetBookingByReference(bookingReference);
                return booking != null;
            }
            catch (Exception)
            {
                return false;
            }
        }


        // Gets count of active bookings (not cancelled)
        public int GetActiveBookingsCount()
        {
            try
            {
                List<Booking> allBookings = bookingDataAccess.GetAllBookings();
                int count = 0;

                foreach (Booking booking in allBookings)
                {
                    if (booking.Status != StatusOfBooking.Cancelled)
                    {
                        count++;
                    }
                }

                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting active bookings count: " + ex.Message);
            }
        }

        // Updates booking status
        public bool UpdateBookingStatus(int bookingID, string newStatus)
        {
            try
            {
                Booking booking = bookingDataAccess.Read(bookingID);

                if (booking == null)
                {
                    throw new Exception("Booking not found.");
                }

                // Valid statuses: Unconfirmed, Confirmed, Cancelled, Checked-In, Checked-Out
                StatusOfBooking[] validStatuses = {
                    StatusOfBooking.Unconfirmed,
                    StatusOfBooking.Confirmed,
                    StatusOfBooking.Cancelled,
                    StatusOfBooking.CheckedIn,
                    StatusOfBooking.CheckedOut,
                    StatusOfBooking.NoShow
                };

                bool isValidStatus = false;

                foreach (StatusOfBooking status in validStatuses)
                {
                    if (newStatus.Equals(status.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        isValidStatus = true;
                        booking.Status = status;
                        break;
                    }
                }

                if (!isValidStatus)
                {
                    throw new Exception("Invalid booking status.");
                }

                return bookingDataAccess.Update(booking);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating booking status: " + ex.Message);
            }
        }

        // Search bookings by guest name (requires integration with GuestController)
        public List<Booking> SearchBookingsByGuestName(string guestName)
        {
            // For now, returning empty list as placeholder
            return new List<Booking>();
        }
        #endregion
    }
}
