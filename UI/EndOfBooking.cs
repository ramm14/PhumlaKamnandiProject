using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiProject.UI
{
    public partial class EndOfBooking : Form
    {
        public EndOfBooking()
        {
            InitializeComponent();
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void EndOfBooking_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

        }

        private void label2_Click(object sender, EventArgs e)
        {

            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;


        }

        private void bookNowButton_Click(object sender, EventArgs e)
        {
            Homepage detailsForm = new Homepage();
            detailsForm.Show();  
            this.Hide();
        }
    }
}
