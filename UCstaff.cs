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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                string query = "insert into StaffTB values('" + tbFrstName.Text + "','" + tbMidName.Text + "','" + tbLstName.Text + "','" + tbPerAddress.Text + "','" + tbPreAddress.Text + "','" + dtpBOD.Value.Date + "','" + tbAge.Text + "','" + tbSalary.Text + "','" + cbSex.SelectedItem.ToString() + "','" + tbContact.Text + "','" + status + "','" + cbRole.SelectedItem.ToString() + "','" + cbDepartment.SelectedItem.ToString() + "','" + cbPosition.SelectedItem.ToString() + "','" + tbTIN.Text + "','" + tbSSS.Text + "','" + dtpHired.Value.Date + "','" + dtpContract.Value.Date + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Registered");
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
            tbPerAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbPreAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
            //tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbAge.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbSalary.Text = dgvStaff.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbSex.Text = dgvStaff.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbContact.Text = dgvStaff.Rows[e.RowIndex].Cells[10].Value.ToString();
            //tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbRole.Text = dgvStaff.Rows[e.RowIndex].Cells[12].Value.ToString();
            cbDepartment.Text = dgvStaff.Rows[e.RowIndex].Cells[13].Value.ToString();
            cbPosition.Text = dgvStaff.Rows[e.RowIndex].Cells[14].Value.ToString();
            tbTIN.Text = dgvStaff.Rows[e.RowIndex].Cells[15].Value.ToString();
            tbSSS.Text = dgvStaff.Rows[e.RowIndex].Cells[16].Value.ToString();
            //tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
