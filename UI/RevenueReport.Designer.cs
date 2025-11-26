namespace PhumlaKamnandiProject.UI
{
    partial class RevenueReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.genReportBtn = new System.Windows.Forms.Button();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyRevLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(325, 26);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // genReportBtn
            // 
            this.genReportBtn.Location = new System.Drawing.Point(573, 23);
            this.genReportBtn.Name = "genReportBtn";
            this.genReportBtn.Size = new System.Drawing.Size(104, 23);
            this.genReportBtn.TabIndex = 1;
            this.genReportBtn.Text = "Generate Report";
            this.genReportBtn.UseVisualStyleBackColor = true;
            this.genReportBtn.Click += new System.EventHandler(this.genReportBtn_Click);
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLbl.Location = new System.Drawing.Point(128, 33);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(109, 13);
            this.startDateLbl.TabIndex = 2;
            this.startDateLbl.Text = "Select  Start Date";
            // 
            // revenueChart
            // 
            chartArea1.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.revenueChart.Legends.Add(legend1);
            this.revenueChart.Location = new System.Drawing.Point(146, 119);
            this.revenueChart.Name = "revenueChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.revenueChart.Series.Add(series1);
            this.revenueChart.Size = new System.Drawing.Size(597, 360);
            this.revenueChart.TabIndex = 3;
            this.revenueChart.Text = "chart1";
            this.revenueChart.Click += new System.EventHandler(this.revenueChart_Click);
            // 
            // weeklyRevLbl
            // 
            this.weeklyRevLbl.AutoSize = true;
            this.weeklyRevLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyRevLbl.Location = new System.Drawing.Point(320, 71);
            this.weeklyRevLbl.Name = "weeklyRevLbl";
            this.weeklyRevLbl.Size = new System.Drawing.Size(213, 25);
            this.weeklyRevLbl.TabIndex = 4;
            this.weeklyRevLbl.Text = "Weekly Revenue Levels";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(683, 493);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(800, 493);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 528);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.weeklyRevLbl);
            this.Controls.Add(this.revenueChart);
            this.Controls.Add(this.startDateLbl);
            this.Controls.Add(this.genReportBtn);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "RevenueReport";
            this.Text = "RevenueReport";
            this.Load += new System.EventHandler(this.RevenueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button genReportBtn;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
        private System.Windows.Forms.Label weeklyRevLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}