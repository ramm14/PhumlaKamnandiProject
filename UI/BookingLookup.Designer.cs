namespace PhumlaKamnandiProject.UI
{
    partial class BookingLookup
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
            this.bookingIdLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.changeBookingBtn = new System.Windows.Forms.Button();
            this.cancelBookingBtn = new System.Windows.Forms.Button();
            this.enquireBookingBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookingIdTxt = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingIdLbl
            // 
            this.bookingIdLbl.AutoSize = true;
            this.bookingIdLbl.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingIdLbl.Location = new System.Drawing.Point(238, 25);
            this.bookingIdLbl.Name = "bookingIdLbl";
            this.bookingIdLbl.Size = new System.Drawing.Size(169, 24);
            this.bookingIdLbl.TabIndex = 0;
            this.bookingIdLbl.Text = "Enter Booking ID";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(214, 127);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(255, 24);
            this.questionLbl.TabIndex = 1;
            this.questionLbl.Text = "What would you like to do?";
            // 
            // changeBookingBtn
            // 
            this.changeBookingBtn.Location = new System.Drawing.Point(55, 181);
            this.changeBookingBtn.Name = "changeBookingBtn";
            this.changeBookingBtn.Size = new System.Drawing.Size(119, 23);
            this.changeBookingBtn.TabIndex = 2;
            this.changeBookingBtn.Text = "Change Booking";
            this.changeBookingBtn.UseVisualStyleBackColor = true;
            this.changeBookingBtn.Click += new System.EventHandler(this.changeBookingBtn_Click);
            // 
            // cancelBookingBtn
            // 
            this.cancelBookingBtn.Location = new System.Drawing.Point(272, 181);
            this.cancelBookingBtn.Name = "cancelBookingBtn";
            this.cancelBookingBtn.Size = new System.Drawing.Size(119, 23);
            this.cancelBookingBtn.TabIndex = 3;
            this.cancelBookingBtn.Text = "Cancel Booking";
            this.cancelBookingBtn.UseVisualStyleBackColor = true;
            this.cancelBookingBtn.Click += new System.EventHandler(this.cancelBookingBtn_Click);
            // 
            // enquireBookingBtn
            // 
            this.enquireBookingBtn.Location = new System.Drawing.Point(477, 181);
            this.enquireBookingBtn.Name = "enquireBookingBtn";
            this.enquireBookingBtn.Size = new System.Drawing.Size(130, 23);
            this.enquireBookingBtn.TabIndex = 4;
            this.enquireBookingBtn.Text = "Enquire about Booking";
            this.enquireBookingBtn.UseVisualStyleBackColor = true;
            this.enquireBookingBtn.Click += new System.EventHandler(this.enquireBookingBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(586, 386);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(700, 386);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bookingIdTxt);
            this.panel1.Controls.Add(this.bookingIdLbl);
            this.panel1.Controls.Add(this.questionLbl);
            this.panel1.Controls.Add(this.changeBookingBtn);
            this.panel1.Controls.Add(this.enquireBookingBtn);
            this.panel1.Controls.Add(this.cancelBookingBtn);
            this.panel1.Location = new System.Drawing.Point(89, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 246);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bookingIdTxt
            // 
            this.bookingIdTxt.Location = new System.Drawing.Point(242, 75);
            this.bookingIdTxt.Name = "bookingIdTxt";
            this.bookingIdTxt.Size = new System.Drawing.Size(174, 20);
            this.bookingIdTxt.TabIndex = 5;
            this.bookingIdTxt.TextChanged += new System.EventHandler(this.bookingIdTxt_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(676, 8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(102, 28);
            this.linkLabel2.TabIndex = 72;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Us";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(586, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 28);
            this.linkLabel1.TabIndex = 71;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 28);
            this.label2.TabIndex = 70;
            this.label2.Text = "|";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 69;
            this.label1.Text = "Phumla Kamnandi Hotels";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BookingLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "BookingLookup";
            this.Text = "BookingLookup";
            this.Load += new System.EventHandler(this.BookingLookup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookingIdLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button changeBookingBtn;
        private System.Windows.Forms.Button cancelBookingBtn;
        private System.Windows.Forms.Button enquireBookingBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bookingIdTxt;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}