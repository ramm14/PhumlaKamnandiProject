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
    public partial class ReservationDetails : Form
    {
        public ReservationDetails()
        {
            InitializeComponent();
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

        private void roomPriceLbl_Click(object sender, EventArgs e)
        {

        }

        

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            ReservationDetailsRoomPrice nextForm = new ReservationDetailsRoomPrice(); 
            nextForm.Show();
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
                Homepage homePage = new Homepage(); 
                homePage.Show();
                this.Hide();
            }
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
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

        private void findRooms_Click(object sender, EventArgs e)
        {
            try
            {
                if (startDateTxt.Text == "" || endDateTxt.Text == "")
                {
                    MessageBox.Show("Please enter both dates.");
                    return;
                }

                DateTime checkIn;
                DateTime checkOut;

                try
                {
                    checkIn = DateTime.ParseExact(startDateTxt.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Invalid check-in date. Use dd/mm/yyyy format.");
                    return;
                }

                try
                {
                    checkOut = DateTime.ParseExact(endDateTxt.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Invalid check-out date. Use dd/mm/yyyy format.");
                    return;
                }

                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.");
                    return;
                }

                if (checkIn < DateTime.Now.Date)
                {
                    MessageBox.Show("Check-in date cannot be in the past.");
                    return;
                }

                RoomController roomController = new RoomController();
                List<Room> availableRooms = roomController.GetAvailableRooms(checkIn, checkOut);

                if (availableRooms.Count == 0)
                {
                    MessageBox.Show("No rooms available for these dates.");
                    return;
                }

                decimal totalCost = roomController.CalculateStayCost(checkIn, checkOut);
                int nights = (checkOut - checkIn).Days;

                // Save to session
                Random random = new Random();
                int randomIndex = random.Next(availableRooms.Count);
                BookingSession.SelectedRoomID = availableRooms[randomIndex].RoomID; // All rooms are the same 
                BookingSession.CheckInDate = checkIn;
                BookingSession.CheckOutDate = checkOut;
                BookingSession.TotalAmount = totalCost;
                BookingSession.setDeposit();

                if (noAdultsTxt.Text != "")
                {
                    BookingSession.NumberOfAdults = int.Parse(noAdultsTxt.Text);
                }
                else
                {
                    BookingSession.NumberOfAdults = 1;
                }

                if (noChildrenTxt.Text != "")
                {
                    BookingSession.NumberOfChildren = int.Parse(noChildrenTxt.Text);
                }
                else
                {
                    BookingSession.NumberOfChildren = 0;
                }
 

                MessageBox.Show("Found " + availableRooms.Count + " available rooms\n" +
                               "Number of nights: " + nights + "\n" +
                               "Total cost: R" + totalCost);

                nextBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
