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
    public partial class UCstaff : UserControl
    {
        private static UCstaff _instance;
        public static UCstaff Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCstaff();
                return _instance;
            }
        }
        public UCstaff()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Desktop\Taw Kabui Management System\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        string status;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbRegular.Checked == true)
            {
                status = "Regular";
            }
            if (rbContractual.Checked == true)
            {
                status = "Contractual";
            }
            if (rbVolunteer.Checked == true)
            {
                status = "Volunteer";
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into StaffTB(FirstName,MiddleName,LastName,PermanentAddress,PresentAddress,BirthDate,Age,Salary,Sex,ContactNumber,Status,Role,Department,Position,TIN,SSS,DateHired,ContractEnd) values(@FirstName,@MiddleName,@LastName,@PermanentAddress,@PresentAddress,@BirthDate,@Age,@Salary,@Sex,@ContactNumber,@Status,@Role,@Department,@Position,@TIN,@SSS,@DateHired,@ContractEnd)", con);
                cmd.Parameters.AddWithValue("@FirstName", tbFrstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", tbMidName.Text);
                cmd.Parameters.AddWithValue("@LastName", tbLstName.Text);
                cmd.Parameters.AddWithValue("@PermanentAddress", tbPerAddress.Text);
                cmd.Parameters.AddWithValue("@PresentAddress", tbPreAddress.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dtpBOD.Value);
                cmd.Parameters.AddWithValue("@Age", tbAge.Text);
                cmd.Parameters.AddWithValue("@Salary", tbSalary.Text);
                cmd.Parameters.AddWithValue("@Sex", cbSex.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ContactNumber", tbContact.Text);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Role", cbRole.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Department", cbDepartment.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Position", cbPosition.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TIN", tbTIN.Text);
                cmd.Parameters.AddWithValue("@SSS", tbSSS.Text);
                cmd.Parameters.AddWithValue("@DateHired", dtpHired.Value);
                cmd.Parameters.AddWithValue("@ContractEnd", dtpContract.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Staff Save");
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
            string query = "select * from StaffTB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStaff.DataSource = dt;
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFrstName.Text = " ";
            tbMidName.Text = " ";
            tbLstName.Text = " ";
            tbPerAddress.Text = " ";
            tbPreAddress.Text = " ";
            tbAge.Text = " ";
            tbSalary.Text = " ";
            cbSex.Text = " ";
            tbContact.Text = " ";
            rbContractual.Checked = false;
            rbRegular.Checked = false;
            rbVolunteer.Checked = false;
            cbRole.Text = " ";
            cbDepartment.Text = " ";
            cbPosition.Text = " ";
            tbTIN.Text = " ";
            tbSSS.Text = " ";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from StaffTB where FirstName like '" + tbSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvStaff.DataSource = dt;
            con.Close();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbFrstName.Text = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbMidName.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbLstName.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPerAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbPreAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            //tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbAge.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbSalary.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbSex.Text = dgvStaff.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbContact.Text = dgvStaff.Rows[e.RowIndex].Cells[9].Value.ToString();
            //tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbRole.Text = dgvStaff.Rows[e.RowIndex].Cells[11].Value.ToString();
            cbDepartment.Text = dgvStaff.Rows[e.RowIndex].Cells[12].Value.ToString();
            cbPosition.Text = dgvStaff.Rows[e.RowIndex].Cells[13].Value.ToString();
            tbTIN.Text = dgvStaff.Rows[e.RowIndex].Cells[14].Value.ToString();
            tbSSS.Text = dgvStaff.Rows[e.RowIndex].Cells[15].Value.ToString();
            //tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update StaffTB set FirstName ='" + tbFrstName.Text +"', MiddleName = '"+tbMidName.Text+ "', LastName = '" + tbLstName.Text + "', PermanentAddress = '" + tbPerAddress.Text + "', PresentAddress = '" + tbPreAddress.Text + "', BirthDate = '" + dtpBOD.Value.ToString("yyyy-MM-dd") + "', Age = '" + tbAge.Text + "', Salary = '" + tbSalary.Text + "', Sex = '" + cbSex.SelectedItem.ToString() + "', ContactNumber = '" + tbContact.Text + "', Role = '" + cbRole.SelectedItem.ToString() + "', Department = '" + cbDepartment.SelectedItem.ToString() + "', Position = '" + cbPosition.SelectedItem.ToString() + "', TIN = '" + tbTIN.Text + "', SSS = '" + tbSSS.Text + "', DateHired = '" + dtpHired.Value.ToString("yyyy-MM-dd") + "', ContractEnd = '" + dtpContract.Value.ToString("yyyy-MM-dd") + "' where FirstName='" + tbFrstName.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Updated");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from StaffTB where FirstName='" + tbFrstName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Deleted");

                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
