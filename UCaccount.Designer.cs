namespace Taw_Kabui_Management_System
{
    partial class UCaccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.lblCreation = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbMI = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLstName = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.dtpBOD = new System.Windows.Forms.DateTimePicker();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.dtpCreation = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbFrstName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1666, 946);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvAccount);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.pbAccount);
            this.panel2.Controls.Add(this.lblCreation);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblBirthDate);
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.tbMI);
            this.panel2.Controls.Add(this.lblContact);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblFullname);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.tbLstName);
            this.panel2.Controls.Add(this.cbRole);
            this.panel2.Controls.Add(this.dtpBOD);
            this.panel2.Controls.Add(this.rbInactive);
            this.panel2.Controls.Add(this.rbActive);
            this.panel2.Controls.Add(this.dtpCreation);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.tbAddress);
            this.panel2.Controls.Add(this.tbContact);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.tbFrstName);
            this.panel2.Location = new System.Drawing.Point(1, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1662, 844);
            this.panel2.TabIndex = 246;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(25, 431);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.Size = new System.Drawing.Size(1617, 393);
            this.dgvAccount.TabIndex = 277;
            this.dgvAccount.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentDoubleClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1376, 307);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 37);
            this.btnBrowse.TabIndex = 255;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbAccount
            // 
            this.pbAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbAccount.Location = new System.Drawing.Point(1316, 51);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(222, 250);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccount.TabIndex = 254;
            this.pbAccount.TabStop = false;
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Location = new System.Drawing.Point(703, 216);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(136, 20);
            this.lblCreation.TabIndex = 253;
            this.lblCreation.Text = "Account Creation:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(703, 156);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 252;
            this.lblAddress.Text = "Address:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(703, 90);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(81, 20);
            this.lblBirthDate.TabIndex = 251;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(703, 19);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 250;
            this.lblRole.Text = "Role:";
            // 
            // tbMI
            // 
            this.tbMI.Location = new System.Drawing.Point(253, 51);
            this.tbMI.Name = "tbMI";
            this.tbMI.Size = new System.Drawing.Size(155, 26);
            this.tbMI.TabIndex = 275;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(95, 279);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(69, 20);
            this.lblContact.TabIndex = 249;
            this.lblContact.Text = "Contact:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 248;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(95, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 246;
            this.lblUsername.Text = "Username:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(707, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 256;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(95, 19);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(78, 20);
            this.lblFullname.TabIndex = 245;
            this.lblFullname.Text = "Fullname:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(95, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 247;
            this.lblPassword.Text = "Password:";
            // 
            // tbLstName
            // 
            this.tbLstName.Location = new System.Drawing.Point(414, 51);
            this.tbLstName.Name = "tbLstName";
            this.tbLstName.Size = new System.Drawing.Size(146, 26);
            this.tbLstName.TabIndex = 276;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Level Access 0",
            "Level Access 1",
            "Level Access 2",
            "Level Access 3"});
            this.cbRole.Location = new System.Drawing.Point(707, 51);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(385, 28);
            this.cbRole.TabIndex = 274;
            // 
            // dtpBOD
            // 
            this.dtpBOD.Location = new System.Drawing.Point(707, 124);
            this.dtpBOD.Name = "dtpBOD";
            this.dtpBOD.Size = new System.Drawing.Size(385, 26);
            this.dtpBOD.TabIndex = 273;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(867, 313);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(89, 24);
            this.rbInactive.TabIndex = 271;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(732, 313);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(77, 24);
            this.rbActive.TabIndex = 270;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // dtpCreation
            // 
            this.dtpCreation.Location = new System.Drawing.Point(707, 242);
            this.dtpCreation.Name = "dtpCreation";
            this.dtpCreation.Size = new System.Drawing.Size(385, 26);
            this.dtpCreation.TabIndex = 269;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(703, 282);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 268;
            this.lblStatus.Text = "Status";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(1410, 399);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(232, 26);
            this.tbSearch.TabIndex = 266;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(994, 348);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(98, 37);
            this.btnDel.TabIndex = 265;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(848, 348);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 37);
            this.btnEdit.TabIndex = 264;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(707, 183);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(385, 26);
            this.tbAddress.TabIndex = 263;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(99, 305);
            this.tbContact.MaxLength = 11;
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(461, 26);
            this.tbContact.TabIndex = 262;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(99, 239);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(461, 26);
            this.tbEmail.TabIndex = 261;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(99, 178);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(461, 26);
            this.tbPassword.TabIndex = 260;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(99, 113);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(461, 26);
            this.tbUsername.TabIndex = 259;
            // 
            // tbFrstName
            // 
            this.tbFrstName.Location = new System.Drawing.Point(99, 51);
            this.tbFrstName.Name = "tbFrstName";
            this.tbFrstName.Size = new System.Drawing.Size(148, 26);
            this.tbFrstName.TabIndex = 258;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lblAccount);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 98);
            this.panel4.TabIndex = 245;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(18, 29);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(391, 46);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account Registration";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UCaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UCaccount";
            this.Size = new System.Drawing.Size(1666, 946);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbAccount;
        private System.Windows.Forms.Label lblCreation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbMI;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLstName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.DateTimePicker dtpBOD;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.DateTimePicker dtpCreation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbFrstName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvAccount;
    }
}
