using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Taw_Kabui_Management_System
{
    internal class connect
    {
        public MySqlConnection con;

        public void connection()
        {
            con = new MySqlConnection("datasource = localhost; database=tawkabuisystemdb;port=;username = root; password = JKPadul11");
            con.Open();
        }
    }
}
