using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taw_Kabui_Management_System
{
    public partial class UCclasses : UserControl
    {
        private static UCclasses _instance;
        public static UCclasses Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCclasses();
                return _instance;
            }
        }
        public UCclasses()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Desktop\Taw Kabui Management System\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnNewClass_Click_1(object sender, EventArgs e)
        {
            Form newclass = new ClassNew();
            newclass.Show();
        }
    }
}
