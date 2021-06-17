namespace HotelManagement
{
    partial class ManageRoom
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
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCheckToday = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTyperoom = new System.Windows.Forms.ComboBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateUsers = new System.Windows.Forms.Button();
            this.pFindUsers = new System.Windows.Forms.Panel();
            this.btnFindUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlRoom.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pnlRoom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 540);
            this.panel1.TabIndex = 4;
            // 
            // pnlRoom
            // 
            this.pnlRoom.Controls.Add(this.pnlFind);
            this.pnlRoom.Location = new System.Drawing.Point(218, 3);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(669, 534);
            this.pnlRoom.TabIndex = 1;
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.btnCheckToday);
            this.pnlFind.Controls.Add(this.label3);
            this.pnlFind.Controls.Add(this.cbTyperoom);
            this.pnlFind.Controls.Add(this.dateTo);
            this.pnlFind.Controls.Add(this.dateFrom);
            this.pnlFind.Controls.Add(this.label2);
            this.pnlFind.Controls.Add(this.label1);
            this.pnlFind.Controls.Add(this.flpRoom);
            this.pnlFind.Location = new System.Drawing.Point(3, 3);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(663, 528);
            this.pnlFind.TabIndex = 16;
            // 
            // btnCheckToday
            // 
            this.btnCheckToday.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckToday.Location = new System.Drawing.Point(336, 5);
            this.btnCheckToday.Name = "btnCheckToday";
            this.btnCheckToday.Size = new System.Drawing.Size(145, 69);
            this.btnCheckToday.TabIndex = 21;
            this.btnCheckToday.Text = "Check Today";
            this.btnCheckToday.UseVisualStyleBackColor = true;
            this.btnCheckToday.Click += new System.EventHandler(this.btnCheckToday_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(482, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Find ";
            // 
            // cbTyperoom
            // 
            this.cbTyperoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTyperoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTyperoom.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTyperoom.FormattingEnabled = true;
            this.cbTyperoom.Location = new System.Drawing.Point(487, 40);
            this.cbTyperoom.Name = "cbTyperoom";
            this.cbTyperoom.Size = new System.Drawing.Size(173, 31);
            this.cbTyperoom.TabIndex = 15;
            this.cbTyperoom.SelectedIndexChanged += new System.EventHandler(this.cbTyperoom_SelectedIndexChanged);
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTo.Location = new System.Drawing.Point(56, 46);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(274, 29);
            this.dateTo.TabIndex = 19;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateFrom.Location = new System.Drawing.Point(56, 7);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(274, 29);
            this.dateFrom.TabIndex = 18;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "From";
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Location = new System.Drawing.Point(3, 77);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Padding = new System.Windows.Forms.Padding(3);
            this.flpRoom.Size = new System.Drawing.Size(657, 448);
            this.flpRoom.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnCreateUsers);
            this.panel2.Controls.Add(this.pFindUsers);
            this.panel2.Controls.Add(this.btnFindUsers);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 537);
            this.panel2.TabIndex = 0;
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
            this.btnCreateUsers.TabIndex = 13;
            this.btnCreateUsers.Text = "           Edit";
            this.btnCreateUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUsers.UseVisualStyleBackColor = true;
            this.btnCreateUsers.Click += new System.EventHandler(this.btnCreateUsers_Click);
            // 
            // pFindUsers
            // 
            this.pFindUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(107)))));
            this.pFindUsers.Location = new System.Drawing.Point(0, 58);
            this.pFindUsers.Name = "pFindUsers";
            this.pFindUsers.Size = new System.Drawing.Size(8, 45);
            this.pFindUsers.TabIndex = 11;
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
            this.btnFindUsers.Text = "           Booking";
            this.btnFindUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUsers.UseVisualStyleBackColor = false;
            this.btnFindUsers.Click += new System.EventHandler(this.btnFindUsers_Click);
            // 
            // ManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Webp1;
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoom";
            this.Size = new System.Drawing.Size(994, 652);
            this.panel1.ResumeLayout(false);
            this.pnlRoom.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pFindUsers;
        private System.Windows.Forms.Button btnFindUsers;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.ComboBox cbTyperoom;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckToday;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
    }
}
