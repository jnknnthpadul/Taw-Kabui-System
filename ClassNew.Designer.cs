namespace Taw_Kabui_Management_System
{
    partial class ClassNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSY = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lblSY = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.gbAttribute = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbAttribute.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cbSY);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.cbTerm);
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.lblSY);
            this.panel1.Controls.Add(this.lblTerm);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // cbSY
            // 
            this.cbSY.FormattingEnabled = true;
            this.cbSY.Location = new System.Drawing.Point(604, 39);
            this.cbSY.Name = "cbSY";
            this.cbSY.Size = new System.Drawing.Size(171, 28);
            this.cbSY.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Taw_Kabui_Management_System.Properties.Resources.Back1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(321, 39);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(171, 28);
            this.cbTerm.TabIndex = 4;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(89, 39);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(171, 28);
            this.cbLevel.TabIndex = 3;
            // 
            // lblSY
            // 
            this.lblSY.AutoSize = true;
            this.lblSY.Location = new System.Drawing.Point(498, 42);
            this.lblSY.Name = "lblSY";
            this.lblSY.Size = new System.Drawing.Size(100, 20);
            this.lblSY.TabIndex = 2;
            this.lblSY.Text = "School Year:";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(266, 42);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(49, 20);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "Term:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(33, 42);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level:";
            // 
            // gbAttribute
            // 
            this.gbAttribute.Controls.Add(this.rtbDescription);
            this.gbAttribute.Controls.Add(this.lblDescription);
            this.gbAttribute.ForeColor = System.Drawing.Color.White;
            this.gbAttribute.Location = new System.Drawing.Point(37, 135);
            this.gbAttribute.Name = "gbAttribute";
            this.gbAttribute.Size = new System.Drawing.Size(684, 220);
            this.gbAttribute.TabIndex = 1;
            this.gbAttribute.TabStop = false;
            this.gbAttribute.Text = "Attribute";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(48, 63);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(604, 133);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(44, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(636, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ClassNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbAttribute);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassNew";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAttribute.ResumeLayout(false);
            this.gbAttribute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAttribute;
        private System.Windows.Forms.ComboBox cbSY;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblSY;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
    }
}