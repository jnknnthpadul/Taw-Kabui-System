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
    public partial class UCaccount : UserControl
    {
        private static UCaccount _instance;
        public static UCaccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCaccount();
                return _instance;
            }
        }
        public UCaccount()
        {
            InitializeComponent();
            populate();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        string status;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = pbAccount.Image;
            ImageConverter converter = new ImageConverter();
            var ImageConvert = converter.ConvertTo(img, typeof(byte[]));

            if (pbAccount.Image == null)
            {
                MessageBox.Show("Please Add Picure");
            }
            else {

                if (rbActive.Checked == true)
                {
                    status = "Active";
                }
                else
                {
                    status = "InActive";
                }

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT into AccountTB(FirstName,MiddleName,LastName,UserName,Password,Email,Contact,Role,BirthDate,Address,AccCreation,Status,AccPicture) values(@FirstName,@MiddleName,@LastName,@UserName,@Password,@Email,@Contact,@Role,@BirthDate,@Address,@AccCreation,@Status,@AccPicture)", con);
                    cmd.Parameters.AddWithValue("@FirstName", tbFrstName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", tbMI.Text);
                    cmd.Parameters.AddWithValue("@LastName", tbLstName.Text);
                    cmd.Parameters.AddWithValue("@UserName", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", hash.hashPassword(tbPassword.Text));
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("@Contact", tbContact.Text);
                    cmd.Parameters.AddWithValue("@Role", cbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBOD.Value);
                    cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@AccCreation", dtpCreation.Value);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@AccPicture", ImageConvert);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Save");
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select img(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbAccount.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * from AccountTB";
            SqlDataAdapter  sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder scb  = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvAccount.DataSource = ds.Tables[0];
            con.Close();
        }

        private void clear()
        {
            tbFrstName.Text = "";
            tbMI.Text = "";
            tbLstName.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbEmail.Text = "";
            tbContact.Text = "";
            tbAddress.Text = "";
            rbActive.Checked = false;
            rbInactive.Checked = false;
            pbAccount.Image = null;

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from AccountTB where FirstName like '" + tbSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvAccount.DataSource = dt;
            con.Close();
        }

        private void dgvAccount_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbFrstName.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbMI.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbLstName.Text = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbUsername.Text = dgvAccount.Rows[e.RowIndex].Cells[3].Value.ToString();
            hash.hashPassword (tbPassword.Text = dgvAccount.Rows[e.RowIndex].Cells[4].Value.ToString());
            tbEmail.Text = dgvAccount.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbContact.Text = dgvAccount.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbRole.Text = dgvAccount.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbAddress.Text = dgvAccount.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Image img = pbAccount.Image;
            ImageConverter converter = new ImageConverter();
            var ImageConvert = converter.ConvertTo(img, typeof(byte[]));

            if (pbAccount.Image == null)
            {
                MessageBox.Show("Please Add Picure");
            }
            else
            {

                if (rbActive.Checked == true)
                {
                    status = "Active";
                }
                else
                {
                    status = "InActive";
                }

                try
                {
                    con.Open();
                    string query = "update AccountTB set FirstName ='" + tbFrstName.Text+ "',MiddleName ='" + tbMI.Text + "',LastName='" + tbLstName.Text + "',UserName='" + tbUsername.Text + "',Password='" + tbPassword.Text + "',Email='" + tbEmail.Text + "',Contact='" + tbContact.Text + "',Role='" + cbRole.SelectedItem.ToString() + "',BirthDate='" + dtpBOD.Value.Date + "',Address='" + tbAddress.Text + "',AccCreation='" + dtpCreation.Value.Date + "',Status='" + status + "',AccPicture='" + ImageConvert + "' where Username='" + tbUsername.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated");
                    con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from AccountTB where Username='" + tbUsername.Text + "';";
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