namespace PhumlaKamnandiProject.UI
{
    partial class ReservationDetails
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
            this.headerLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.noAdultsLbl = new System.Windows.Forms.Label();
            this.noChildrenLbl = new System.Windows.Forms.Label();
            this.startDateTxt = new System.Windows.Forms.TextBox();
            this.endDateTxt = new System.Windows.Forms.TextBox();
            this.noAdultsTxt = new System.Windows.Forms.TextBox();
            this.noChildrenTxt = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomPriceLbl = new System.Windows.Forms.Label();
            this.findRooms = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(16, 11);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(0, 31);
            this.headerLbl.TabIndex = 0;
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(143, 74);
            this.startDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(151, 16);
            this.startDateLbl.TabIndex = 3;
            this.startDateLbl.Text = "Start Date (dd/mm/yyyy)";
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(143, 129);
            this.endDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(148, 16);
            this.endDateLbl.TabIndex = 4;
            this.endDateLbl.Text = "End Date (dd/mm/yyyy)";
            // 
            // noAdultsLbl
            // 
            this.noAdultsLbl.AutoSize = true;
            this.noAdultsLbl.Location = new System.Drawing.Point(143, 185);
            this.noAdultsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noAdultsLbl.Name = "noAdultsLbl";
            this.noAdultsLbl.Size = new System.Drawing.Size(109, 16);
            this.noAdultsLbl.TabIndex = 5;
            this.noAdultsLbl.Text = "Number of Adults";
            // 
            // noChildrenLbl
            // 
            this.noChildrenLbl.AutoSize = true;
            this.noChildrenLbl.Location = new System.Drawing.Point(143, 239);
            this.noChildrenLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noChildrenLbl.Name = "noChildrenLbl";
            this.noChildrenLbl.Size = new System.Drawing.Size(121, 16);
            this.noChildrenLbl.TabIndex = 6;
            this.noChildrenLbl.Text = "Number of Children";
            // 
            // startDateTxt
            // 
            this.startDateTxt.Location = new System.Drawing.Point(477, 65);
            this.startDateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.Size = new System.Drawing.Size(132, 22);
            this.startDateTxt.TabIndex = 8;
            // 
            // endDateTxt
            // 
            this.endDateTxt.Location = new System.Drawing.Point(477, 121);
            this.endDateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.Size = new System.Drawing.Size(132, 22);
            this.endDateTxt.TabIndex = 9;
            // 
            // noAdultsTxt
            // 
            this.noAdultsTxt.Location = new System.Drawing.Point(477, 176);
            this.noAdultsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.noAdultsTxt.Name = "noAdultsTxt";
            this.noAdultsTxt.Size = new System.Drawing.Size(132, 22);
            this.noAdultsTxt.TabIndex = 10;
            // 
            // noChildrenTxt
            // 
            this.noChildrenTxt.Location = new System.Drawing.Point(477, 230);
            this.noChildrenTxt.Margin = new System.Windows.Forms.Padding(4);
            this.noChildrenTxt.Name = "noChildrenTxt";
            this.noChildrenTxt.Size = new System.Drawing.Size(132, 22);
            this.noChildrenTxt.TabIndex = 11;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(547, 511);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(813, 511);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(100, 28);
            this.nextBtn.TabIndex = 14;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click_1);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(951, 511);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.roomPriceLbl);
            this.panel1.Controls.Add(this.startDateTxt);
            this.panel1.Controls.Add(this.startDateLbl);
            this.panel1.Controls.Add(this.endDateLbl);
            this.panel1.Controls.Add(this.noAdultsLbl);
            this.panel1.Controls.Add(this.noChildrenLbl);
            this.panel1.Controls.Add(this.noChildrenTxt);
            this.panel1.Controls.Add(this.noAdultsTxt);
            this.panel1.Controls.Add(this.endDateTxt);
            this.panel1.Location = new System.Drawing.Point(159, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 352);
            this.panel1.TabIndex = 16;
            // 
            // roomPriceLbl
            // 
            this.roomPriceLbl.AutoSize = true;
            this.roomPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPriceLbl.Location = new System.Drawing.Point(4, 14);
            this.roomPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomPriceLbl.Name = "roomPriceLbl";
            this.roomPriceLbl.Size = new System.Drawing.Size(198, 25);
            this.roomPriceLbl.TabIndex = 13;
            this.roomPriceLbl.Text = "Reservation Details";
            this.roomPriceLbl.Click += new System.EventHandler(this.roomPriceLbl_Click);
            // 
            // findRooms
            // 
            this.findRooms.Location = new System.Drawing.Point(673, 511);
            this.findRooms.Margin = new System.Windows.Forms.Padding(4);
            this.findRooms.Name = "findRooms";
            this.findRooms.Size = new System.Drawing.Size(116, 28);
            this.findRooms.TabIndex = 17;
            this.findRooms.Text = "Find Rooms";
            this.findRooms.UseVisualStyleBackColor = true;
            this.findRooms.Click += new System.EventHandler(this.findRooms_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(903, 11);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 36);
            this.linkLabel2.TabIndex = 68;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Us";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(783, 11);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 36);
            this.linkLabel1.TabIndex = 67;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(875, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 36);
            this.label2.TabIndex = 66;
            this.label2.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 65;
            this.label1.Text = "Phumla Kamnandi Hotels";
            // 
            // ReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findRooms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.headerLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationDetails";
            this.Load += new System.EventHandler(this.ReservationDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label noAdultsLbl;
        private System.Windows.Forms.Label noChildrenLbl;
        private System.Windows.Forms.TextBox startDateTxt;
        private System.Windows.Forms.TextBox endDateTxt;
        private System.Windows.Forms.TextBox noAdultsTxt;
        private System.Windows.Forms.TextBox noChildrenTxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roomPriceLbl;
        private System.Windows.Forms.Button findRooms;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}