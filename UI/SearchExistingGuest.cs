using PhumlaKamnandiProject.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiProject.UI
{
    public partial class SearchExistingGuest : Form
    {
        private Guest sessionGuest;
        private GuestController guestController;
        
        public SearchExistingGuest()
        {
            InitializeComponent();
            guestController = new GuestController();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string idNoOfExistingGuest = guestIdTxt.Text.Trim();

            if (string.IsNullOrEmpty(idNoOfExistingGuest))
            {
                MessageBox.Show("ID Text input cannot be empty");
                return;
            }

            sessionGuest = guestController.FindGuestWithIDNo(idNoOfExistingGuest);

            if (sessionGuest == null)
            {
                resultLbl.Visible = true;
                resultLbl.Text = "Guest Not Found";
                resultLbl.ForeColor = Color.Red;  // Changed to Red for "not found"
            }
            else
            {
                resultLbl.Visible = true;
                resultLbl.Text = "Guest Found";
                resultLbl.ForeColor = Color.Green;  // Changed to Green for "found"

                // Save guest info to session when found
                BookingSession.GuestID = sessionGuest.GuestID;
                BookingSession.GuestFirstName = sessionGuest.FirstName;
                BookingSession.GuestLastName = sessionGuest.LastName;
                BookingSession.GuestEmail = sessionGuest.Email;
                BookingSession.GuestPhone = sessionGuest.PhoneNumber;
                BookingSession.GuestIDNumber = sessionGuest.IdentificationNumber;
                BookingSession.GuestIDType = sessionGuest.IdentificationType;
                BookingSession.GuestStreet = sessionGuest.Street;
                BookingSession.GuestSuburb = sessionGuest.Suburb;
                BookingSession.GuestPostalCode = sessionGuest.PostalCode;
                BookingSession.GuestCity = sessionGuest.City;
                BookingSession.GuestCountry = sessionGuest.Country;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back? Your current inputs will be discarded.",
                "Confirm Back",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Go back to previous form (adjust form name as needed)
                GuestAccount prevForm = new GuestAccount();
                prevForm.Show();
                this.Hide();
            }
        }



        private void nextBtn_Click(object sender, EventArgs e)
        {
            // Check if guest was found
            if (sessionGuest == null)
            {
                MessageBox.Show("Please search for a guest first.");
                return;
            }

            // Check if guest info is in session
            if (string.IsNullOrEmpty(BookingSession.GuestIDNumber))
            {
                MessageBox.Show("Guest information not found. Please search again.");
                return;
            }

            // Go to next form
            ExistingGuestDetails nextForm = new ExistingGuestDetails();
            nextForm.Show();
            this.Hide();
        }

        private void SearchExistingGuest_Load(object sender, EventArgs e)
        {
            //hide result label on load 
            resultLbl.Visible = false;
        }
    }
}
