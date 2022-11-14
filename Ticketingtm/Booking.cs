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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuUtama().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket");
            string kode, seat, user, book;
            book = txt_book.Text;
            kode = txt_kode.Text;
            seat = txt_nonton.Text;
            user = txt_user.Text;
            string que = "INSERT INTO tbl_booking VALUES('" + kode + "', '" + book + "', '" + seat + "', '"+user+"')";
            MySqlDataAdapter sda = new MySqlDataAdapter(que, connect);

            DataTable dtab = new DataTable();
            sda.Fill(dtab);
            MessageBox.Show("Asik Berhasil Daftar");
        }
    }
}
