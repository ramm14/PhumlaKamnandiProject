using System;
using System.Windows.Forms;

namespace PhumlaKamnandiProject.UI
{
    partial class ExistingGuestDetails
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBttn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guestAddressLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.postalTxt = new System.Windows.Forms.TextBox();
            this.suburbTxt = new System.Windows.Forms.TextBox();
            this.streetTxt = new System.Windows.Forms.TextBox();
            this.countryLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.postalLbl = new System.Windows.Forms.Label();
            this.suburbLbl = new System.Windows.Forms.Label();
            this.streetLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.guestInfoLbl = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.docLbl = new System.Windows.Forms.Label();
            this.identityDocTxt = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(948, 506);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 56;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBttn
            // 
            this.updateBttn.Location = new System.Drawing.Point(732, 506);
            this.updateBttn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBttn.Name = "updateBttn";
            this.updateBttn.Size = new System.Drawing.Size(100, 28);
            this.updateBttn.TabIndex = 55;
            this.updateBttn.Text = "Update";
            this.updateBttn.UseVisualStyleBackColor = true;
            this.updateBttn.Click += new System.EventHandler(this.updateBttn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(627, 506);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 54;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(840, 506);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 28);
            this.next.TabIndex = 60;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(901, 10);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 36);
            this.linkLabel2.TabIndex = 64;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Us";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(781, 10);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 36);
            this.linkLabel1.TabIndex = 63;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(873, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 36);
            this.label2.TabIndex = 62;
            this.label2.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 61;
            this.label1.Text = "Phumla Kamnandi Hotels";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.identityDocTxt);
            this.panel1.Controls.Add(this.docLbl);
            this.panel1.Controls.Add(this.guestAddressLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.countryTxt);
            this.panel1.Controls.Add(this.cityTxt);
            this.panel1.Controls.Add(this.postalTxt);
            this.panel1.Controls.Add(this.suburbTxt);
            this.panel1.Controls.Add(this.streetTxt);
            this.panel1.Controls.Add(this.countryLbl);
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.postalLbl);
            this.panel1.Controls.Add(this.suburbLbl);
            this.panel1.Controls.Add(this.streetLbl);
            this.panel1.Controls.Add(this.idTxt);
            this.panel1.Controls.Add(this.phoneTxt);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.surnameTxt);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.phoneLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.surnameLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.guestInfoLbl);
            this.panel1.Location = new System.Drawing.Point(48, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 422);
            this.panel1.TabIndex = 65;
            // 
            // guestAddressLbl
            // 
            this.guestAddressLbl.AutoSize = true;
            this.guestAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestAddressLbl.Location = new System.Drawing.Point(660, 60);
            this.guestAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestAddressLbl.Name = "guestAddressLbl";
            this.guestAddressLbl.Size = new System.Drawing.Size(231, 24);
            this.guestAddressLbl.TabIndex = 113;
            this.guestAddressLbl.Text = "Guest Address Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 112;
            this.label3.Text = "Guest Information";
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(812, 239);
            this.countryTxt.Margin = new System.Windows.Forms.Padding(4);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(132, 22);
            this.countryTxt.TabIndex = 110;
            this.countryTxt.TextChanged += new System.EventHandler(this.countryTxt_TextChanged);
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(812, 207);
            this.cityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(132, 22);
            this.cityTxt.TabIndex = 109;
            // 
            // postalTxt
            // 
            this.postalTxt.Location = new System.Drawing.Point(812, 175);
            this.postalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.postalTxt.Name = "postalTxt";
            this.postalTxt.Size = new System.Drawing.Size(132, 22);
            this.postalTxt.TabIndex = 108;
            // 
            // suburbTxt
            // 
            this.suburbTxt.Location = new System.Drawing.Point(812, 143);
            this.suburbTxt.Margin = new System.Windows.Forms.Padding(4);
            this.suburbTxt.Name = "suburbTxt";
            this.suburbTxt.Size = new System.Drawing.Size(132, 22);
            this.suburbTxt.TabIndex = 107;
            // 
            // streetTxt
            // 
            this.streetTxt.Location = new System.Drawing.Point(812, 111);
            this.streetTxt.Margin = new System.Windows.Forms.Padding(4);
            this.streetTxt.Name = "streetTxt";
            this.streetTxt.Size = new System.Drawing.Size(132, 22);
            this.streetTxt.TabIndex = 106;
            // 
            // countryLbl
            // 
            this.countryLbl.AutoSize = true;
            this.countryLbl.Location = new System.Drawing.Point(621, 247);
            this.countryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(52, 16);
            this.countryLbl.TabIndex = 105;
            this.countryLbl.Text = "Country";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(621, 215);
            this.cityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(29, 16);
            this.cityLbl.TabIndex = 104;
            this.cityLbl.Text = "City";
            // 
            // postalLbl
            // 
            this.postalLbl.AutoSize = true;
            this.postalLbl.Location = new System.Drawing.Point(621, 183);
            this.postalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postalLbl.Name = "postalLbl";
            this.postalLbl.Size = new System.Drawing.Size(81, 16);
            this.postalLbl.TabIndex = 103;
            this.postalLbl.Text = "Postal Code";
            // 
            // suburbLbl
            // 
            this.suburbLbl.AutoSize = true;
            this.suburbLbl.Location = new System.Drawing.Point(621, 151);
            this.suburbLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suburbLbl.Name = "suburbLbl";
            this.suburbLbl.Size = new System.Drawing.Size(50, 16);
            this.suburbLbl.TabIndex = 102;
            this.suburbLbl.Text = "Suburb";
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Location = new System.Drawing.Point(619, 114);
            this.streetLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(42, 16);
            this.streetLbl.TabIndex = 101;
            this.streetLbl.Text = "Street";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(243, 275);
            this.idTxt.Margin = new System.Windows.Forms.Padding(4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(132, 22);
            this.idTxt.TabIndex = 98;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(243, 202);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(132, 22);
            this.phoneTxt.TabIndex = 97;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(243, 170);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(132, 22);
            this.emailTxt.TabIndex = 96;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(243, 138);
            this.surnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(132, 22);
            this.surnameTxt.TabIndex = 95;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(243, 106);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(132, 22);
            this.nameTxt.TabIndex = 94;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(39, 283);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(129, 16);
            this.idLbl.TabIndex = 91;
            this.idLbl.Text = "ID/Passport Number";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(39, 210);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(97, 16);
            this.phoneLbl.TabIndex = 90;
            this.phoneLbl.Text = "Phone Number";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(39, 178);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(95, 16);
            this.emailLbl.TabIndex = 89;
            this.emailLbl.Text = "Email Address";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(39, 146);
            this.surnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(61, 16);
            this.surnameLbl.TabIndex = 88;
            this.surnameLbl.Text = "Surname";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(39, 114);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(44, 16);
            this.nameLbl.TabIndex = 87;
            this.nameLbl.Text = "Name";
            // 
            // guestInfoLbl
            // 
            this.guestInfoLbl.AutoSize = true;
            this.guestInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestInfoLbl.Location = new System.Drawing.Point(379, 11);
            this.guestInfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestInfoLbl.Name = "guestInfoLbl";
            this.guestInfoLbl.Size = new System.Drawing.Size(223, 25);
            this.guestInfoLbl.TabIndex = 86;
            this.guestInfoLbl.Text = "Existing Guest Details";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.statusLabel.Location = new System.Drawing.Point(820, 489);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 66;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Visible = false;
            // 
            // docLbl
            // 
            this.docLbl.AutoSize = true;
            this.docLbl.Location = new System.Drawing.Point(39, 247);
            this.docLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.docLbl.Name = "docLbl";
            this.docLbl.Size = new System.Drawing.Size(113, 16);
            this.docLbl.TabIndex = 114;
            this.docLbl.Text = "Identity Document";
            // 
            // identityDocTxt
            // 
            this.identityDocTxt.FormattingEnabled = true;
            this.identityDocTxt.Items.AddRange(new object[] {
            "Passport",
            "NationalID"});
            this.identityDocTxt.Location = new System.Drawing.Point(243, 239);
            this.identityDocTxt.Name = "identityDocTxt";
            this.identityDocTxt.Size = new System.Drawing.Size(132, 24);
            this.identityDocTxt.TabIndex = 116;
            // 
            // ExistingGuestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 558);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBttn);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExistingGuestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExistingGuestDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBttn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guestInfoLbl;
        private System.Windows.Forms.Label guestAddressLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countryTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox postalTxt;
        private System.Windows.Forms.TextBox suburbTxt;
        private System.Windows.Forms.TextBox streetTxt;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label postalLbl;
        private System.Windows.Forms.Label suburbLbl;
        private System.Windows.Forms.Label streetLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label statusLabel;
        private ComboBox identityDocTxt;
        private Label docLbl;
    }
}