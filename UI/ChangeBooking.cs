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
    public partial class ChangeBooking : Form
    {
        private Booking currentBooking;
        private BookingController bookingController;
        private RoomController roomController;

        public ChangeBooking(Booking booking)
        {
            InitializeComponent();
            bookingController = new BookingController();
            roomController = new RoomController();
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
                MessageBox.Show("Error loading booking: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void LoadBookingDetails()
        {
 
            noAdultsTxt.Text = currentBooking.NoOfAdults.ToString();
            noChildrenTxt.Text = currentBooking.NoOfChildren.ToString();
            checkInTxt.Text = currentBooking.CheckInDate.ToString("dd/MM/yyyy");
            checkOutTxt.Text = currentBooking.CheckOutDate.ToString("dd/MM/yyyy");
            requestsTxt.Text = currentBooking.Requests;


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

        private void ChangeBooking_Load(object sender, EventArgs e)
        {

        }

        private void checkinLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to save these changes?", "Confirm Changes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;
            try
            {


                DateTime newCheckIn, newCheckOut;

                try
                {
                     newCheckIn = DateTime.ParseExact(checkInTxt.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Invalid check-in date. Use dd/mm/yyyy format.");
                    return;
                }

                try
                {
                    newCheckOut = DateTime.ParseExact(checkOutTxt.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Invalid check-in date. Use dd/mm/yyyy format.");
                    return;
                }



                if (newCheckOut <= newCheckIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Validation Error.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int newAdults, newChildren;
                if (!int.TryParse(noAdultsTxt.Text, out newAdults) || newAdults <= 0)
                {
                    MessageBox.Show("Please enter a valid number of adults.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(noChildrenTxt.Text, out newChildren) || newChildren < 0)
                {
                    MessageBox.Show("Please enter a valid number of children.", "Validation Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Room> availableRooms = roomController.GetAvailableRooms(newCheckIn, newCheckOut);

                bool isRoomAvailable = availableRooms.Any(r => r.RoomID == currentBooking.Room.RoomID);

                if (!isRoomAvailable)
                {
                    DialogResult result = MessageBox.Show(
                        "The current room is not available for those dates.\nWould you like to assign another available room?",
                        "Room Unavailable",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Room newRoom = availableRooms.FirstOrDefault();
                        currentBooking.Room = newRoom ?? currentBooking.Room;
                    }
                    else
                    {
                        return;
                    }

                }
                string requests = requestsTxt.Text;
                decimal lastestRoomPrice = roomController.CalculateStayCost(newCheckIn, newCheckOut);
                bool updated = bookingController.ChangeBooking(
                    currentBooking.BookingID,
                    newCheckIn,
                    newCheckOut,
                    newAdults,
                    newChildren,
                    lastestRoomPrice,requests);

                if (updated)
                {

                    MessageBox.Show("Booking details updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No changes were made to the booking.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
