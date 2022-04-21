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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Desktop\Taw Kabui Management System\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                SqlCommand cmd = new SqlCommand("INSERT into StudentTB(ChildNumber,ChildName,Impairment,Class,Address,BirthDate,Age,Contact,Gender,ParentName,ParentAddress,ParentContact,Type,GradeLevel) values(@ChildNumber,@ChildName,@Impairment,@Class,@Address,@BirthDate,@Age,@Contact,@Gender,@ParentName,@ParentAddress,@ParentContact,@Type,@GradeLevel)", con);
                cmd.Parameters.AddWithValue("@ChildNumber", tbChildNum.Text);
                cmd.Parameters.AddWithValue("@ChildName", tbChildName.Text);
                cmd.Parameters.AddWithValue("@Impairment", cbImpairment.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Class", cbClass.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@Age", tbAge.Text);
                cmd.Parameters.AddWithValue("@Contact", tbContact.Text);
                cmd.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ParentName", tbParentName.Text);
                cmd.Parameters.AddWithValue("@ParentAddress", tbPaddress.Text);
                cmd.Parameters.AddWithValue("@ParentContact", tbPcontact.Text);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@GradeLevel", cbGrade.SelectedItem.ToString());
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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from StudentTB where ChildName like '" + tbSearch.Text + "%'", con);
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
