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
    public partial class Lihatfilm : Form
    {
        conn konn = new conn();
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;


        public Lihatfilm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Help().Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new MenuUtama().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Lihatfilm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Booking().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connect = new MySqlConnection("server=localhost;userid=root;password=;database=db_ticket"))
            {
                connect.Open();
                //Select untuk menampilkan data ke datagrid dengan melakukan join antar tabel karena membutuhkan satu kolom yang penting
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT tf.kode_film, tf.judul_film, tf.durasi, ty.waktu_tayang" +
                    " FROM tbl_film tf INNER JOIN tbl_tayang ty ON tf.kode_film = ty.kode_film ", connect);
                DataTable dtab = new DataTable();
                sda.Fill(dtab);

                //Direct
                dataGridView.DataSource = dtab;
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
