using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace Ticketingtm
{
    class conn
    {
        //private MySqlConnection Conn = new MySqlConnection("server=localhost;user id=root;database=gudang;sslMode=none");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        //public DataTable dt;
        int result;
        private string url = "server=localhost;userid=root;password=;database=db_ticket";
        public MySqlConnection GetConn()
        {
            MySqlConnection konek = new MySqlConnection(url);
            return konek;
        }
    }
}
