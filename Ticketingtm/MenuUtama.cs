using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Ticketingtm
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Booking().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Lihatfilm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bookinganku().Show();
            this.Hide();
        }
    }
}
