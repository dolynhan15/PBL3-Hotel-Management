namespace HotelManagement.GUI.Employees
{
    partial class Find_Employees
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
            this.textBoxFindEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEmp = new System.Windows.Forms.GroupBox();
            this.dtgvEmployeesFind = new System.Windows.Forms.DataGridView();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeesFind)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBoxFindEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 48);
            this.panel1.TabIndex = 78;
            // 
            // textBoxFindEmployee
            // 
            this.textBoxFindEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindEmployee.Location = new System.Drawing.Point(193, 11);
            this.textBoxFindEmployee.Name = "textBoxFindEmployee";
            this.textBoxFindEmployee.Size = new System.Drawing.Size(471, 29);
            this.textBoxFindEmployee.TabIndex = 1;
            this.textBoxFindEmployee.TextChanged += new System.EventHandler(this.textBoxFindEmployee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Employee";
            // 
            // groupEmp
            // 
            this.groupEmp.BackColor = System.Drawing.Color.Snow;
            this.groupEmp.Controls.Add(this.dtgvEmployeesFind);
            this.groupEmp.Location = new System.Drawing.Point(3, 59);
            this.groupEmp.Name = "groupEmp";
            this.groupEmp.Size = new System.Drawing.Size(680, 381);
            this.groupEmp.TabIndex = 80;
            this.groupEmp.TabStop = false;
            // 
            // dtgvEmployeesFind
            // 
            this.dtgvEmployeesFind.AllowUserToAddRows = false;
            this.dtgvEmployeesFind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmployeesFind.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvEmployeesFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployeesFind.Location = new System.Drawing.Point(3, 16);
            this.dtgvEmployeesFind.Name = "dtgvEmployeesFind";
            this.dtgvEmployeesFind.ReadOnly = true;
            this.dtgvEmployeesFind.Size = new System.Drawing.Size(671, 359);
            this.dtgvEmployeesFind.TabIndex = 0;
            this.dtgvEmployeesFind.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoubleClickRow);
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
            this.btnUpdateUsers.Location = new System.Drawing.Point(218, 446);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(211, 45);
            this.btnUpdateUsers.TabIndex = 82;
            this.btnUpdateUsers.Text = "           Update";
            this.btnUpdateUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUsers_Click);
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
            this.btnDeleteUsers.Location = new System.Drawing.Point(456, 446);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(211, 45);
            this.btnDeleteUsers.TabIndex = 83;
            this.btnDeleteUsers.Text = "           Delete";
            this.btnDeleteUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // Find_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnUpdateUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupEmp);
            this.Name = "Find_Employees";
            this.Size = new System.Drawing.Size(700, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeesFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupEmp;
        private System.Windows.Forms.TextBox textBoxFindEmployee;
        private System.Windows.Forms.DataGridView dtgvEmployeesFind;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
    }
}
