using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data.SqlClient;

namespace Taw_Kabui_Management_System
{
    public partial class UCreport : UserControl
    {
        private static UCreport _instance;
        public static UCreport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCreport();
                return _instance;
            }
        }
        public UCreport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Taw Kabui Report";
            printer.SubTitle = string.Format("Date:{0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Taw Kabui";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dgvReport);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                con.Open();
                string query = "select * from StudentTB";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                con.Close();
            }
            if (rbStaff.Checked)
            {
                con.Open();
                string query = "select * from StaffTB";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                con.Close();
            }
            if (rbClass.Checked)
            {
                con.Open();
                string query = "select * from ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                con.Close();
            }
            if (rbFees.Checked)
            {
                con.Open();
                string query = "select * from FeesTB";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                con.Close();
            }
        }
    }
}
