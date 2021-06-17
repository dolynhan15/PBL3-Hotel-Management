namespace HotelManagement.GUI.Bills
{
    partial class BillInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillInfor));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupEmp = new System.Windows.Forms.GroupBox();
            this.cbGuest = new System.Windows.Forms.ComboBox();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpkCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.dtpkSet = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFood_Bev = new System.Windows.Forms.Button();
            this.dtgvBillinfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbRoomNumber = new System.Windows.Forms.TextBox();
            this.groupEmp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(457, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // groupEmp
            // 
            this.groupEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.groupEmp.Controls.Add(this.txbRoomNumber);
            this.groupEmp.Controls.Add(this.cbGuest);
            this.groupEmp.Controls.Add(this.cbEmp);
            this.groupEmp.Controls.Add(this.txbDiscount);
            this.groupEmp.Controls.Add(this.label10);
            this.groupEmp.Controls.Add(this.checkBox2);
            this.groupEmp.Controls.Add(this.label5);
            this.groupEmp.Controls.Add(this.dtpkCheckOut);
            this.groupEmp.Controls.Add(this.label9);
            this.groupEmp.Controls.Add(this.dtpkCheckIn);
            this.groupEmp.Controls.Add(this.label8);
            this.groupEmp.Controls.Add(this.label15);
            this.groupEmp.Controls.Add(this.label4);
            this.groupEmp.Controls.Add(this.txbStatus);
            this.groupEmp.Controls.Add(this.dtpkSet);
            this.groupEmp.Controls.Add(this.label6);
            this.groupEmp.Controls.Add(this.txbTotal);
            this.groupEmp.Controls.Add(this.label1);
            this.groupEmp.Controls.Add(this.label7);
            this.groupEmp.Controls.Add(this.label3);
            this.groupEmp.Controls.Add(this.label2);
            this.groupEmp.Controls.Add(this.labelID);
            this.groupEmp.Location = new System.Drawing.Point(22, 22);
            this.groupEmp.Name = "groupEmp";
            this.groupEmp.Size = new System.Drawing.Size(585, 391);
            this.groupEmp.TabIndex = 83;
            this.groupEmp.TabStop = false;
            // 
            // cbGuest
            // 
            this.cbGuest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbGuest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGuest.Font = new System.Drawing.Font("Sitka Heading", 15F);
            this.cbGuest.FormattingEnabled = true;
            this.cbGuest.Location = new System.Drawing.Point(297, 49);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(243, 37);
            this.cbGuest.TabIndex = 98;
            // 
            // cbEmp
            // 
            this.cbEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmp.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(297, 118);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.Size = new System.Drawing.Size(243, 37);
            this.cbEmp.TabIndex = 97;
            // 
            // txbDiscount
            // 
            this.txbDiscount.BackColor = System.Drawing.Color.LavenderBlush;
            this.txbDiscount.Enabled = false;
            this.txbDiscount.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiscount.ForeColor = System.Drawing.Color.Crimson;
            this.txbDiscount.Location = new System.Drawing.Point(297, 202);
            this.txbDiscount.MaxLength = 10;
            this.txbDiscount.Multiline = true;
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(243, 37);
            this.txbDiscount.TabIndex = 95;
            this.txbDiscount.Text = "0%";
            this.txbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Freestyle Script", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(6, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 47);
            this.label10.TabIndex = 94;
            this.label10.Text = "⌂ ";
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Sitka Banner", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.checkBox2.Location = new System.Drawing.Point(291, 342);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.checkBox2.Size = new System.Drawing.Size(314, 29);
            this.checkBox2.TabIndex = 93;
            this.checkBox2.Text = "The total charge included the service";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Discount";
            // 
            // dtpkCheckOut
            // 
            this.dtpkCheckOut.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkCheckOut.Enabled = false;
            this.dtpkCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkCheckOut.Location = new System.Drawing.Point(15, 340);
            this.dtpkCheckOut.Name = "dtpkCheckOut";
            this.dtpkCheckOut.Size = new System.Drawing.Size(243, 28);
            this.dtpkCheckOut.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 29);
            this.label9.TabIndex = 90;
            this.label9.Text = "Date Check OUT";
            // 
            // dtpkCheckIn
            // 
            this.dtpkCheckIn.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkCheckIn.Enabled = false;
            this.dtpkCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkCheckIn.Location = new System.Drawing.Point(15, 272);
            this.dtpkCheckIn.Name = "dtpkCheckIn";
            this.dtpkCheckIn.Size = new System.Drawing.Size(243, 28);
            this.dtpkCheckIn.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 88;
            this.label8.Text = "Date Check IN";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Purple;
            this.label15.Location = new System.Drawing.Point(12, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 1);
            this.label15.TabIndex = 85;
            this.label15.Text = "label15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 86;
            this.label4.Text = "Status";
            // 
            // txbStatus
            // 
            this.txbStatus.Enabled = false;
            this.txbStatus.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.ForeColor = System.Drawing.Color.Teal;
            this.txbStatus.Location = new System.Drawing.Point(121, 103);
            this.txbStatus.MaxLength = 10;
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(137, 33);
            this.txbStatus.TabIndex = 87;
            // 
            // dtpkSet
            // 
            this.dtpkSet.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkSet.Enabled = false;
            this.dtpkSet.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkSet.Location = new System.Drawing.Point(15, 202);
            this.dtpkSet.Name = "dtpkSet";
            this.dtpkSet.Size = new System.Drawing.Size(243, 28);
            this.dtpkSet.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 84;
            this.label6.Text = "Date Set";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.Color.LavenderBlush;
            this.txbTotal.Enabled = false;
            this.txbTotal.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.ForeColor = System.Drawing.Color.Crimson;
            this.txbTotal.Location = new System.Drawing.Point(297, 288);
            this.txbTotal.MaxLength = 10;
            this.txbTotal.Multiline = true;
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(243, 37);
            this.txbTotal.TabIndex = 83;
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = "Total Money    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 29);
            this.label7.TabIndex = 71;
            this.label7.Text = "Employee\'s Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Guest\'s Identitaion Card *";
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Teal;
            this.labelID.Location = new System.Drawing.Point(176, 12);
            this.labelID.MaxLength = 10;
            this.labelID.Multiline = true;
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(94, 33);
            this.labelID.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnFood_Bev);
            this.groupBox1.Controls.Add(this.dtgvBillinfo);
            this.groupBox1.Location = new System.Drawing.Point(613, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 391);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(6, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 39);
            this.label11.TabIndex = 65;
            this.label11.Text = "Billinfo";
            // 
            // btnFood_Bev
            // 
            this.btnFood_Bev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnFood_Bev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFood_Bev.FlatAppearance.BorderSize = 0;
            this.btnFood_Bev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFood_Bev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood_Bev.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood_Bev.Image = global::HotelManagement.Properties.Resources._14u6;
            this.btnFood_Bev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood_Bev.Location = new System.Drawing.Point(6, 264);
            this.btnFood_Bev.Name = "btnFood_Bev";
            this.btnFood_Bev.Size = new System.Drawing.Size(210, 45);
            this.btnFood_Bev.TabIndex = 64;
            this.btnFood_Bev.Text = "           Food Beverage";
            this.btnFood_Bev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood_Bev.UseVisualStyleBackColor = false;
            this.btnFood_Bev.Click += new System.EventHandler(this.btnFood_Bev_Click);
            // 
            // dtgvBillinfo
            // 
            this.dtgvBillinfo.AllowUserToAddRows = false;
            this.dtgvBillinfo.AllowUserToDeleteRows = false;
            this.dtgvBillinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvBillinfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.dtgvBillinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name1,
            this.Amount,
            this.Price,
            this.Total});
            this.dtgvBillinfo.Location = new System.Drawing.Point(6, 56);
            this.dtgvBillinfo.Name = "dtgvBillinfo";
            this.dtgvBillinfo.ReadOnly = true;
            this.dtgvBillinfo.Size = new System.Drawing.Size(573, 192);
            this.dtgvBillinfo.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_bill";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Width = 60;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 68;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 56;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total_price";
            this.Total.HeaderText = "Total Price";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 83;
            // 
            // txbRoomNumber
            // 
            this.txbRoomNumber.Enabled = false;
            this.txbRoomNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbRoomNumber.Location = new System.Drawing.Point(170, 56);
            this.txbRoomNumber.Name = "txbRoomNumber";
            this.txbRoomNumber.Size = new System.Drawing.Size(88, 29);
            this.txbRoomNumber.TabIndex = 101;
            // 
            // BillInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1205, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillInfor";
            this.Text = "BillInfor";
            this.groupEmp.ResumeLayout(false);
            this.groupEmp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.GroupBox groupEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpkSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpkCheckOut;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dtpkCheckIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txbDiscount;
        public System.Windows.Forms.ComboBox cbGuest;
        public System.Windows.Forms.ComboBox cbEmp;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox labelID;
        public System.Windows.Forms.DataGridView dtgvBillinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnFood_Bev;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txbStatus;
        public System.Windows.Forms.TextBox txbRoomNumber;
    }
}