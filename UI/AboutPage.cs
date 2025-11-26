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
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            backBtn.Parent = pictureBox1;
            backBtn.BackColor = Color.Transparent;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Homepage prevForm = new Homepage();
            prevForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
