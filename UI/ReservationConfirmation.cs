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
    public partial class ReservationConfirmation : Form
    {
        //private Booking _booking;

        public ReservationConfirmation()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
            PaymentInformation nextForm = new PaymentInformation();
            nextForm.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to cancel? Your current inputs will be discarded.",  
            "Confirm Cancel",                   
            MessageBoxButtons.YesNo,           
            MessageBoxIcon.Warning               
        );

            if (result == DialogResult.Yes)
            {
                ExistingGuestDetails homePage = new ExistingGuestDetails(); 
                homePage.Show();
                this.Hide();
            }
        }

        private void ReservationConfirmation_Load(object sender, EventArgs e)
        {
            // Get data from BookingSession instead of _booking object
            if (!string.IsNullOrEmpty(BookingSession.GuestID))
            {
              
                primaryGuestTxt.Text = "Guest";
                emailTxt.Text = BookingSession.GuestEmail;
                phoneTxt.Text = BookingSession.GuestPhone; 
                occupancyTxt.Text = $"{BookingSession.NumberOfAdults} Adults, {BookingSession.NumberOfChildren} Children";
                roomTypeTxt.Text = "Standard Room";
                totalAccomTxt.Text = "R" + BookingSession.TotalAmount.ToString("F2");
                checkinTxt.Text = BookingSession.CheckInDate.ToString("dd/MM/yyyy");
                checkoutTxt.Text = BookingSession.CheckOutDate.ToString("dd/MM/yyyy");

                // all fields read-only
                primaryGuestTxt.ReadOnly = true;
                emailTxt.ReadOnly = true;
                phoneTxt.ReadOnly = true;
                occupancyTxt.ReadOnly = true;
                roomTypeTxt.ReadOnly = true;
                totalAccomTxt.ReadOnly = true;
                checkinTxt.ReadOnly = true;
                checkoutTxt.ReadOnly = true;
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

        }

        private void occupancyTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
