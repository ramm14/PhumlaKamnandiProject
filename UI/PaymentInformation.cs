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
    public partial class PaymentInformation : Form
    {
        private PaymentController paymentController;
        private RoomController roomController;
        private BookingController bookingController;
        private GuestController guestController;
        public PaymentInformation()
        {
            InitializeComponent();
            paymentController = new PaymentController();
            roomController = new RoomController();
            bookingController = new BookingController();
            guestController = new GuestController();
            decimal cost = roomController.CalculateStayCost(BookingSession.CheckInDate , BookingSession.CheckOutDate) * 0.10M;
            moneytxt.Text = "R" + cost.ToString("F2");
            moneytxt.ForeColor = Color.Green;

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (card1Txt.Text == "")
                {
                    MessageBox.Show("Please enter card number.");
                    return;
                }

                if (exp1Txt.Text == "")
                {
                    MessageBox.Show("Please enter expiry date.");
                    return;
                }

                if (cvv1Txt.Text == "")
                {
                    MessageBox.Show("Please enter CVV.");
                    return;
                }


                // Validate card number
                if (!IsNumeric(card1Txt.Text))
                {
                    MessageBox.Show("Card number must contain only numbers.");
                    return;
                }

                // Validate CVV
                if (cvv1Txt.Text.Length != 3 || !IsNumeric(cvv1Txt.Text))
                {
                    MessageBox.Show("CVV must be 3 digits.");
                    return;
                }

                // Validate expiry
                DateTime expiry1;
                try
                {
                    expiry1 = DateTime.ParseExact(exp1Txt.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Invalid expiry date. Use dd/mm/yyyy.");
                    return;
                }

                if (expiry1 < DateTime.Now)
                {
                    MessageBox.Show("Card has expired.");
                    return;
                }


                // Create guest object with payment info
                Guest guest = new Guest();
                guest.GuestID = BookingSession.GuestID;
                guest.CardNo = card1Txt.Text.Trim();
                guest.CVV = cvv1Txt.Text.Trim();
                guest.CardExpiry = expiry1;

                // Check GuestID exists
                if (string.IsNullOrEmpty(guest.GuestID))
                {
                    MessageBox.Show("Guest information not found. Please go back.");
                    return;
                }
                
                // Save payment info to database
                GuestDA guestDA = new GuestDA();
                guestDA.insertGuestCardDetails(guest);
                

                // Create booking and save to database
                Guest fullGuest = guestController.GetGuest(BookingSession.GuestID);
                RoomDA roomDA = new RoomDA();
                Room room = roomDA.ReadRoom(BookingSession.SelectedRoomID);
                int bookingID = bookingController.MakeBooking(guest, room, BookingSession.CheckInDate, BookingSession.CheckOutDate, BookingSession.NumberOfAdults, BookingSession.NumberOfChildren, BookingSession.TotalAmount);
                Booking booking = bookingController.GetBookingDetails(bookingID);
                roomController.UpdateRoom(room);
                Payment payment = paymentController.MakePayment(fullGuest ,booking);
                bookingController.UpdateBookingDeposit(booking, payment.PaymentDate);

                // Clear session
                BookingSession.ClearSession();

                MessageBox.Show("Booking completed successfully!");

                EndOfBooking nextForm = new EndOfBooking();
                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel? Your current inputs will be discarded.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

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
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ReservationConfirmation prevForm = new ReservationConfirmation();
                prevForm.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return to the Home Page? Your current inputs will be discarded.",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Homepage homePage = new Homepage();
                homePage.Show();
                this.Hide();
            }
        }

        private void PaymentVerified_Load(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void exp1Txt_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void roomPriceLbl_Click(object sender, EventArgs e) { }
        private void cvv2Lbl_Click(object sender, EventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }

        private void cvv1Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void card2Txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
