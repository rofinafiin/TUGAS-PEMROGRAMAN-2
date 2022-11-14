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
    public partial class Bookinganku : Form
    {
        public Bookinganku()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenuUtama().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket"))
            {
                //menampilkan data ke tabel
                connect.Open();
                string query = "SELECT * FROM tbl_booking WHERE username = '"+txt_user.Text+"'" ;
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connect);
                DataTable dtab = new DataTable();
                sda.Fill(dtab);

                //Direct
                dataGridView.DataSource = dtab;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            //Fungsi delete data berdasarkan kolom kode film
            MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket");
                connect.Open();
                string que = "DELETE FROM tbl_booking WHERE kode_film ='" + txt_seat.Text + "'";
                MySqlCommand cmd = new MySqlCommand(que, connect);
            cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //fungsi edit/update data
            MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket");
            connect.Open();
            string kode, seat, waktu;
            kode = txt_code.Text;
            seat = txt_seat_2.Text;
            waktu = txt_waktu_tayang.Text;
            string que = "UPDATE `tbl_booking` SET `waktu_tayang` = '"+waktu+"', seat_book = '"+seat+"' WHERE `tbl_booking`.`kode_film` = '"+kode+"';" ;
            MySqlDataAdapter sda = new MySqlDataAdapter(que, connect);
            DataTable dtab = new DataTable();
            sda.Fill(dtab);
            MessageBox.Show("Asik Berhasil Update");
        }
    }
}
