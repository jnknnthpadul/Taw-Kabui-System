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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
        private void btnScreeningForm_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCscreening.Instance))
            {
                panelContainer.Controls.Add(UCscreening.Instance);
                UCscreening.Instance.Dock = DockStyle.Fill;
                UCscreening.Instance.BringToFront();
            }
            else
                UCscreening.Instance.BringToFront();
        }
        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCenroll.Instance))
            {
                panelContainer.Controls.Add(UCenroll.Instance);
                UCenroll.Instance.Dock = DockStyle.Fill;
                UCenroll.Instance.BringToFront();
            }
            else
                UCenroll.Instance.BringToFront();
        }
        private void btnFeesForm_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCfees.Instance))
            {
                panelContainer.Controls.Add(UCfees.Instance);
                UCfees.Instance.Dock = DockStyle.Fill;
                UCfees.Instance.BringToFront();
            }
            else
                UCfees.Instance.BringToFront();
        }

        private void bntAccountForm_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCaccount.Instance))
            {
                panelContainer.Controls.Add(UCaccount.Instance);
                UCaccount.Instance.Dock = DockStyle.Fill;
                UCaccount.Instance.BringToFront();
            }
            else
                UCaccount.Instance.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCstaff.Instance))
            {
                panelContainer.Controls.Add(UCstaff.Instance);
                UCstaff.Instance.Dock = DockStyle.Fill;
                UCstaff.Instance.BringToFront();
            }
            else
                UCstaff.Instance.BringToFront();
        }

        private void btnClassesForm_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCclasses.Instance))
            {
                panelContainer.Controls.Add(UCclasses.Instance);
                UCclasses.Instance.Dock = DockStyle.Fill;
                UCclasses.Instance.BringToFront();
            }
            else
                UCclasses.Instance.BringToFront();
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UCreport.Instance))
            {
                panelContainer.Controls.Add(UCreport.Instance);
                UCreport.Instance.Dock = DockStyle.Fill;
                UCreport.Instance.BringToFront();
            }
            else
                UCreport.Instance.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblStudentCount.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from StaffTB", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblStaffCount.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            lblClassesCount.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            lblPaidCount.Text = dt4.Rows[0][0].ToString();
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            lblADHDCount.Text = dt5.Rows[0][0].ToString();
            SqlDataAdapter sda6 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            lblAutismCount.Text = dt6.Rows[0][0].ToString();
            SqlDataAdapter sda7 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            lblDownSCount.Text = dt7.Rows[0][0].ToString();
            SqlDataAdapter sda8 = new SqlDataAdapter("select count(*) from StudentTB", con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            lblNotPaidCount.Text = dt8.Rows[0][0].ToString();
            con.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You're about to be signed out ,Are you sure?", "Sign Out Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
            }
        }
    }
}
