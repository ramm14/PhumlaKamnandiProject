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
    public partial class OccupancyReport : Form
    {
        public OccupancyReport()
        {
            InitializeComponent();
        }

        private void genReportBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = startDate.AddDays(7);

            try
            {
                BookingController bookingController = new BookingController();
                List<Booking> bookings = bookingController.GetBookingsByDateRange(startDate, endDate); //get overlapping bookings (non-cancelled)

                // Calculate occupied rooms per day
                Dictionary<DateTime, int> occupiedCount = new Dictionary<DateTime, int>();
                for (int i=0;i<7;i++)
                {
                    DateTime day = startDate.AddDays(i);

                    int count = bookings.Count(b => b.CheckInDate <= day && b.CheckOutDate > day); // count bookings active on this day (checkin <= checkout)
                    occupiedCount[day] = count;
                }

                //clear and set up chart
                occupancyChart.Series.Clear();
                Series series = new Series("Occupied Rooms");
                series.ChartType = SeriesChartType.Column;
                series.Color = System.Drawing.Color.Blue;

                foreach (var kvp in occupiedCount.OrderBy(k=>k.Key))
                {
                    series.Points.AddXY(kvp.Key.ToShortDateString(), kvp.Value);
                }

                occupancyChart.Series.Add(series);

                // set up axes
                occupancyChart.ChartAreas[0].AxisX.Title = "Dates Occupied";
                occupancyChart.ChartAreas[0].AxisY.Title = "Number of Occupied Rooms";
                occupancyChart.ChartAreas[0].AxisX.Interval = 1;
                occupancyChart.ChartAreas[0].AxisY.Minimum = 0;

                //RoomController roomController = new RoomController();
                //int totalRooms = roomController.GetTotalRoomCount();
                //occupancyChart.ChartAreas[0].AxisY.Maximum = totalRooms;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }

        private void OccupancyReport_Load(object sender, EventArgs e)
        {

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

        private void occupancyChart_Click(object sender, EventArgs e)
        {

        }
    }
}
