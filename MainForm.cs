using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taw_Kabui_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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


    }
}
