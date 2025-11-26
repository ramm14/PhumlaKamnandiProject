using PhumlaKamnandiProject.Business;
using PhumlaKamnandiProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhumlaKamnandiProject.UI
{
    public partial class ExistingGuestDetails : Form
    {
        private GuestController guestController;
        public ExistingGuestDetails()
        {
            InitializeComponent();
            nameTxt.Text = BookingSession.GuestFirstName;
            surnameTxt.Text = BookingSession.GuestLastName;
            emailTxt.Text = BookingSession.GuestEmail;
            phoneTxt.Text = BookingSession.GuestPhone;
            idTxt.Text = BookingSession.GuestIDNumber;
            streetTxt.Text = BookingSession.GuestStreet;
            suburbTxt.Text = BookingSession.GuestSuburb;
            postalTxt.Text = BookingSession.GuestPostalCode;
            cityTxt.Text = BookingSession.GuestCity;
            countryTxt.Text = BookingSession.GuestCountry;
            guestController = new GuestController();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to go back? Your current inputs will be discarded.",  
            "Confirm Back",                   
            MessageBoxButtons.YesNo,            
            MessageBoxIcon.Warning               
        );

            if (result == DialogResult.Yes)
            {
                GuestAccount homePage = new GuestAccount();
                homePage.Show();
                this.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Are you sure you want to cancel? Your current inputs will be discarded.",  
           "Confirm Cancel",                   
           MessageBoxButtons.YesNo,            
           MessageBoxIcon.Warning               
       );

            if (result == DialogResult.Yes)
            {
                Homepage homePage = new Homepage(); 
                homePage.Show();
                this.Hide();
            }
        }


        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that guest ID is entered
                if (string.IsNullOrWhiteSpace(idTxt.Text))
                {
                    MessageBox.Show("Please enter Guest ID.");
                    return;
                }

                // Get guest from database
                GuestDA guestDA = new GuestDA();
                Guest guest = guestDA.SearchByID(idTxt.Text.Trim());

                if (guest == null || string.IsNullOrEmpty(guest.GuestID))
                {
                    MessageBox.Show("Guest not found. Please check the Guest ID.");
                    return;
                }

                // SAVE ALL GUEST INFO TO SESSION
                //BookingSession.GuestID = guest.GuestID;
                //BookingSession.GuestFirstName = guest.FirstName;
                //BookingSession.GuestLastName = guest.LastName;
                //BookingSession.GuestEmail = guest.Email;
                //BookingSession.GuestPhone = guest.PhoneNumber;
                //BookingSession.GuestIDNumber = guest.IdentificationNumber;
                //BookingSession.GuestIDType = guest.IdentificationType;
                //BookingSession.GuestStreet = guest.Street;
                //BookingSession.GuestSuburb = guest.Suburb;
                //BookingSession.GuestPostalCode = guest.PostalCode;
                //BookingSession.GuestCity = guest.City;
                //BookingSession.GuestCountry = guest.Country
                BookingSession.GuestFirstName = nameTxt.Text.Trim();
                BookingSession.GuestLastName = surnameTxt.Text.Trim();
                BookingSession.GuestEmail = emailTxt.Text.Trim();
                BookingSession.GuestPhone = phoneTxt.Text.Trim();
                BookingSession.GuestIDNumber = idTxt.Text.Trim();
                BookingSession.GuestStreet = streetTxt.Text.Trim();
                BookingSession.GuestSuburb = suburbTxt.Text.Trim();
                BookingSession.GuestPostalCode = postalTxt.Text.Trim();
                BookingSession.GuestCity = cityTxt.Text.Trim();
                BookingSession.GuestCountry = countryTxt.Text.Trim();

                // Go to reservation confirmation
                ReservationConfirmation nextForm = new ReservationConfirmation();
                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the About Page?\nAll unsaved changes will be lost.",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                AboutPage aboutPage = new AboutPage(); // Replace with your About form name
                aboutPage.Show();
                this.Hide();
            
        }

    }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            try

            {

                statusLabel.Visible = false;



                // Validation 

                if (string.IsNullOrWhiteSpace(idTxt.Text))

                {

                    ShowStatus("Guest ID is required to update an existing record.", false);

                    return;

                }



                if (string.IsNullOrWhiteSpace(nameTxt.Text) ||

                    string.IsNullOrWhiteSpace(surnameTxt.Text) ||

                    string.IsNullOrWhiteSpace(emailTxt.Text))

                {

                    ShowStatus("Please fill in all required fields.", false);

                    return;

                }



                if (!emailTxt.Text.Contains("@"))

                {

                    ShowStatus("Please enter a valid email address.", false);

                    return;

                }



                // Construct Guest object
                Guest currentGuest = guestController.FindGuestWithIDNo(BookingSession.GuestIDNumber);
                currentGuest.FirstName = nameTxt.Text;
                currentGuest.LastName = surnameTxt.Text.Trim();
                currentGuest.Email = emailTxt.Text.Trim();
                currentGuest.PhoneNumber = phoneTxt.Text.Trim();
                currentGuest.IdentificationNumber = idTxt.Text.Trim();
                currentGuest.Street = streetTxt.Text.Trim();
                currentGuest.Suburb = suburbTxt.Text.Trim();
                currentGuest.PostalCode = postalTxt.Text.Trim();
                currentGuest.City = cityTxt.Text.Trim();
                currentGuest.Country = countryTxt.Text.Trim();

                //Update DB

                bool success = guestController.UpdateGuest(currentGuest);



                if (success)

                {

                    ShowStatus("Guest account has been updated successfully!", true);

                }

                else

                {

                    ShowStatus("No record was updated. Please check the Guest ID.", false);

                }

            }

            catch (Exception ex)

            {

                ShowStatus("Error updating guest: " + ex.Message, false);

            }
        }

        private void ShowStatus(string message, bool success)

        {

            statusLabel.Text = message;

            statusLabel.ForeColor = success ? Color.Green : Color.Red;

            statusLabel.Visible = true;

        }

        private void countryTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
