using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Taw_Kabui_Management_System
{
    public partial class LoginForm : Form
    {
        connect con = new connect();
        MySqlCommand cmd;
        MySqlDataReader reader;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.connection();
            cmd = new MySqlCommand("select * from logindb where username = '"+ tbUser.Text +"' AND password = '"+ tbPass.Text +"'", con.con);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Successfully Login"," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form mform = new MainForm();
                this.Hide();
                mform.Show();
            }
            else
            {
                MessageBox.Show("Username and Password Not Match", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUser.Clear();
                tbPass.Clear();
                return;
            }
            con.con.Close();
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
