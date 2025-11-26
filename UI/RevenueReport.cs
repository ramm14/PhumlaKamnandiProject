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
using System.Windows.Forms.DataVisualization.Charting;

namespace PhumlaKamnandiProject.UI
{
    public partial class RevenueReport : Form
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        private void revenueChart_Click(object sender, EventArgs e)
        {

        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {

        }

        private void genReportBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = startDate.AddDays(7);

            try
            {
                BookingController bookingController = new BookingController();
                List<Booking> bookings = bookingController.GetBookingsByDateRange(startDate, endDate);

                // Calculate daily revenuue- summing total amount for bookings active on each day
                Dictionary<DateTime, decimal> dailyRevenue = new Dictionary<DateTime, decimal>();
                RoomController roomController = new RoomController();

                for (int i=0;i<7;i++)
                {
                    DateTime day = startDate.AddDays(i);
                    decimal revenue = 0;

                    foreach (Booking b in bookings)
                    {
                        if (b.CheckInDate <= day && b.CheckOutDate > day && (b.Status==Booking.StatusOfBooking.Confirmed || b.Status==Booking.StatusOfBooking.CheckedIn || b.Status==Booking.StatusOfBooking.CheckedOut ))
                        {
                            //calculate revenue per night
                            int totalNights = (b.CheckOutDate - b.CheckInDate).Days;
                            decimal nightlyRevenue = totalNights > 0 ? b.TotalAmount / totalNights : b.TotalAmount;
                            revenue += nightlyRevenue;
                        }
                    }
                    dailyRevenue[day] = revenue;
                }
                //set up chart
                revenueChart.Series.Clear();
                Series series = new Series("Daily Revenue");
                series.ChartType = SeriesChartType.Column;
                series.Color = System.Drawing.Color.Green;

                foreach (var kvp in dailyRevenue.OrderBy(k=>k.Key))
                {
                    series.Points.AddXY(kvp.Key.ToShortDateString(), kvp.Value);

                }
                revenueChart.Series.Add(series);

                //axes
                revenueChart.ChartAreas[0].AxisX.Title = "Dates";
                revenueChart.ChartAreas[0].AxisY.Title = "Revenue";
                revenueChart.ChartAreas[0].AxisX.Interval = 1;
                revenueChart.ChartAreas[0].AxisY.Minimum = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
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
                Homepage homePage = new Homepage();
                homePage.Show();
                this.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to go cancel? Your current inputs will be discarded.",
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
    }
}
