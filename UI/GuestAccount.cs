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
    public partial class GuestAccount : Form
    {
        public GuestAccount()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void newBtn_Click(object sender, EventArgs e)
        {
            GuestDetails nextForm = new GuestDetails(); 
            nextForm.Show();
            this.Hide();
        }

        private void existingBtn_Click(object sender, EventArgs e)
        {
            SearchExistingGuest newForm = new SearchExistingGuest();
            newForm.Show();
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
                ReservationDetailsRoomPrice homePage = new ReservationDetailsRoomPrice();
                homePage.Show();
                this.Hide();
            }
        }

        private void GuestAccount_Load(object sender, EventArgs e)
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
                "Are you sure you want to go to the About Page?\nYour current inputs will be discarded..",
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
    }
}
