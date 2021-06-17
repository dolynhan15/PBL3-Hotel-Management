namespace HotelManagement.GUI.Guests
{
    partial class Find_Guests
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
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.btnUpdateGuest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFindGuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEmp = new System.Windows.Forms.GroupBox();
            this.dtgvGuestFind = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGuestFind)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteGuest.FlatAppearance.BorderSize = 0;
            this.btnDeleteGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGuest.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGuest.Image = global::HotelManagement.Properties.Resources._17u;
            this.btnDeleteGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGuest.Location = new System.Drawing.Point(463, 448);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(211, 45);
            this.btnDeleteGuest.TabIndex = 87;
            this.btnDeleteGuest.Text = "           Delete";
            this.btnDeleteGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGuest.UseVisualStyleBackColor = false;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.BackColor = System.Drawing.Color.Wheat;
            this.btnUpdateGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateGuest.FlatAppearance.BorderSize = 0;
            this.btnUpdateGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGuest.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGuest.Image = global::HotelManagement.Properties.Resources._10u1;
            this.btnUpdateGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGuest.Location = new System.Drawing.Point(225, 448);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(211, 45);
            this.btnUpdateGuest.TabIndex = 86;
            this.btnUpdateGuest.Text = "           Update";
            this.btnUpdateGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGuest.UseVisualStyleBackColor = false;
            this.btnUpdateGuest.Click += new System.EventHandler(this.btnUpdateGuest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.textBoxFindGuest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 48);
            this.panel1.TabIndex = 84;
            // 
            // textBoxFindGuest
            // 
            this.textBoxFindGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindGuest.Location = new System.Drawing.Point(193, 11);
            this.textBoxFindGuest.Name = "textBoxFindGuest";
            this.textBoxFindGuest.Size = new System.Drawing.Size(441, 29);
            this.textBoxFindGuest.TabIndex = 1;
            this.textBoxFindGuest.TextChanged += new System.EventHandler(this.textBoxFindGuest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Guest";
            // 
            // groupEmp
            // 
            this.groupEmp.BackColor = System.Drawing.Color.Snow;
            this.groupEmp.Controls.Add(this.dtgvGuestFind);
            this.groupEmp.Location = new System.Drawing.Point(10, 61);
            this.groupEmp.Name = "groupEmp";
            this.groupEmp.Size = new System.Drawing.Size(675, 381);
            this.groupEmp.TabIndex = 85;
            this.groupEmp.TabStop = false;
            // 
            // dtgvGuestFind
            // 
            this.dtgvGuestFind.AllowUserToAddRows = false;
            this.dtgvGuestFind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGuestFind.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvGuestFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGuestFind.Location = new System.Drawing.Point(3, 16);
            this.dtgvGuestFind.Name = "dtgvGuestFind";
            this.dtgvGuestFind.ReadOnly = true;
            this.dtgvGuestFind.Size = new System.Drawing.Size(661, 359);
            this.dtgvGuestFind.TabIndex = 0;
            this.dtgvGuestFind.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoubleClickRow);
            // 
            // Find_Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.btnUpdateGuest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupEmp);
            this.Name = "Find_Guests";
            this.Size = new System.Drawing.Size(700, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGuestFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Button btnUpdateGuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFindGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupEmp;
        private System.Windows.Forms.DataGridView dtgvGuestFind;
    }
}
