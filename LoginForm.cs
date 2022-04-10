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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "admin" && tbPass.Text == "admin")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else if (tbUser.Text == "")
            {
                MessageBox.Show("Enter the username");
            }
            else if(tbPass.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select UserName, Password from AccountTB WHERE UserName = @UserName AND Password = @Password", con);
                    cmd.Parameters.AddWithValue("@UserName", tbUser.Text);
                    cmd.Parameters.AddWithValue("@Password", hash.hashPassword(tbPass.Text));
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Succesfully Login");
                        this.Hide();
                        MainForm main = new MainForm();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username & Password is invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form recoverform = new RecoverForm();
            recoverform.Show();        
        }

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
