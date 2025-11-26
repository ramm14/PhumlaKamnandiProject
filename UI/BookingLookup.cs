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
    public partial class BookingLookup : Form
    {
        private BookingController bookingController = new BookingController();

        public BookingLookup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the 'About Us' page? Your current inputs will be discarded.",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AboutPage aboutPage = new AboutPage();
                aboutPage.Show();
                this.Hide();
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
                Homepage prevForm = new Homepage(); 
                prevForm.Show();
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
                Application.Exit();
            }
        }

        private void cancelBookingBtn_Click(object sender, EventArgs e)
        {
            Booking booking = null;
            if (int.TryParse(bookingIdTxt.Text.Trim(), out int bookingID))
            {
                try
                {
                    booking = bookingController.GetBookingDetails(bookingID);
                    if (booking != null)
                    {
                        bookingIdTxt.Clear();
                        CancelBooking nextform = new CancelBooking(booking);
                        nextform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No booking found with that reference found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("Please enter a Valid Booking ID", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void changeBookingBtn_Click(object sender, EventArgs e)
        {
            Booking booking = null;
            if (int.TryParse(bookingIdTxt.Text.Trim(), out int bookingID))
            {
                try
                {
                    booking = bookingController.GetBookingDetails(bookingID);
                    if (booking != null)
                    {
                        bookingIdTxt.Clear();
                        ChangeBooking nextForm = new ChangeBooking(booking);
                        nextForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No booking found with that reference found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("Please enter a Valid Booking ID", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BookingLookup_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enquireBookingBtn_Click(object sender, EventArgs e)
        {
            Booking booking = null;
            if (int.TryParse(bookingIdTxt.Text.Trim(), out int bookingID))
            {
                try
                {
                    booking = bookingController.GetBookingDetails(bookingID);
                    if(booking != null)
                    {
                        bookingIdTxt.Clear();
                        MakeEnquiry enquiryForm = new MakeEnquiry(booking);
                        enquiryForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No booking found with that reference found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("Please enter a Valid Booking ID", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Booking FindBooking(string rawInput)
        {
            Booking booking = null;
            if (int.TryParse(bookingIdTxt.Text.Trim(), out int bookingID))
            {
                try
                {
                    booking = bookingController.GetBookingDetails(bookingID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               
            }
            else
            {
                MessageBox.Show("Please enter a Valid Booking ID", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return booking;


        }

        private void bookingIdTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
