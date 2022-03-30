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
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            Form studentform = new ScreeningForm();
            studentform.Show();
            this.Hide();
        }

        private void btnEmploymentForm_Click(object sender, EventArgs e)
        {
            Form employmentform = new StaffForm();
            employmentform.Show();
            this.Hide();
        }

        private void btnClassesForm_Click(object sender, EventArgs e)
        {
            Form classesform = new ClassesForm();
            classesform.Show();
            this.Hide();
        }

        private void btnFeesForm_Click(object sender, EventArgs e)
        {
            Form feesform = new FeesForm();
            feesform.Show();
            this.Hide();
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            Form reportform = new ReportForm();
            reportform.Show();
            this.Hide();
        }

        private void bntAccountForm_Click(object sender, EventArgs e)
        {
            Form accountform = new AccountForms();
            accountform.Show();
            this.Hide();
        }
    }
}
