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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form recoverform = new RecoverForm();
            recoverform.Show();        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '•')
            {
                btnNoVis.BringToFront();
                tbPass.PasswordChar = '\0';
            }
        }

        private void btnNoVis_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '\0')
            {
                btnVis.BringToFront();
                tbPass.PasswordChar = '•';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
