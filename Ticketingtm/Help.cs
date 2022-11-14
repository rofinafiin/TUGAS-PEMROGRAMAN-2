using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ticketingtm
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bookinganku().Show();
            this.Hide();
        }
    }
}
