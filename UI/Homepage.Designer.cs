namespace PhumlaKamnandiProject.UI
{
    partial class Homepage
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNowButton = new System.Windows.Forms.Button();
            this.reportTypeCmb = new System.Windows.Forms.ComboBox();
            this.genReportBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectReportLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Manage Bookings\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(104, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 69);
            this.label3.TabIndex = 12;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(128, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(868, 69);
            this.label2.TabIndex = 11;
            this.label2.Text = "PHUMLA KAMNANDI HOTELS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(480, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "WELCOME TO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookNowButton
            // 
            this.bookNowButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNowButton.Location = new System.Drawing.Point(502, 229);
            this.bookNowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookNowButton.Name = "bookNowButton";
            this.bookNowButton.Size = new System.Drawing.Size(180, 41);
            this.bookNowButton.TabIndex = 9;
            this.bookNowButton.Text = "Book Now";
            this.bookNowButton.UseVisualStyleBackColor = true;
            this.bookNowButton.Click += new System.EventHandler(this.bookNowButton_Click);
            // 
            // reportTypeCmb
            // 
            this.reportTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeCmb.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeCmb.FormattingEnabled = true;
            this.reportTypeCmb.Items.AddRange(new object[] {
            "Occupancy Level Report",
            "Revenue Report"});
            this.reportTypeCmb.Location = new System.Drawing.Point(472, 429);
            this.reportTypeCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportTypeCmb.Name = "reportTypeCmb";
            this.reportTypeCmb.Size = new System.Drawing.Size(231, 24);
            this.reportTypeCmb.TabIndex = 14;
            this.reportTypeCmb.SelectedIndexChanged += new System.EventHandler(this.reportTypeCmb_SelectedIndexChanged);
            // 
            // genReportBtn
            // 
            this.genReportBtn.AutoSize = true;
            this.genReportBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genReportBtn.Location = new System.Drawing.Point(486, 472);
            this.genReportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genReportBtn.Name = "genReportBtn";
            this.genReportBtn.Size = new System.Drawing.Size(195, 39);
            this.genReportBtn.TabIndex = 15;
            this.genReportBtn.Text = "Generate Report";
            this.genReportBtn.UseVisualStyleBackColor = true;
            this.genReportBtn.Click += new System.EventHandler(this.genReportBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhumlaKamnandiProject.Properties.Resources.valeriia_bugaiova__pPHgeHz1uk_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1121, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // selectReportLbl
            // 
            this.selectReportLbl.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.selectReportLbl.Location = new System.Drawing.Point(456, 381);
            this.selectReportLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectReportLbl.Name = "selectReportLbl";
            this.selectReportLbl.Size = new System.Drawing.Size(290, 34);
            this.selectReportLbl.TabIndex = 16;
            this.selectReportLbl.Text = "Select Report To Generate:";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 552);
            this.Controls.Add(this.selectReportLbl);
            this.Controls.Add(this.genReportBtn);
            this.Controls.Add(this.reportTypeCmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookNowButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookNowButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox reportTypeCmb;
        private System.Windows.Forms.Button genReportBtn;
        private System.Windows.Forms.Label selectReportLbl;
    }
}