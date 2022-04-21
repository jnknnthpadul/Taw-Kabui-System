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
    public partial class UCfees : UserControl
    {
        private static UCfees _instance;
        public static UCfees Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCfees();
                return _instance;
            }
        }
        public UCfees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Desktop\Taw Kabui Management System\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        string status;
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from StudentTB where ChildNumber='" + tbChildID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tbStudName.Text = dr["ChildName"].ToString();
                tbImpairment.Text = dr["Impairment"].ToString();
                tbClass.Text = dr["Class"].ToString();
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into FeesTB(ChildID,StudentName,Impairment,Class,Date,Status,Note,Payment) values(@ChildID,@StudentName,@Impairment,@Class,@Date,@Status,@Note,@Payment)", con);
                cmd.Parameters.AddWithValue("@ChildID", tbChildID.Text);
                cmd.Parameters.AddWithValue("@StudentName", tbStudName.Text);
                cmd.Parameters.AddWithValue("@Impairment", tbImpairment.Text);
                cmd.Parameters.AddWithValue("@Class", tbClass.Text);
                cmd.Parameters.AddWithValue("@Date", dptDate.Value);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Note", tbNote.Text);
                cmd.Parameters.AddWithValue("@Payment", tbPay.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Added");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbPaid_CheckedChanged(object sender, EventArgs e)
        {
            status = "Paid";
        }

        private void rbNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            status = "Not Paid";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvFees.Rows.Add(tbPaymentNo.Text,tbProgram.Text,tbAmount.Text);
            tbPaymentNo.Clear();
            tbProgram.Clear();
            tbAmount.Clear();

            tbPay.Text = (from DataGridViewRow row in dgvFees.Rows where row.Cells[2].FormattedValue.ToString() != string.Empty select Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int pos = 180;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Student Payment Receipt", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(50));
            e.Graphics.DrawString("Student Name" + tbStudName.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10,30));
            e.Graphics.DrawString("Child ID" + tbChildID.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10,50));
            e.Graphics.DrawString("Impairment" + tbImpairment.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10,70));
            e.Graphics.DrawString("Class" + tbClass.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10,90));
            e.Graphics.DrawString("Date" + dptDate.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10,110));
            e.Graphics.DrawString("Payment Status" + status, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10,130));

            e.Graphics.DrawString("Payment No. Program Amount", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(26, 150));
            foreach (DataGridViewRow row in dgvFees.Rows)
            {
                string paymentno = "" + row.Cells["Payment"].Value;
                string program = "" + row.Cells["Program"].Value;
                string amount = "" + row.Cells["Amount"].Value;
                e.Graphics.DrawString("" + paymentno, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(50, pos));
                e.Graphics.DrawString("" + program, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(130, pos));
                e.Graphics.DrawString("" + amount, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(200, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Note:" + tbNote.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, pos + 30));
            e.Graphics.DrawString("Total Payment:" + tbPay.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, pos + 50));
            pos = 100;
        }
    }
}
