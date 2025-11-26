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
    public partial class CancelBooking : Form
    {
        private Booking currentBooking;
        private BookingController bookingController;
        private RoomController roomController;

        public CancelBooking(Booking booking)
        {
            InitializeComponent();
            currentBooking = booking;
            bookingController = new BookingController();
            roomController = new RoomController();
            LoadBookingDetails();

        }

        private void LoadBookingDetails()
        {
            try
            {
                bookingIdTxt.Text = currentBooking.BookingID.ToString();
                nameTxt.Text = currentBooking.Guest.FirstName;
                surnameTxt.Text = currentBooking.Guest.LastName;
                checkInTxt.Text = currentBooking.CheckInDate.ToString("dd/mm/yyyy");
                checkOutTxt.Text = currentBooking.CheckOutDate.ToString("dd/mm/yyyy");
                roomNoTxt.Text = currentBooking.Room.RoomNumber;
                noAdultsTxt.Text = currentBooking.NoOfAdults.ToString();
                noChildrenTxt.Text = currentBooking.NoOfChildren.ToString();
                statusTxt.Text = currentBooking.Status.ToString();
                totalAmountTxt.Text = currentBooking.TotalAmount.ToString("0.00");
                requestsTxt.Text = currentBooking.Requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking details: " + ex.Message,
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {

        }

        private void confirmCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you to cancel this booking?\nThis action cannot be undone.",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            try
            {
                bool success = bookingController.CancelBooking(currentBooking.BookingID);
                roomController.UpdateRoom(currentBooking.Room);

                if (success)
                {
                    MessageBox.Show("Booking successful cancelled and removed from the system.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to cancel booking. Please check the booking ID.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling booking: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noChildrenLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
