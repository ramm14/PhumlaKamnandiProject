using PhumlaKamnandiProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiProject.UI
{
    public static class BookingSession
    {
        // Guest Information
        public static string GuestID { get; set; }
        public static string GuestFirstName { get; set; }
        public static string GuestLastName { get; set; }
        public static string GuestEmail { get; set; }
        public static string GuestPhone { get; set; }
        public static string GuestIDNumber { get; set; }
        public static string GuestStreet { get; set; }
        public static string GuestSuburb { get; set; }
        public static string GuestPostalCode { get; set; }
        public static string GuestCity { get; set; }
        public static string GuestCountry { get; set; }
        public static IdentityDocument GuestIDType { get; set; }

        // Booking Information
        public static DateTime CheckInDate { get; set; }
        public static DateTime CheckOutDate { get; set; }
        public static int NumberOfAdults { get; set; }
        public static int NumberOfChildren { get; set; }
        public static int SelectedRoomID { get; set; }
        public static decimal TotalAmount { get; set; }
        public static string SpecialRequests { get; set; }

        public static decimal DepositAmount { get; set; }

        // Method to clear session (call this after successful booking)
        public static void ClearSession()
        {
            GuestID = null;
            GuestFirstName = null;
            GuestLastName = null;
            GuestEmail = null;
            GuestPhone = null;
            GuestIDNumber = null;
            GuestStreet = null;
            GuestSuburb = null;
            GuestPostalCode = null;
            GuestCity = null;
            GuestCountry = null;
            CheckInDate = DateTime.MinValue;
            CheckOutDate = DateTime.MinValue;
            NumberOfAdults = 0;
            NumberOfChildren = 0;
            SelectedRoomID = 0;
            TotalAmount = 0;
            SpecialRequests = null;
        }

        public static void setDeposit()
        {
            DepositAmount = TotalAmount * 0.10M;
        }
    }
}
