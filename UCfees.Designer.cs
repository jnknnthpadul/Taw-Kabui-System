namespace Taw_Kabui_Management_System
{
    partial class UCfees
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCfees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNotPaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.lblStatusPayment = new System.Windows.Forms.Label();
            this.dptDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProgram = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.tbPaymentNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.tbStudName = new System.Windows.Forms.TextBox();
            this.tbChildID = new System.Windows.Forms.TextBox();
            this.tbImpairment = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblChildID = new System.Windows.Forms.Label();
            this.lblImpairment = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFees = new System.Windows.Forms.Label();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 941);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.rbNotPaid);
            this.panel2.Controls.Add(this.rbPaid);
            this.panel2.Controls.Add(this.lblStatusPayment);
            this.panel2.Controls.Add(this.dptDate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblProgram);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.tbPay);
            this.panel2.Controls.Add(this.lblPay);
            this.panel2.Controls.Add(this.tbNote);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.dgvFees);
            this.panel2.Controls.Add(this.tbAmount);
            this.panel2.Controls.Add(this.tbProgram);
            this.panel2.Controls.Add(this.tbPaymentNo);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.tbClass);
            this.panel2.Controls.Add(this.tbStudName);
            this.panel2.Controls.Add(this.tbChildID);
            this.panel2.Controls.Add(this.tbImpairment);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.lblPayment);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblStudName);
            this.panel2.Controls.Add(this.lblChildID);
            this.panel2.Controls.Add(this.lblImpairment);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(2, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1529, 839);
            this.panel2.TabIndex = 247;
            // 
            // rbNotPaid
            // 
            this.rbNotPaid.AutoSize = true;
            this.rbNotPaid.Location = new System.Drawing.Point(800, 151);
            this.rbNotPaid.Name = "rbNotPaid";
            this.rbNotPaid.Size = new System.Drawing.Size(94, 24);
            this.rbNotPaid.TabIndex = 271;
            this.rbNotPaid.TabStop = true;
            this.rbNotPaid.Text = "Not Paid";
            this.rbNotPaid.UseVisualStyleBackColor = true;
            this.rbNotPaid.CheckedChanged += new System.EventHandler(this.rbNotPaid_CheckedChanged);
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(725, 152);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(65, 24);
            this.rbPaid.TabIndex = 270;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.CheckedChanged += new System.EventHandler(this.rbPaid_CheckedChanged);
            // 
            // lblStatusPayment
            // 
            this.lblStatusPayment.AutoSize = true;
            this.lblStatusPayment.Location = new System.Drawing.Point(597, 154);
            this.lblStatusPayment.Name = "lblStatusPayment";
            this.lblStatusPayment.Size = new System.Drawing.Size(122, 20);
            this.lblStatusPayment.TabIndex = 269;
            this.lblStatusPayment.Text = "Payment Status";
            // 
            // dptDate
            // 
            this.dptDate.Location = new System.Drawing.Point(169, 148);
            this.dptDate.Name = "dptDate";
            this.dptDate.Size = new System.Drawing.Size(338, 26);
            this.dptDate.TabIndex = 268;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(516, 732);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 59);
            this.btnSave.TabIndex = 263;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(372, 204);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(69, 20);
            this.lblProgram.TabIndex = 267;
            this.lblProgram.Text = "Program";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(661, 732);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 59);
            this.btnPrint.TabIndex = 264;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(372, 105);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 266;
            this.lblClass.Text = "Class";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(104, 695);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(197, 26);
            this.tbNote.TabIndex = 256;
            this.tbNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox15_KeyPress);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(51, 698);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(47, 20);
            this.lblNote.TabIndex = 255;
            this.lblNote.Text = "Note:";
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToAddRows = false;
            this.dgvFees.AllowUserToDeleteRows = false;
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Payment,
            this.Program,
            this.Amount});
            this.dgvFees.Location = new System.Drawing.Point(44, 250);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.ReadOnly = true;
            this.dgvFees.RowHeadersWidth = 62;
            this.dgvFees.RowTemplate.Height = 28;
            this.dgvFees.Size = new System.Drawing.Size(1449, 430);
            this.dgvFees.TabIndex = 254;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(720, 201);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(197, 26);
            this.tbAmount.TabIndex = 253;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox14_KeyPress);
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(446, 201);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(197, 26);
            this.tbProgram.TabIndex = 252;
            this.tbProgram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            // 
            // tbPaymentNo
            // 
            this.tbPaymentNo.Location = new System.Drawing.Point(169, 201);
            this.tbPaymentNo.Name = "tbPaymentNo";
            this.tbPaymentNo.Size = new System.Drawing.Size(197, 26);
            this.tbPaymentNo.TabIndex = 251;
            this.tbPaymentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(936, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 41);
            this.btnAdd.TabIndex = 250;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(436, 102);
            this.tbClass.Name = "tbClass";
            this.tbClass.ReadOnly = true;
            this.tbClass.Size = new System.Drawing.Size(197, 26);
            this.tbClass.TabIndex = 244;
            this.tbClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // tbStudName
            // 
            this.tbStudName.Location = new System.Drawing.Point(169, 46);
            this.tbStudName.Name = "tbStudName";
            this.tbStudName.ReadOnly = true;
            this.tbStudName.Size = new System.Drawing.Size(464, 26);
            this.tbStudName.TabIndex = 243;
            this.tbStudName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // tbChildID
            // 
            this.tbChildID.Location = new System.Drawing.Point(720, 49);
            this.tbChildID.Name = "tbChildID";
            this.tbChildID.Size = new System.Drawing.Size(197, 26);
            this.tbChildID.TabIndex = 242;
            this.tbChildID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tbImpairment
            // 
            this.tbImpairment.Location = new System.Drawing.Point(169, 102);
            this.tbImpairment.Name = "tbImpairment";
            this.tbImpairment.ReadOnly = true;
            this.tbImpairment.Size = new System.Drawing.Size(197, 26);
            this.tbImpairment.TabIndex = 241;
            this.tbImpairment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(654, 203);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 240;
            this.lblAmount.Text = "Amount";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(64, 204);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(99, 20);
            this.lblPayment.TabIndex = 239;
            this.lblPayment.Text = "Payment No.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(119, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 234;
            this.lblDate.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 233;
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(51, 49);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(112, 20);
            this.lblStudName.TabIndex = 232;
            this.lblStudName.Text = "Student Name";
            // 
            // lblChildID
            // 
            this.lblChildID.AutoSize = true;
            this.lblChildID.Location = new System.Drawing.Point(654, 52);
            this.lblChildID.Name = "lblChildID";
            this.lblChildID.Size = new System.Drawing.Size(65, 20);
            this.lblChildID.TabIndex = 231;
            this.lblChildID.Text = "Child ID";
            // 
            // lblImpairment
            // 
            this.lblImpairment.AutoSize = true;
            this.lblImpairment.Location = new System.Drawing.Point(74, 105);
            this.lblImpairment.Name = "lblImpairment";
            this.lblImpairment.Size = new System.Drawing.Size(89, 20);
            this.lblImpairment.TabIndex = 230;
            this.lblImpairment.Text = "Impairment";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(932, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 229;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lblFees);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 98);
            this.panel4.TabIndex = 246;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(18, 29);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(108, 46);
            this.lblFees.TabIndex = 0;
            this.lblFees.Text = "Fees";
            // 
            // tbPay
            // 
            this.tbPay.Location = new System.Drawing.Point(1296, 698);
            this.tbPay.Name = "tbPay";
            this.tbPay.ReadOnly = true;
            this.tbPay.Size = new System.Drawing.Size(197, 26);
            this.tbPay.TabIndex = 262;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(1206, 698);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(78, 20);
            this.lblPay.TabIndex = 261;
            this.lblPay.Text = "Total Pay:";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment No.";
            this.Payment.MinimumWidth = 8;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 300;
            // 
            // Program
            // 
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 8;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            this.Program.Width = 300;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 300;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // UCfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UCfees";
            this.Size = new System.Drawing.Size(1534, 941);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.TextBox tbPaymentNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.TextBox tbStudName;
        private System.Windows.Forms.TextBox tbChildID;
        private System.Windows.Forms.TextBox tbImpairment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblChildID;
        private System.Windows.Forms.Label lblImpairment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.DateTimePicker dptDate;
        private System.Windows.Forms.RadioButton rbNotPaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.Label lblStatusPayment;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
