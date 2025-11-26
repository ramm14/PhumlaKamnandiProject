using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiProject.Business
{
    public class Room
    {
        #region Data Members
        private int roomID;
        private string roomNumber;
        private decimal ratePerNight;
        private bool available;
        #endregion

        #region Properties
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }


        public decimal RatePerNight
        {
            get { return ratePerNight; }
            set { ratePerNight = value; }
        }

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        //public DateTime CreatedDate
        //{
        //    get { return createdDate; }
        //    set { createdDate = value; }
        //}
        #endregion

        #region Constructors
        // Default constructor

        public Room()
        {

        }

        // Constructor for new room (without ID)
        public Room(string roomNumber, decimal rate)
        {
            this.roomNumber = roomNumber;
            this.ratePerNight = rate;
            this.available = true;
        }

        // Constructor for existing room (with ID from database)
        public Room(int roomID, string roomNumber, bool Available , decimal rate)
        {
            this.roomID = roomID;
            this.roomNumber = roomNumber;
            this.available=Available;
            this.ratePerNight = rate;
        }
        #endregion

        #region Methods
        public string GetRoomDetails()
        {
            return $"Room {roomNumber}, Rate: R{ratePerNight:F2}/night)";
        }

        public decimal CalculateRate(DateTime date)
        {
            // For now, return standard rate
            // Can be extended to include seasonal pricing logic
            return ratePerNight;
        }

        public void UpdateRoomStatus()
        {
            this.available = !(available);
        }


        public override string ToString()
        {
            string status = Available ? "Available" : "Unavailable";
            return $"Room {roomNumber}- {status}";
        }
        #endregion
    }
}
