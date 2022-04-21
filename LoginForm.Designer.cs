namespace Taw_Kabui_Management_System
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.linkForgot = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVis = new System.Windows.Forms.Button();
            this.btnNoVis = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Taw_Kabui_Management_System.Properties.Resources.Untitled;
            this.pbLogo.Location = new System.Drawing.Point(683, 35);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 150);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(704, 198);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(107, 36);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(524, 258);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "USERNAME:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(520, 317);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // linkForgot
            // 
            this.linkForgot.AutoSize = true;
            this.linkForgot.LinkColor = System.Drawing.Color.White;
            this.linkForgot.Location = new System.Drawing.Point(696, 492);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(137, 20);
            this.linkForgot.TabIndex = 4;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "Forgot password?";
            this.linkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgot_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(785, 414);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 47);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUser.Location = new System.Drawing.Point(633, 255);
            this.tbUser.MaxLength = 20;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(252, 28);
            this.tbUser.TabIndex = 6;
            // 
            // tbPass
            // 
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPass.Location = new System.Drawing.Point(633, 312);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '•';
            this.tbPass.Size = new System.Drawing.Size(252, 28);
            this.tbPass.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(255)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(662, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVis
            // 
            this.btnVis.BackColor = System.Drawing.Color.Transparent;
            this.btnVis.BackgroundImage = global::Taw_Kabui_Management_System.Properties.Resources.visibility;
            this.btnVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVis.FlatAppearance.BorderSize = 0;
            this.btnVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVis.ForeColor = System.Drawing.Color.Transparent;
            this.btnVis.Location = new System.Drawing.Point(889, 313);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(42, 29);
            this.btnVis.TabIndex = 9;
            this.btnVis.UseVisualStyleBackColor = false;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // btnNoVis
            // 
            this.btnNoVis.BackColor = System.Drawing.Color.Transparent;
            this.btnNoVis.BackgroundImage = global::Taw_Kabui_Management_System.Properties.Resources.visibility__1_;
            this.btnNoVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoVis.FlatAppearance.BorderSize = 0;
            this.btnNoVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoVis.ForeColor = System.Drawing.Color.Transparent;
            this.btnNoVis.Location = new System.Drawing.Point(889, 313);
            this.btnNoVis.Name = "btnNoVis";
            this.btnNoVis.Size = new System.Drawing.Size(42, 29);
            this.btnNoVis.TabIndex = 10;
            this.btnNoVis.UseVisualStyleBackColor = false;
            this.btnNoVis.Click += new System.EventHandler(this.btnNoVis_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(561, 370);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 20);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "ROLE:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Level Access 0",
            "Level Access 1"});
            this.cbRole.Location = new System.Drawing.Point(633, 367);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(252, 28);
            this.cbRole.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.BackgroundImage = global::Taw_Kabui_Management_System.Properties.Resources._274971748_480693566933104_4470172570114014334_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnVis);
            this.Controls.Add(this.btnNoVis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkForgot);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel linkForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVis;
        private System.Windows.Forms.Button btnNoVis;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
    }
}

