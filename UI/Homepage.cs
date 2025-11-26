using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PhumlaKamnandiProject.UI
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e) //other booking option
        {
            BookingLookup bookingLookup = new BookingLookup();
            bookingLookup.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }

        private void bookNowButton_Click(object sender, EventArgs e) //book now button
        {
            ReservationDetails detailsForm = new ReservationDetails();
            detailsForm.Show();  // Opens the ReservationDetails form
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void genReportBtn_Click(object sender, EventArgs e)
        {
            if (reportTypeCmb.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }
            string selectedReport = reportTypeCmb.SelectedItem.ToString();

            if (selectedReport == "Occupancy Level Report")
            {
                OccupancyReport reportForm = new OccupancyReport();
                reportForm.ShowDialog();
            }
            else if (selectedReport == "Revenue Report")
            {
                RevenueReport reportForm = new RevenueReport();
                reportForm.ShowDialog();
            }
        }

        private void reportTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
