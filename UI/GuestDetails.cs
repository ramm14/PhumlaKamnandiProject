using PhumlaKamnandiProject.Business;

using PhumlaKamnandiProject.Data;

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
    public partial class GuestDetails : Form
    {
        private BookingController bookingController;
        private GuestController guestController;
        private RoomController roomController;
        public GuestDetails()
        {
            InitializeComponent();
            bookingController = new BookingController();
            guestController = new GuestController();
            roomController = new RoomController();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage(); 
            homePage.Show();
            this.Hide();
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

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Visible = false;
                if (identityDocTxt.SelectedIndex == -1)
                {
                    ShowStatus("Please select a ID Document type. ", false);
                    return;
                }

                // Basic validation 
                if (string.IsNullOrWhiteSpace(nameText.Text) ||
                    string.IsNullOrWhiteSpace(surnameText.Text) ||
                    string.IsNullOrWhiteSpace(emailAddText.Text))
                {
                    ShowStatus("Please fill in all required fields.", false);
                    return;
                }

                if (!emailAddText.Text.Contains("@"))
                {
                    ShowStatus("Please enter a valid email address.", false);
                    return;
                }

                // Create a new Guest object 
                string FirstName = nameText.Text.Trim();
                string LastName = surnameText.Text.Trim();
                string Email = emailAddText.Text.Trim();
                string PhoneNumber = phoneNoTxt.Text.Trim();
                string IdentificationNumber = identityText.Text.Trim();
                string Street = streetText.Text.Trim();
                string Suburb = surburbText.Text.Trim();
                string PostalCode = postalCodeText.Text.Trim();
                string City = cityText.Text.Trim();
                string Country = countryText.Text.Trim();
                IdentityDocument selectedDocument = identityDocTxt.SelectedItem.ToString() == "NationalID" ? IdentityDocument.NationalID : IdentityDocument.PassportNo;



                // Create Guest
                Guest guest = guestController.AddGuest(FirstName, LastName, Email, PhoneNumber,
                    IdentificationNumber, selectedDocument,
                    Street, Suburb, PostalCode, City, Country);

                // SAVE TO SESSION
                BookingSession.GuestID = guest.GuestID;
                BookingSession.GuestFirstName = guest.FirstName;
                BookingSession.GuestLastName = guest.LastName;
                BookingSession.GuestEmail = guest.Email;
                BookingSession.GuestPhone = guest.PhoneNumber;
                BookingSession.GuestIDNumber = guest.IdentificationNumber;
                BookingSession.GuestIDType = guest.IdentificationType;
                BookingSession.GuestStreet = guest.Street;
                BookingSession.GuestSuburb = guest.Suburb;
                BookingSession.GuestPostalCode = guest.PostalCode;
                BookingSession.GuestCity = guest.City;
                BookingSession.GuestCountry = guest.Country;

                ShowStatus("Guest account has been created!", true);
            }
            catch (FormatException)
            {
                ShowStatus("Invalid data format. Please check your input.", false);
            }
            catch (Exception ex)
            {
                ShowStatus("An unexpected error occurred: " + ex.Message, false);
            }
        }
        private void ShowStatus(string message, bool success)

        {

            statusLabel.Text = message;

            statusLabel.ForeColor = success ? Color.Green : Color.Red;

            statusLabel.Visible = true;

        }

        private void next_Click(object sender, EventArgs e)
        {
            // Check if guest was created
            if (string.IsNullOrEmpty(BookingSession.GuestID))
            {
                MessageBox.Show("Please create guest account first.");
                return;
            }

            ReservationConfirmation nextForm = new ReservationConfirmation();
            nextForm.Show();
            this.Hide();
        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the Home Page?\nYour current inputs will be discarded.",
                "Confirm Navigation",
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the About Page?\nYour current inputs will be discarded.",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                AboutPage aboutPage = new AboutPage();
                aboutPage.Show();
                this.Hide();

            }

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                            "Are you sure you want to return to the Home Page? Your current inputs will be discarded.",
                            "Confirm Navigation",
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

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
