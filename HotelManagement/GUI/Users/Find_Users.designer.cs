namespace HotelManagement
{
    partial class Find_Users
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
            this.textBoxFindUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEmp = new System.Windows.Forms.GroupBox();
            this.dtgvUserFind = new System.Windows.Forms.DataGridView();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUserFind)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBoxFindUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 48);
            this.panel1.TabIndex = 84;
            // 
            // textBoxFindUser
            // 
            this.textBoxFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindUser.Location = new System.Drawing.Point(143, 11);
            this.textBoxFindUser.Name = "textBoxFindUser";
            this.textBoxFindUser.Size = new System.Drawing.Size(471, 29);
            this.textBoxFindUser.TabIndex = 1;
            this.textBoxFindUser.TextChanged += new System.EventHandler(this.textBoxFindUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find User";
            // 
            // groupEmp
            // 
            this.groupEmp.BackColor = System.Drawing.Color.Snow;
            this.groupEmp.Controls.Add(this.dtgvUserFind);
            this.groupEmp.Location = new System.Drawing.Point(10, 61);
            this.groupEmp.Name = "groupEmp";
            this.groupEmp.Size = new System.Drawing.Size(664, 381);
            this.groupEmp.TabIndex = 85;
            this.groupEmp.TabStop = false;
            // 
            // dtgvUserFind
            // 
            this.dtgvUserFind.AllowUserToAddRows = false;
            this.dtgvUserFind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUserFind.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvUserFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUserFind.Location = new System.Drawing.Point(3, 16);
            this.dtgvUserFind.Name = "dtgvUserFind";
            this.dtgvUserFind.ReadOnly = true;
            this.dtgvUserFind.Size = new System.Drawing.Size(648, 359);
            this.dtgvUserFind.TabIndex = 0;
            this.dtgvUserFind.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoubleClickRow);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteUsers.FlatAppearance.BorderSize = 0;
            this.btnDeleteUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.Image = global::HotelManagement.Properties.Resources._17u;
            this.btnDeleteUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUsers.Location = new System.Drawing.Point(463, 448);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(211, 45);
            this.btnDeleteUsers.TabIndex = 87;
            this.btnDeleteUsers.Text = "           Delete";
            this.btnDeleteUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.BackColor = System.Drawing.Color.Wheat;
            this.btnUpdateUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateUsers.FlatAppearance.BorderSize = 0;
            this.btnUpdateUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.Image = global::HotelManagement.Properties.Resources._10u1;
            this.btnUpdateUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUsers.Location = new System.Drawing.Point(225, 448);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(211, 45);
            this.btnUpdateUsers.TabIndex = 86;
            this.btnUpdateUsers.Text = "           Update";
            this.btnUpdateUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // Find_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupEmp);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnUpdateUsers);
            this.Name = "Find_Users";
            this.Size = new System.Drawing.Size(700, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUserFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFindUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupEmp;
        private System.Windows.Forms.DataGridView dtgvUserFind;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnUpdateUsers;
    }
}
