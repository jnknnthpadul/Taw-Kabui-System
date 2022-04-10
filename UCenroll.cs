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
    public partial class UCenroll : UserControl
    {
        private static UCenroll _instance;
        public static UCenroll Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCenroll();
                return _instance;
            }
        }
        public UCenroll()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        string type;

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (rbNewStudent.Checked == true)
            {
                type = "New Student";
            }
            else
            {
                type = "Old Student";
            }

            try
            {
                con.Open();
                string query = "insert into StudentTB values('" + tbChildNum.Text + "','" + tbChildName.Text + "','" + cbImpairment.SelectedItem.ToString() + "','" + cbClass.SelectedItem.ToString()+ "','" + tbAddress.Text + "','" + dtpBirthday.Value.Date + "','" + tbAge.Text + "','" + tbContact.Text + "','" + cbGender.SelectedItem.ToString() + "','" + tbParentName.Text + "','" +tbPaddress.Text + "','" + tbPcontact.Text + "','" + type + "','" + cbGrade.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Added");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate() 
        {
            con.Open();
            string query = "select * from StudentTB";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStudent.DataSource = dt;
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbChildNum.Text = "";
            tbChildName.Text = "";
            tbAddress.Text = "";
            tbAge.Text = "";
            tbContact.Text = "";
            tbParentName.Text = "";
            tbPaddress.Text = "";
            tbPcontact.Text = "";
            rbNewStudent.Checked = false;
            rbOldStudent.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from AccountTB where ChildName like '" + tbSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvStudent.DataSource = dt;
            con.Close();
        }

        private void dgvStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
