namespace PhumlaKamnandiProject.UI
{
    partial class OccupancyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.genReportBtn = new System.Windows.Forms.Button();
            this.occupancyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateLbl = new System.Windows.Forms.Label();
            this.weeklyOccupLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.occupancyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(317, 15);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // genReportBtn
            // 
            this.genReportBtn.Location = new System.Drawing.Point(555, 12);
            this.genReportBtn.Name = "genReportBtn";
            this.genReportBtn.Size = new System.Drawing.Size(99, 23);
            this.genReportBtn.TabIndex = 1;
            this.genReportBtn.Text = "Generate Report";
            this.genReportBtn.UseVisualStyleBackColor = true;
            this.genReportBtn.Click += new System.EventHandler(this.genReportBtn_Click);
            // 
            // occupancyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.occupancyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.occupancyChart.Legends.Add(legend2);
            this.occupancyChart.Location = new System.Drawing.Point(116, 90);
            this.occupancyChart.Name = "occupancyChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.occupancyChart.Series.Add(series2);
            this.occupancyChart.Size = new System.Drawing.Size(642, 400);
            this.occupancyChart.TabIndex = 2;
            this.occupancyChart.Text = "Weekly Occupancy Levels";
            this.occupancyChart.Click += new System.EventHandler(this.occupancyChart_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(127, 22);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(105, 13);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Select Start Date";
            // 
            // weeklyOccupLbl
            // 
            this.weeklyOccupLbl.AutoSize = true;
            this.weeklyOccupLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyOccupLbl.Location = new System.Drawing.Point(282, 53);
            this.weeklyOccupLbl.Name = "weeklyOccupLbl";
            this.weeklyOccupLbl.Size = new System.Drawing.Size(235, 25);
            this.weeklyOccupLbl.TabIndex = 4;
            this.weeklyOccupLbl.Text = "Weekly Occupancy Levels";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(710, 506);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(833, 506);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 545);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.weeklyOccupLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.occupancyChart);
            this.Controls.Add(this.genReportBtn);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "OccupancyReport";
            this.Text = "OccupancyReport";
            this.Load += new System.EventHandler(this.OccupancyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.occupancyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button genReportBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart occupancyChart;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label weeklyOccupLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}