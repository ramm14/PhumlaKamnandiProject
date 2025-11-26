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
    public partial class ReservationDetailsRoomPrice : Form
    {
        public ReservationDetailsRoomPrice()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ReservationDetailsRoomPrice_Load);
        }
        private void ReservationDetailsRoomPrice_Load(object sender, EventArgs e)
        {
            // Display booking information from session
            if (BookingSession.CheckInDate != DateTime.MinValue)
            {
                startDateTxt.Text = BookingSession.CheckInDate.ToString("dd/MM/yyyy");
                endDateTxt.Text = BookingSession.CheckOutDate.ToString("dd/MM/yyyy");
                noAdultsTxt.Text = BookingSession.NumberOfAdults.ToString();
                noChildrenTxt.Text = BookingSession.NumberOfChildren.ToString();
                totalCostTxt.Text = "R" + BookingSession.TotalAmount.ToString("F2");

                // Make all fields read-only
                startDateTxt.ReadOnly = true;
                endDateTxt.ReadOnly = true;
                noAdultsTxt.ReadOnly = true;
                noChildrenTxt.ReadOnly = true;
                totalCostTxt.ReadOnly = true;
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
                ReservationDetails homePage = new ReservationDetails();
                homePage.Show();
                this.Hide();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // Validate that booking details exist in session
            if (BookingSession.CheckInDate == DateTime.MinValue ||
                BookingSession.CheckOutDate == DateTime.MinValue)
            {
                MessageBox.Show("Please select dates first from Reservation Details.");
                return;
            }

            if (BookingSession.TotalAmount <= 0)
            {
                MessageBox.Show("Invalid booking amount. Please go back and search for rooms.");
                return;
            }

            // Proceed to next form
            GuestAccount nextForm = new GuestAccount();
            nextForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
