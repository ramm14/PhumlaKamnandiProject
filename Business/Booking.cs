using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Group27 - Project
namespace PhumlaKamnandiProject.Business
{
    public class Booking
    {
        #region Enums
        public enum StatusOfBooking
        {
            Unconfirmed = 0,
            Confirmed = 1,
            CheckedIn = 2,
            CheckedOut = 3,
            Cancelled = 4,
            NoShow = 5
        }
        #endregion

        #region Data Members
        private int bookingID;
        private string bookingReference;
        private Guest guest;  
        private Room room;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int noOfAdults;
        private int noOfChildren;
        private decimal totalAmount;
        private decimal depositAmount;
        private DateTime depositPaidDate;
        private StatusOfBooking bookingStatus; 
        private DateTime createdDate;
        private string requests;
        #endregion

        #region Properties
        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public string BookingReference
        {
            get { return bookingReference; }
            set { bookingReference = value; }
        }

        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        public int NoOfAdults
        {
            get { return noOfAdults; }
            set { noOfAdults = value; }
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public decimal DepositAmount
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }

        public DateTime DepositPaidDate
        {
            get { return depositPaidDate; }
            set { depositPaidDate = value; }
        }

        public StatusOfBooking Status
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }


        public string Requests
        {
            get { return requests; }
            set { requests = value; }
        }
        #endregion

        #region Constructors
        //default constructor
        public Booking()
        {
        }
        public Booking(Guest guest, Room room, DateTime checkIn, DateTime checkOut, int noOfAdults, int noOfChildren, decimal totalAmount,string specialReq = "")
        {
            this.Guest = guest;
            this.Room = room;
            this.checkInDate = checkIn;
            this.checkOutDate = checkOut;
            this.noOfAdults = noOfAdults;
            this.noOfChildren = noOfChildren;
            this.Requests = specialReq;
            this.bookingStatus = StatusOfBooking.Unconfirmed;
            this.createdDate = DateTime.Now;
            this.TotalAmount = totalAmount;
            this.bookingReference = GenerateBookingReference();
            this.CalculateDepositAmount();
            
        }
        // Full constructor for loading from database
        public Booking(int bookingID, string bookingRef, Guest guest, Room room,
              DateTime checkIn, DateTime checkOut, int noOfAdults, int noOfChildren,
              decimal total, decimal deposit, DateTime? depositPaidDate,
              StatusOfBooking status, DateTime createdDate,
              string specialReq)
        {
            this.bookingID = bookingID;
            this.bookingReference = bookingRef;
            this.guest = guest;
            this.room = room;
            this.checkInDate = checkIn;
            this.checkOutDate = checkOut;
            this.noOfAdults = noOfAdults;
            this.noOfChildren = noOfChildren;
            this.totalAmount = total;
            this.depositAmount = deposit;
            this.depositPaidDate = depositPaidDate ?? DateTime.MinValue;
            this.createdDate = createdDate;
            this.bookingStatus = status;
            this.Requests = specialReq;
        }




        #endregion

        #region Business Logic Methods

        //Calculates total amount based on room rate and number of nights
        public void CalculateTotalAmount(decimal roomRate)
        {
            int nights = (CheckOutDate - CheckInDate).Days;
            if (nights <= 0) nights = 1; // safeguard
            totalAmount = nights * roomRate;
        }

        // Calculates deposit amount (10% of total)
        public void CalculateDepositAmount()
        {
            depositAmount = totalAmount * 0.10m;
        }

        // Checks if booking can be cancelled
        public bool CanBeCancelled()
        {
            // Only allow cancellation if booking is not already cancelled
            // and check-in date has not passed
            return (bookingStatus != StatusOfBooking.Cancelled &&
                    bookingStatus != StatusOfBooking.CheckedIn &&
                    DateTime.Now < CheckInDate);
        }

        // Generates a unique booking reference number
        // Format: BK + Year + Month + Day + Random4Digits (e.g., BK20251015ABCD)
        public string GenerateBookingReference()
        {
            Random random = new Random();
            string datePart = checkOutDate.ToString("yyyyMMdd");
            string randomPart = random.Next(1000, 9999).ToString("D4");
            return "BK" + datePart + randomPart;
        }

        public void UpdateDepositDetails(DateTime depositPaid)
        {
            this.depositPaidDate = depositPaid;
            this.bookingStatus = StatusOfBooking.Confirmed;
        }

        #endregion



    }
}
