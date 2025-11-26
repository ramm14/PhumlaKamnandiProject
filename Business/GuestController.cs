using PhumlaKamnandiProject.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhumlaKamnandiProject.Business
{
    public class GuestController
    {
        #region Data Members
        private GuestDA guestDataAccess;
        #endregion

        #region Constructor
        public GuestController()
        {
            guestDataAccess = new GuestDA();
        }
        #endregion

        #region Main Operations

        // Adds a new guest to the system
        public Guest AddGuest(string firstName, string lastName, string email, string phoneNo, string idNo, IdentityDocument idType, string street, string suburb, string postalCode, string city, string country)
        {

            Guest guest = new Guest(firstName, lastName, email, phoneNo,
                idNo, IdentityDocument.NationalID,
                street, suburb, postalCode, city, country);

            try
            {
                //if (guestDataAccess.ReadGuest(guest.GuestID) !=  null)
                //{
                //    throw new Exception("A guest already exists.");
                //}
                // Create guest
                guestDataAccess.CreateNewGuest(guest);
                MessageBox.Show("Added Guest");
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding guest: " + ex.Message);
            }
            return guest;
        }

        // Updates an existing guest
        public bool UpdateGuest(Guest guest)
        {
            try
            {
                // Validate guest details
                if (!ValidateGuestDetails(guest))
                {
                    throw new Exception("Invalid guest details. Please check all required fields.");
                }
                MessageBox.Show("Guest Details Valid");
                // Check if guest exists
                Guest existingGuest = guestDataAccess.ReadGuest(guest.GuestID);
                if (existingGuest == null)
                {
                    throw new Exception("Guest not found.");
                }

                return guestDataAccess.UpdateGuest(guest);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating guest: " + ex.Message);
            }
        }

        // Gets a guest by ID
        public Guest GetGuest(string guestID)
        {
            try
            {
                return guestDataAccess.ReadGuest(guestID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving guest: " + ex.Message);
            }
        }

        // Searches for guests by name
        //public List<Guest> SearchGuest(string name)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(name))
        //        {
        //            throw new Exception("Please enter a search term.");
        //        }

        //        return guestDataAccess.SearchByID(name);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error searching guests: " + ex.Message);
        //    }
        //}

        //Searches for a guest by phone number
        //public Guest SearchGuestByPhone(string phoneNumber)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(phoneNumber))
        //        {
        //            throw new Exception("Please enter a phone number.");
        //        }

        //        return guestDataAccess.SearchByPhone(phoneNumber);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error searching guest by phone: " + ex.Message);
        //    }
        //}


        public Guest FindGuestWithIDNo(string GuestIdentificationNo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(GuestIdentificationNo))
                {
                    throw new Exception("Please enter a IdentificationNo address.");
                }

                return guestDataAccess.SearchByID(GuestIdentificationNo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching guest by email: " + ex.Message);
            }
        }

        // Deletes a guest
        public bool DeleteGuest(string guestID)
        {
            try
            {
                Guest guest = guestDataAccess.ReadGuest(guestID);
                if (guest == null)
                {
                    throw new Exception("Guest not found.");
                }

                return guestDataAccess.DeleteGuest(guestID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting guest: " + ex.Message);
            }
        }
        #endregion

        #region Validation Methods

        /// Validates all guest details based on guest type
        public bool ValidateGuestDetails(Guest guest)
        {
            // Check required fields
            if (string.IsNullOrWhiteSpace(guest.FirstName))
                return false;

            if (string.IsNullOrWhiteSpace(guest.LastName))
                return false;

            if (string.IsNullOrWhiteSpace(guest.PhoneNumber))
                return false;

            if (string.IsNullOrWhiteSpace(guest.Email))
                return false;

            // Validate email format
            //if (!guest.ValidateEmail())
            //    return false;

            // Validate based on guest type
            //if (guest.GuestType == GuestType.Local)
            //{
            //    // Local guest must have valid ID number
            //    if (!guest.ValidateIDNumber())
            //        return false;
            //}
            //else // Foreign guest
            //{
            //    // Foreign guest must have valid passport details
            //    if (!guest.ValidatePassportNumber())
            //        return false;

            //    if (string.IsNullOrWhiteSpace(guest.PassportCountry))
            //        return false;

            //    if (!guest.PassportExpiryDate.HasValue)
            //        return false;

            //    // Check passport is not expired
            //    if (guest.IsPassportExpired())
            //        return false;
            //}

            return true;
        }

        // Checks if a guest already exists 
        //public bool CheckDuplicateGuest(Guest guest)
        //{
        //    try
        //    {
        //        // Check Guest
        //        Guest existingGuest = guestDataAccess.SearchByID(guest.GuestID);
        //        if (existingGuest != null && existingGuest.GuestID != guest.GuestID)
        //        {
        //            return true;
        //        }

        //        // Check phone
        //Guest existingByPhone = guestDataAccess.SearchByID(guest.GuestID);
        //        if (existingByPhone != null && existingByPhone.GuestID != guest.GuestID)
        //        {
        //            return true;
        //        }

        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        // Validates email format
        public bool ValidateEmail(string email)
        {
            Guest tempGuest = new Guest { Email = email };
            return tempGuest.ValidateEmail();
        }

        // Checks if passport is expiring soon (within 6 months)
        //public bool CheckPassportExpiry(Guest guest)
        //{
        //    if (guest.GuestType != GuestType.Foreign)
        //        return false;

        //    return guest.IsPassportExpiringSoon(6);
        //}
        #endregion
    }

}
