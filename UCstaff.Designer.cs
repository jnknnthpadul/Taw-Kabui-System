namespace Taw_Kabui_Management_System
{
    partial class UCstaff
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStaff = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbSSS = new System.Windows.Forms.TextBox();
            this.lblLstName = new System.Windows.Forms.Label();
            this.tbTIN = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.rbVolunteer = new System.Windows.Forms.RadioButton();
            this.rbContractual = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.dtpContract = new System.Windows.Forms.DateTimePicker();
            this.dtpHired = new System.Windows.Forms.DateTimePicker();
            this.dtpBOD = new System.Windows.Forms.DateTimePicker();
            this.lblContract = new System.Windows.Forms.Label();
            this.tbPreAddress = new System.Windows.Forms.TextBox();
            this.lblPreAddress = new System.Windows.Forms.Label();
            this.tbLstName = new System.Windows.Forms.TextBox();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.tbPerAddress = new System.Windows.Forms.TextBox();
            this.tbFrstName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chckFemale = new System.Windows.Forms.CheckBox();
            this.chckMale = new System.Windows.Forms.CheckBox();
            this.chckBlock = new System.Windows.Forms.CheckBox();
            this.chckRegular = new System.Windows.Forms.CheckBox();
            this.chckSuspended = new System.Windows.Forms.CheckBox();
            this.chckContractual = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblSSS = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMidName = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.lblTIN = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPerAddress = new System.Windows.Forms.Label();
            this.lblFrstName = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lblStaff);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 98);
            this.panel4.TabIndex = 0;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(18, 29);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(326, 46);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Staff Registration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1666, 946);
            this.panel3.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.tbSSS);
            this.panel1.Controls.Add(this.lblLstName);
            this.panel1.Controls.Add(this.tbTIN);
            this.panel1.Controls.Add(this.cbPosition);
            this.panel1.Controls.Add(this.cbDepartment);
            this.panel1.Controls.Add(this.cbSex);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.tbContact);
            this.panel1.Controls.Add(this.tbSalary);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.rbVolunteer);
            this.panel1.Controls.Add(this.rbContractual);
            this.panel1.Controls.Add(this.rbRegular);
            this.panel1.Controls.Add(this.dtpContract);
            this.panel1.Controls.Add(this.dtpHired);
            this.panel1.Controls.Add(this.dtpBOD);
            this.panel1.Controls.Add(this.lblContract);
            this.panel1.Controls.Add(this.tbPreAddress);
            this.panel1.Controls.Add(this.lblPreAddress);
            this.panel1.Controls.Add(this.tbLstName);
            this.panel1.Controls.Add(this.tbMidName);
            this.panel1.Controls.Add(this.tbPerAddress);
            this.panel1.Controls.Add(this.tbFrstName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.chckFemale);
            this.panel1.Controls.Add(this.chckMale);
            this.panel1.Controls.Add(this.chckBlock);
            this.panel1.Controls.Add(this.chckRegular);
            this.panel1.Controls.Add(this.chckSuspended);
            this.panel1.Controls.Add(this.chckContractual);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.dgvStaff);
            this.panel1.Controls.Add(this.lblSSS);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblMidName);
            this.panel1.Controls.Add(this.lblHired);
            this.panel1.Controls.Add(this.lblTIN);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblBirthDate);
            this.panel1.Controls.Add(this.lblPerAddress);
            this.panel1.Controls.Add(this.lblFrstName);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 844);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(52, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 31);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(52, 528);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 31);
            this.btnClear.TabIndex = 115;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbSSS
            // 
            this.tbSSS.Location = new System.Drawing.Point(820, 303);
            this.tbSSS.MaxLength = 9;
            this.tbSSS.Name = "tbSSS";
            this.tbSSS.Size = new System.Drawing.Size(269, 26);
            this.tbSSS.TabIndex = 114;
            // 
            // lblLstName
            // 
            this.lblLstName.AutoSize = true;
            this.lblLstName.Location = new System.Drawing.Point(1055, 21);
            this.lblLstName.Name = "lblLstName";
            this.lblLstName.Size = new System.Drawing.Size(86, 20);
            this.lblLstName.TabIndex = 66;
            this.lblLstName.Text = "Last Name";
            // 
            // tbTIN
            // 
            this.tbTIN.Location = new System.Drawing.Point(351, 302);
            this.tbTIN.MaxLength = 12;
            this.tbTIN.Name = "tbTIN";
            this.tbTIN.Size = new System.Drawing.Size(269, 26);
            this.tbTIN.TabIndex = 113;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPosition.Location = new System.Drawing.Point(819, 254);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(271, 28);
            this.cbPosition.TabIndex = 112;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Office",
            "Classroom"});
            this.cbDepartment.Location = new System.Drawing.Point(349, 251);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(271, 28);
            this.cbDepartment.TabIndex = 111;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(349, 147);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(271, 28);
            this.cbSex.TabIndex = 110;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Teacher",
            "Worker",
            "Volunteer"});
            this.cbRole.Location = new System.Drawing.Point(817, 203);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(271, 28);
            this.cbRole.TabIndex = 109;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(819, 147);
            this.tbContact.MaxLength = 11;
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(269, 26);
            this.tbContact.TabIndex = 108;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(1104, 102);
            this.tbSalary.MaxLength = 8;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(258, 26);
            this.tbSalary.TabIndex = 107;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(817, 102);
            this.tbAge.MaxLength = 2;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(155, 26);
            this.tbAge.TabIndex = 106;
            // 
            // rbVolunteer
            // 
            this.rbVolunteer.AutoSize = true;
            this.rbVolunteer.Location = new System.Drawing.Point(580, 204);
            this.rbVolunteer.Name = "rbVolunteer";
            this.rbVolunteer.Size = new System.Drawing.Size(103, 24);
            this.rbVolunteer.TabIndex = 105;
            this.rbVolunteer.TabStop = true;
            this.rbVolunteer.Text = "Volunteer";
            this.rbVolunteer.UseVisualStyleBackColor = true;
            // 
            // rbContractual
            // 
            this.rbContractual.AutoSize = true;
            this.rbContractual.Location = new System.Drawing.Point(458, 203);
            this.rbContractual.Name = "rbContractual";
            this.rbContractual.Size = new System.Drawing.Size(116, 24);
            this.rbContractual.TabIndex = 104;
            this.rbContractual.TabStop = true;
            this.rbContractual.Text = "Contractual";
            this.rbContractual.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(362, 201);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(90, 24);
            this.rbRegular.TabIndex = 103;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // dtpContract
            // 
            this.dtpContract.Location = new System.Drawing.Point(817, 355);
            this.dtpContract.Name = "dtpContract";
            this.dtpContract.Size = new System.Drawing.Size(262, 26);
            this.dtpContract.TabIndex = 102;
            // 
            // dtpHired
            // 
            this.dtpHired.Location = new System.Drawing.Point(349, 354);
            this.dtpHired.Name = "dtpHired";
            this.dtpHired.Size = new System.Drawing.Size(303, 26);
            this.dtpHired.TabIndex = 101;
            // 
            // dtpBOD
            // 
            this.dtpBOD.Location = new System.Drawing.Point(349, 99);
            this.dtpBOD.Name = "dtpBOD";
            this.dtpBOD.Size = new System.Drawing.Size(303, 26);
            this.dtpBOD.TabIndex = 100;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(704, 360);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(107, 20);
            this.lblContract.TabIndex = 97;
            this.lblContract.Text = "Contract End:";
            // 
            // tbPreAddress
            // 
            this.tbPreAddress.Location = new System.Drawing.Point(932, 54);
            this.tbPreAddress.Name = "tbPreAddress";
            this.tbPreAddress.Size = new System.Drawing.Size(430, 26);
            this.tbPreAddress.TabIndex = 96;
            // 
            // lblPreAddress
            // 
            this.lblPreAddress.AutoSize = true;
            this.lblPreAddress.Location = new System.Drawing.Point(799, 57);
            this.lblPreAddress.Name = "lblPreAddress";
            this.lblPreAddress.Size = new System.Drawing.Size(127, 20);
            this.lblPreAddress.TabIndex = 95;
            this.lblPreAddress.Text = "Present Address";
            // 
            // tbLstName
            // 
            this.tbLstName.Location = new System.Drawing.Point(1147, 18);
            this.tbLstName.Name = "tbLstName";
            this.tbLstName.Size = new System.Drawing.Size(215, 26);
            this.tbLstName.TabIndex = 94;
            // 
            // tbMidName
            // 
            this.tbMidName.Location = new System.Drawing.Point(810, 18);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(228, 26);
            this.tbMidName.TabIndex = 93;
            // 
            // tbPerAddress
            // 
            this.tbPerAddress.Location = new System.Drawing.Point(349, 54);
            this.tbPerAddress.Name = "tbPerAddress";
            this.tbPerAddress.Size = new System.Drawing.Size(441, 26);
            this.tbPerAddress.TabIndex = 92;
            // 
            // tbFrstName
            // 
            this.tbFrstName.Location = new System.Drawing.Point(349, 18);
            this.tbFrstName.Name = "tbFrstName";
            this.tbFrstName.Size = new System.Drawing.Size(349, 26);
            this.tbFrstName.TabIndex = 91;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(638, 764);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 31);
            this.btnSearch.TabIndex = 90;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chckFemale
            // 
            this.chckFemale.AutoSize = true;
            this.chckFemale.Location = new System.Drawing.Point(1253, 790);
            this.chckFemale.Name = "chckFemale";
            this.chckFemale.Size = new System.Drawing.Size(88, 24);
            this.chckFemale.TabIndex = 89;
            this.chckFemale.Text = "Female";
            this.chckFemale.UseVisualStyleBackColor = true;
            // 
            // chckMale
            // 
            this.chckMale.AutoSize = true;
            this.chckMale.Location = new System.Drawing.Point(1254, 750);
            this.chckMale.Name = "chckMale";
            this.chckMale.Size = new System.Drawing.Size(69, 24);
            this.chckMale.TabIndex = 88;
            this.chckMale.Text = "Male";
            this.chckMale.UseVisualStyleBackColor = true;
            // 
            // chckBlock
            // 
            this.chckBlock.AutoSize = true;
            this.chckBlock.Location = new System.Drawing.Point(1072, 790);
            this.chckBlock.Name = "chckBlock";
            this.chckBlock.Size = new System.Drawing.Size(74, 24);
            this.chckBlock.TabIndex = 87;
            this.chckBlock.Text = "Block";
            this.chckBlock.UseVisualStyleBackColor = true;
            // 
            // chckRegular
            // 
            this.chckRegular.AutoSize = true;
            this.chckRegular.Location = new System.Drawing.Point(1072, 750);
            this.chckRegular.Name = "chckRegular";
            this.chckRegular.Size = new System.Drawing.Size(91, 24);
            this.chckRegular.TabIndex = 86;
            this.chckRegular.Text = "Regular";
            this.chckRegular.UseVisualStyleBackColor = true;
            // 
            // chckSuspended
            // 
            this.chckSuspended.AutoSize = true;
            this.chckSuspended.Location = new System.Drawing.Point(878, 790);
            this.chckSuspended.Name = "chckSuspended";
            this.chckSuspended.Size = new System.Drawing.Size(117, 24);
            this.chckSuspended.TabIndex = 85;
            this.chckSuspended.Text = "Suspended";
            this.chckSuspended.UseVisualStyleBackColor = true;
            // 
            // chckContractual
            // 
            this.chckContractual.AutoSize = true;
            this.chckContractual.Location = new System.Drawing.Point(878, 750);
            this.chckContractual.Name = "chckContractual";
            this.chckContractual.Size = new System.Drawing.Size(117, 24);
            this.chckContractual.TabIndex = 84;
            this.chckContractual.Text = "Contractual";
            this.chckContractual.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(180, 766);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(452, 26);
            this.tbSearch.TabIndex = 83;
            this.tbSearch.Text = "Keyword";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(52, 685);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 31);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(52, 604);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 31);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(157, 400);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 62;
            this.dgvStaff.RowTemplate.Height = 28;
            this.dgvStaff.Size = new System.Drawing.Size(1446, 343);
            this.dgvStaff.TabIndex = 75;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Location = new System.Drawing.Point(741, 305);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(70, 20);
            this.lblSSS.TabIndex = 73;
            this.lblSSS.Text = "SSS No.";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(742, 254);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(69, 20);
            this.lblPosition.TabIndex = 72;
            this.lblPosition.Text = "Position:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(765, 205);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 71;
            this.lblRole.Text = "Role:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(689, 150);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(129, 20);
            this.lblContact.TabIndex = 70;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(992, 105);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(96, 20);
            this.lblSalary.TabIndex = 69;
            this.lblSalary.Text = "Rate/Salary:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(769, 105);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 68;
            this.lblAge.Text = "Age:";
            // 
            // lblMidName
            // 
            this.lblMidName.AutoSize = true;
            this.lblMidName.Location = new System.Drawing.Point(704, 21);
            this.lblMidName.Name = "lblMidName";
            this.lblMidName.Size = new System.Drawing.Size(105, 20);
            this.lblMidName.TabIndex = 67;
            this.lblMidName.Text = "Middle Name:";
            // 
            // lblHired
            // 
            this.lblHired.AutoSize = true;
            this.lblHired.Location = new System.Drawing.Point(253, 360);
            this.lblHired.Name = "lblHired";
            this.lblHired.Size = new System.Drawing.Size(90, 20);
            this.lblHired.TabIndex = 65;
            this.lblHired.Text = "Date Hired:";
            // 
            // lblTIN
            // 
            this.lblTIN.AutoSize = true;
            this.lblTIN.Location = new System.Drawing.Point(281, 306);
            this.lblTIN.Name = "lblTIN";
            this.lblTIN.Size = new System.Drawing.Size(62, 20);
            this.lblTIN.TabIndex = 64;
            this.lblTIN.Text = "TIN No.";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(245, 254);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(98, 20);
            this.lblDepartment.TabIndex = 63;
            this.lblDepartment.Text = "Department:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(283, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 62;
            this.lblStatus.Text = "Status:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(303, 150);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(40, 20);
            this.lblSex.TabIndex = 61;
            this.lblSex.Text = "Sex:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(258, 105);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(85, 20);
            this.lblBirthDate.TabIndex = 60;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblPerAddress
            // 
            this.lblPerAddress.AutoSize = true;
            this.lblPerAddress.Location = new System.Drawing.Point(189, 54);
            this.lblPerAddress.Name = "lblPerAddress";
            this.lblPerAddress.Size = new System.Drawing.Size(154, 20);
            this.lblPerAddress.TabIndex = 59;
            this.lblPerAddress.Text = "Permanent Address:";
            // 
            // lblFrstName
            // 
            this.lblFrstName.AutoSize = true;
            this.lblFrstName.Location = new System.Drawing.Point(257, 21);
            this.lblFrstName.Name = "lblFrstName";
            this.lblFrstName.Size = new System.Drawing.Size(86, 20);
            this.lblFrstName.TabIndex = 58;
            this.lblFrstName.Text = "First Name";
            // 
            // UCstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UCstaff";
            this.Size = new System.Drawing.Size(1666, 946);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSSS;
        private System.Windows.Forms.Label lblLstName;
        private System.Windows.Forms.TextBox tbTIN;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.RadioButton rbVolunteer;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.DateTimePicker dtpContract;
        private System.Windows.Forms.DateTimePicker dtpHired;
        private System.Windows.Forms.DateTimePicker dtpBOD;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox tbPreAddress;
        private System.Windows.Forms.Label lblPreAddress;
        private System.Windows.Forms.TextBox tbLstName;
        private System.Windows.Forms.TextBox tbMidName;
        private System.Windows.Forms.TextBox tbPerAddress;
        private System.Windows.Forms.TextBox tbFrstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chckFemale;
        private System.Windows.Forms.CheckBox chckMale;
        private System.Windows.Forms.CheckBox chckBlock;
        private System.Windows.Forms.CheckBox chckRegular;
        private System.Windows.Forms.CheckBox chckSuspended;
        private System.Windows.Forms.CheckBox chckContractual;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMidName;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Label lblTIN;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPerAddress;
        private System.Windows.Forms.Label lblFrstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbContractual;
    }
}
