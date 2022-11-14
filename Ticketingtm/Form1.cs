using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ticketingtm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket");
        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass, nama, user;
            nama = txt_nama.Text;
            user = txt_username.Text;
            pass = txt_password.Text;
            string que = "INSERT INTO tbl_user VALUES(NULL, '"+user+"', '"+pass+"', '"+nama+"')";
            MySqlDataAdapter sda = new MySqlDataAdapter(que, connect);

            DataTable dtab = new DataTable();
            sda.Fill(dtab);
            MessageBox.Show("Asik Berhasil Daftar");
        }
    }
}
