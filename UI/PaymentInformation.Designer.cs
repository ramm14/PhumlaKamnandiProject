namespace PhumlaKamnandiProject.UI
{
    partial class PaymentInformation
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
            this.card1Lbl = new System.Windows.Forms.Label();
            this.exp1Lbl = new System.Windows.Forms.Label();
            this.cvv1Lbl = new System.Windows.Forms.Label();
            this.card1Txt = new System.Windows.Forms.TextBox();
            this.exp1Txt = new System.Windows.Forms.TextBox();
            this.cvv1Txt = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.roomPriceLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moneytxt = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // card1Lbl
            // 
            this.card1Lbl.AutoSize = true;
            this.card1Lbl.Location = new System.Drawing.Point(50, 151);
            this.card1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card1Lbl.Name = "card1Lbl";
            this.card1Lbl.Size = new System.Drawing.Size(87, 16);
            this.card1Lbl.TabIndex = 0;
            this.card1Lbl.Text = "Card Number";
            this.card1Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // exp1Lbl
            // 
            this.exp1Lbl.AutoSize = true;
            this.exp1Lbl.Location = new System.Drawing.Point(50, 190);
            this.exp1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exp1Lbl.Name = "exp1Lbl";
            this.exp1Lbl.Size = new System.Drawing.Size(161, 16);
            this.exp1Lbl.TabIndex = 1;
            this.exp1Lbl.Text = "Expiry Date (dd/mm/yyyy)";
            // 
            // cvv1Lbl
            // 
            this.cvv1Lbl.AutoSize = true;
            this.cvv1Lbl.Location = new System.Drawing.Point(50, 224);
            this.cvv1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cvv1Lbl.Name = "cvv1Lbl";
            this.cvv1Lbl.Size = new System.Drawing.Size(34, 16);
            this.cvv1Lbl.TabIndex = 2;
            this.cvv1Lbl.Text = "CVV";
            // 
            // card1Txt
            // 
            this.card1Txt.Location = new System.Drawing.Point(354, 147);
            this.card1Txt.Margin = new System.Windows.Forms.Padding(4);
            this.card1Txt.Name = "card1Txt";
            this.card1Txt.Size = new System.Drawing.Size(132, 22);
            this.card1Txt.TabIndex = 7;
            // 
            // exp1Txt
            // 
            this.exp1Txt.Location = new System.Drawing.Point(354, 187);
            this.exp1Txt.Margin = new System.Windows.Forms.Padding(4);
            this.exp1Txt.Name = "exp1Txt";
            this.exp1Txt.Size = new System.Drawing.Size(132, 22);
            this.exp1Txt.TabIndex = 8;
            this.exp1Txt.TextChanged += new System.EventHandler(this.exp1Txt_TextChanged);
            // 
            // cvv1Txt
            // 
            this.cvv1Txt.Location = new System.Drawing.Point(354, 224);
            this.cvv1Txt.Margin = new System.Windows.Forms.Padding(4);
            this.cvv1Txt.Name = "cvv1Txt";
            this.cvv1Txt.Size = new System.Drawing.Size(132, 22);
            this.cvv1Txt.TabIndex = 9;
            this.cvv1Txt.TextChanged += new System.EventHandler(this.cvv1Txt_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(695, 511);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(825, 511);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(100, 28);
            this.nextBtn.TabIndex = 15;
            this.nextBtn.Text = "Pay";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(947, 511);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(33, 32);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(360, 28);
            this.headerLbl.TabIndex = 18;
            this.headerLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // roomPriceLbl
            // 
            this.roomPriceLbl.AutoSize = true;
            this.roomPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPriceLbl.Location = new System.Drawing.Point(26, 84);
            this.roomPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomPriceLbl.Name = "roomPriceLbl";
            this.roomPriceLbl.Size = new System.Drawing.Size(288, 25);
            this.roomPriceLbl.TabIndex = 22;
            this.roomPriceLbl.Text = "Deposit Payment Information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.moneytxt);
            this.panel1.Controls.Add(this.totalLbl);
            this.panel1.Controls.Add(this.roomPriceLbl);
            this.panel1.Controls.Add(this.cvv1Txt);
            this.panel1.Controls.Add(this.exp1Txt);
            this.panel1.Controls.Add(this.card1Txt);
            this.panel1.Controls.Add(this.cvv1Lbl);
            this.panel1.Controls.Add(this.exp1Lbl);
            this.panel1.Controls.Add(this.card1Lbl);
            this.panel1.Location = new System.Drawing.Point(275, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 413);
            this.panel1.TabIndex = 23;
            // 
            // moneytxt
            // 
            this.moneytxt.AutoSize = true;
            this.moneytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytxt.Location = new System.Drawing.Point(280, 325);
            this.moneytxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneytxt.Name = "moneytxt";
            this.moneytxt.Size = new System.Drawing.Size(18, 20);
            this.moneytxt.TabIndex = 24;
            this.moneytxt.Text = "x";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(179, 325);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(69, 20);
            this.totalLbl.TabIndex = 23;
            this.totalLbl.Text = "Total : ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(912, 11);
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
            this.linkLabel1.Location = new System.Drawing.Point(792, 11);
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
            this.label2.Location = new System.Drawing.Point(884, 12);
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
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 65;
            this.label1.Text = "Phumla Kamnandi Hotels";
            // 
            // PaymentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 558);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Information";
            this.Load += new System.EventHandler(this.PaymentVerified_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label card1Lbl;
        private System.Windows.Forms.Label exp1Lbl;
        private System.Windows.Forms.Label cvv1Lbl;
        private System.Windows.Forms.TextBox card1Txt;
        private System.Windows.Forms.TextBox exp1Txt;
        private System.Windows.Forms.TextBox cvv1Txt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label roomPriceLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label moneytxt;
    }
}