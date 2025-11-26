using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandiProject.Business;

namespace PhumlaKamnandiProject.UI
{
    public partial class MakeEnquiry : Form
    {
        private Booking currentBooking;
        private BookingController bookingController;
        public MakeEnquiry(Booking booking)
        {
            InitializeComponent();
            bookingController = new BookingController();
            currentBooking = booking;

            try
            {
                if (currentBooking == null)
                {
                    MessageBox.Show("Booking not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                LoadBookingDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking details: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookingDetails()
        {
            try
            {
                bookingIdTxt.Text = currentBooking.BookingID.ToString();
                nameTxt.Text = currentBooking.Guest.FirstName;
                surnameTxt.Text = currentBooking.Guest.LastName;
                roomNoTxt.Text = currentBooking.Room.RoomNumber;
                checkInTxt.Text = currentBooking.CheckInDate.ToString("dd/mm/yyyy");
                checkOutTxt.Text = currentBooking.CheckOutDate.ToString("dd/mm/yyyy");
                noAdultsTxt.Text = currentBooking.NoOfAdults.ToString();
                noChildrenTxt.Text = currentBooking.NoOfChildren.ToString();
                requestsTxt.Text = currentBooking.Requests;
                totalAmountTxt.Text = currentBooking.TotalAmount.ToString("0.00");

                string bookingStatusText;
            switch (currentBooking.Status)
                {
                    case Booking.StatusOfBooking.Confirmed:
                        bookingStatusText = "Confirmed (Deposit Paid)";
                        statusTxt.ForeColor = System.Drawing.Color.Green;
                        break;

                    case Booking.StatusOfBooking.Unconfirmed:
                        bookingStatusText = "Unconfirmed (Awaiting Deposit)";
                        statusTxt.ForeColor = System.Drawing.Color.OrangeRed;
                        break;

                    case Booking.StatusOfBooking.CheckedIn:
                        bookingStatusText = "Check In";
                        statusTxt.ForeColor = System.Drawing.Color.Purple;
                        break;

                    default:
                        bookingStatusText = "Unknown";
                        statusTxt.ForeColor = System.Drawing.Color.Black;
                        break;
                }

                statusTxt.Text = bookingStatusText;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying booking details: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void MakeEnquiry_Load(object sender, EventArgs e)
        {

        }
    }
}
