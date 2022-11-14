using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ticketingtm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket");
        conn konek = new conn();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass,usercuy, passcuy;
            user = txt_username.Text;
            pass = txt_password.Text;
            try
            {
                string que = "SELECT * FROM tbl_user WHERE Username = '" + user + "'AND Password = '" + pass + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(que, connect);

                DataTable dtab = new DataTable();
                sda.Fill(dtab);

                if(dtab.Rows.Count > 0)
                {
                    usercuy = txt_username.Text;
                    passcuy = txt_password.Text;

                    new MenuUtama().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connect.Close();
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
