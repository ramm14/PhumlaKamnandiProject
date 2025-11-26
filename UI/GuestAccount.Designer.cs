namespace PhumlaKamnandiProject.UI
{
    partial class GuestAccount
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
            this.guestTypeLbl = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.existingBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.guestTypePanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guestTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(23, 21);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(0, 25);
            this.headerLbl.TabIndex = 0;
            // 
            // guestTypeLbl
            // 
            this.guestTypeLbl.AutoSize = true;
            this.guestTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestTypeLbl.Location = new System.Drawing.Point(134, 60);
            this.guestTypeLbl.Name = "guestTypeLbl";
            this.guestTypeLbl.Size = new System.Drawing.Size(242, 20);
            this.guestTypeLbl.TabIndex = 3;
            this.guestTypeLbl.Text = "Are they a new or existing guest?";
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(149, 136);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 4;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // existingBtn
            // 
            this.existingBtn.Location = new System.Drawing.Point(288, 136);
            this.existingBtn.Name = "existingBtn";
            this.existingBtn.Size = new System.Drawing.Size(75, 23);
            this.existingBtn.TabIndex = 5;
            this.existingBtn.Text = "Existing";
            this.existingBtn.UseVisualStyleBackColor = true;
            this.existingBtn.Click += new System.EventHandler(this.existingBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(592, 398);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(694, 398);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // guestTypePanel
            // 
            this.guestTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestTypePanel.Controls.Add(this.guestTypeLbl);
            this.guestTypePanel.Controls.Add(this.newBtn);
            this.guestTypePanel.Controls.Add(this.existingBtn);
            this.guestTypePanel.Location = new System.Drawing.Point(161, 107);
            this.guestTypePanel.Name = "guestTypePanel";
            this.guestTypePanel.Size = new System.Drawing.Size(506, 221);
            this.guestTypePanel.TabIndex = 8;
            this.guestTypePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(676, 8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(102, 28);
            this.linkLabel2.TabIndex = 68;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Us";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(586, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 28);
            this.linkLabel1.TabIndex = 67;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 28);
            this.label2.TabIndex = 66;
            this.label2.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 65;
            this.label1.Text = "Phumla Kamnandi Hotels";
            // 
            // GuestAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestTypePanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.headerLbl);
            this.Name = "GuestAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestAccount";
            this.Load += new System.EventHandler(this.GuestAccount_Load);
            this.guestTypePanel.ResumeLayout(false);
            this.guestTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label guestTypeLbl;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button existingBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel guestTypePanel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}