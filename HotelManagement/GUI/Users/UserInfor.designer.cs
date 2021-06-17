namespace HotelManagement.GUI.Users
{
    partial class UserInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfor));
            this.labelType = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txbRePassWord = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupUser = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(19, 264);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(56, 29);
            this.labelType.TabIndex = 38;
            this.labelType.Text = "Type";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.White;
            this.cbGender.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.Teal;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 26;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cbGender.Location = new System.Drawing.Point(294, 44);
            this.cbGender.MinimumSize = new System.Drawing.Size(50, 0);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(220, 34);
            this.cbGender.TabIndex = 36;
            this.cbGender.Text = "Male";
            // 
            // txbRePassWord
            // 
            this.txbRePassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRePassWord.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRePassWord.Location = new System.Drawing.Point(302, 230);
            this.txbRePassWord.Name = "txbRePassWord";
            this.txbRePassWord.Size = new System.Drawing.Size(229, 19);
            this.txbRePassWord.TabIndex = 13;
            this.txbRePassWord.UseSystemPasswordChar = true;
            // 
            // txbPassWord
            // 
            this.txbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassWord.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.Location = new System.Drawing.Point(26, 230);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(229, 19);
            this.txbPassWord.TabIndex = 12;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gender";
            // 
            // groupUser
            // 
            this.groupUser.BackColor = System.Drawing.Color.OldLace;
            this.groupUser.Controls.Add(this.cbType);
            this.groupUser.Controls.Add(this.labelType);
            this.groupUser.Controls.Add(this.cbGender);
            this.groupUser.Controls.Add(this.txbRePassWord);
            this.groupUser.Controls.Add(this.txbPassWord);
            this.groupUser.Controls.Add(this.label7);
            this.groupUser.Controls.Add(this.label6);
            this.groupUser.Controls.Add(this.txb1);
            this.groupUser.Controls.Add(this.label5);
            this.groupUser.Controls.Add(this.txb2);
            this.groupUser.Controls.Add(this.label4);
            this.groupUser.Controls.Add(this.txbName);
            this.groupUser.Controls.Add(this.label3);
            this.groupUser.Controls.Add(this.txbPhoneNumber);
            this.groupUser.Controls.Add(this.label2);
            this.groupUser.Controls.Add(this.txbUsername);
            this.groupUser.Location = new System.Drawing.Point(12, 38);
            this.groupUser.Name = "groupUser";
            this.groupUser.Size = new System.Drawing.Size(585, 351);
            this.groupUser.TabIndex = 44;
            this.groupUser.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password *";
            // 
            // txb1
            // 
            this.txb1.Enabled = false;
            this.txb1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(18, 220);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(243, 37);
            this.txb1.TabIndex = 9;
            this.txb1.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Re-password *";
            // 
            // txb2
            // 
            this.txb2.Enabled = false;
            this.txb2.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.Location = new System.Drawing.Point(294, 220);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(243, 37);
            this.txb2.TabIndex = 7;
            this.txb2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Display Name *";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.Teal;
            this.txbName.Location = new System.Drawing.Point(18, 129);
            this.txbName.MaxLength = 20;
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(243, 37);
            this.txbName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.Teal;
            this.txbPhoneNumber.Location = new System.Drawing.Point(294, 129);
            this.txbPhoneNumber.MaxLength = 10;
            this.txbPhoneNumber.Multiline = true;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(243, 37);
            this.txbPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username *";
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.Teal;
            this.txbUsername.Location = new System.Drawing.Point(18, 44);
            this.txbUsername.MaxLength = 15;
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(243, 37);
            this.txbUsername.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(423, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 85;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.Teal;
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 26;
            this.cbType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Receptionist"});
            this.cbType.Location = new System.Drawing.Point(18, 296);
            this.cbType.MinimumSize = new System.Drawing.Size(50, 0);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(243, 34);
            this.cbType.TabIndex = 41;
            // 
            // UserInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 471);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.groupUser.ResumeLayout(false);
            this.groupUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelType;
        public System.Windows.Forms.ComboBox cbGender;
        public System.Windows.Forms.TextBox txbRePassWord;
        public System.Windows.Forms.TextBox txbPassWord;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupUser;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txb1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txb2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbPhoneNumber;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbUsername;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cbType;
    }
}