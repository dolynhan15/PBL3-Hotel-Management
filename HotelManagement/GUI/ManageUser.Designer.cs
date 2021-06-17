namespace HotelManagement
{
    partial class ManageUser
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
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pFindUsers = new System.Windows.Forms.Panel();
            this.btnCreateUsers = new System.Windows.Forms.Button();
            this.btnFindUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pnlUsers);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 540);
            this.panel1.TabIndex = 3;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Location = new System.Drawing.Point(214, 0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(673, 537);
            this.pnlUsers.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pFindUsers);
            this.panel2.Controls.Add(this.btnCreateUsers);
            this.panel2.Controls.Add(this.btnFindUsers);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 537);
            this.panel2.TabIndex = 0;
            // 
            // pFindUsers
            // 
            this.pFindUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(107)))));
            this.pFindUsers.Location = new System.Drawing.Point(0, 58);
            this.pFindUsers.Name = "pFindUsers";
            this.pFindUsers.Size = new System.Drawing.Size(8, 45);
            this.pFindUsers.TabIndex = 11;
            // 
            // btnCreateUsers
            // 
            this.btnCreateUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateUsers.FlatAppearance.BorderSize = 0;
            this.btnCreateUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUsers.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUsers.Image = global::HotelManagement.Properties.Resources._18u1;
            this.btnCreateUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUsers.Location = new System.Drawing.Point(1, 109);
            this.btnCreateUsers.Name = "btnCreateUsers";
            this.btnCreateUsers.Size = new System.Drawing.Size(211, 45);
            this.btnCreateUsers.TabIndex = 12;
            this.btnCreateUsers.Text = "           Create";
            this.btnCreateUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUsers.UseVisualStyleBackColor = true;
            this.btnCreateUsers.Click += new System.EventHandler(this.btnCreateUsers_Click);
            // 
            // btnFindUsers
            // 
            this.btnFindUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindUsers.FlatAppearance.BorderSize = 0;
            this.btnFindUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFindUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUsers.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUsers.Image = global::HotelManagement.Properties.Resources._9u6;
            this.btnFindUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUsers.Location = new System.Drawing.Point(1, 58);
            this.btnFindUsers.Name = "btnFindUsers";
            this.btnFindUsers.Size = new System.Drawing.Size(211, 45);
            this.btnFindUsers.TabIndex = 10;
            this.btnFindUsers.Text = "           Find";
            this.btnFindUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUsers.UseVisualStyleBackColor = false;
            this.btnFindUsers.Click += new System.EventHandler(this.btnFindUsers_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Webp1;
            this.Controls.Add(this.panel1);
            this.Name = "ManageUser";
            this.Size = new System.Drawing.Size(994, 652);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pFindUsers;
        private System.Windows.Forms.Button btnFindUsers;
        private System.Windows.Forms.Button btnCreateUsers;
        private System.Windows.Forms.Panel pnlUsers;
    }
}
