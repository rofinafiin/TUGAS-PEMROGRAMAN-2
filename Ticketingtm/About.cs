using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ticketingtm
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new MenuUtama().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bookinganku().Show();
            this.Hide();
        }
    }
}
