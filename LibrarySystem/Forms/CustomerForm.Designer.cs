namespace LibrarySystem.Forms
{
    partial class CustomerForm
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
            this.DgvAllCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlDeleteEdit = new System.Windows.Forms.Panel();
            this.TxbEditIdNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbEditSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbEditAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbEditPhone = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxbEditName = new System.Windows.Forms.TextBox();
            this.BtnEditCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNewCustomer = new System.Windows.Forms.Button();
            this.PnlNewCustomer = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxbCustomerUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbCustomerIdNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxbCustomerSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxbCustomerAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxbCustomerPhone = new System.Windows.Forms.TextBox();
            this.BtnCreateCustomer = new System.Windows.Forms.Button();
            this.TxbCustomerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllCustomers)).BeginInit();
            this.PnlDeleteEdit.SuspendLayout();
            this.PnlNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAllCustomers
            // 
            this.DgvAllCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvAllCustomers.Location = new System.Drawing.Point(13, 43);
            this.DgvAllCustomers.Name = "DgvAllCustomers";
            this.DgvAllCustomers.Size = new System.Drawing.Size(591, 327);
            this.DgvAllCustomers.TabIndex = 0;
            this.DgvAllCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllCustomers_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Identity card No";
            this.Column6.Name = "Column6";
            // 
            // PnlDeleteEdit
            // 
            this.PnlDeleteEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PnlDeleteEdit.Controls.Add(this.TxbEditIdNo);
            this.PnlDeleteEdit.Controls.Add(this.label2);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditSurname);
            this.PnlDeleteEdit.Controls.Add(this.label6);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditAddress);
            this.PnlDeleteEdit.Controls.Add(this.label5);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditPhone);
            this.PnlDeleteEdit.Controls.Add(this.BtnDelete);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditName);
            this.PnlDeleteEdit.Controls.Add(this.BtnEditCustomer);
            this.PnlDeleteEdit.Controls.Add(this.label3);
            this.PnlDeleteEdit.Controls.Add(this.label1);
            this.PnlDeleteEdit.Location = new System.Drawing.Point(624, 134);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(510, 214);
            this.PnlDeleteEdit.TabIndex = 9;
            // 
            // TxbEditIdNo
            // 
            this.TxbEditIdNo.Location = new System.Drawing.Point(6, 87);
            this.TxbEditIdNo.Name = "TxbEditIdNo";
            this.TxbEditIdNo.Size = new System.Drawing.Size(141, 20);
            this.TxbEditIdNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Identity card No";
            // 
            // TxbEditSurname
            // 
            this.TxbEditSurname.Location = new System.Drawing.Point(163, 26);
            this.TxbEditSurname.Name = "TxbEditSurname";
            this.TxbEditSurname.Size = new System.Drawing.Size(141, 20);
            this.TxbEditSurname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Surname";
            // 
            // TxbEditAddress
            // 
            this.TxbEditAddress.Location = new System.Drawing.Point(6, 145);
            this.TxbEditAddress.Name = "TxbEditAddress";
            this.TxbEditAddress.Size = new System.Drawing.Size(141, 20);
            this.TxbEditAddress.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address";
            // 
            // TxbEditPhone
            // 
            this.TxbEditPhone.Location = new System.Drawing.Point(163, 87);
            this.TxbEditPhone.Name = "TxbEditPhone";
            this.TxbEditPhone.Size = new System.Drawing.Size(141, 20);
            this.TxbEditPhone.TabIndex = 4;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(325, 71);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(159, 36);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxbEditName
            // 
            this.TxbEditName.Location = new System.Drawing.Point(6, 26);
            this.TxbEditName.Name = "TxbEditName";
            this.TxbEditName.Size = new System.Drawing.Size(141, 20);
            this.TxbEditName.TabIndex = 1;
            // 
            // BtnEditCustomer
            // 
            this.BtnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCustomer.Location = new System.Drawing.Point(325, 26);
            this.BtnEditCustomer.Name = "BtnEditCustomer";
            this.BtnEditCustomer.Size = new System.Drawing.Size(159, 36);
            this.BtnEditCustomer.TabIndex = 6;
            this.BtnEditCustomer.Text = "Edit";
            this.BtnEditCustomer.UseVisualStyleBackColor = true;
            this.BtnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // BtnNewCustomer
            // 
            this.BtnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCustomer.Location = new System.Drawing.Point(624, 72);
            this.BtnNewCustomer.Name = "BtnNewCustomer";
            this.BtnNewCustomer.Size = new System.Drawing.Size(155, 39);
            this.BtnNewCustomer.TabIndex = 8;
            this.BtnNewCustomer.Text = "New Customer";
            this.BtnNewCustomer.UseVisualStyleBackColor = true;
            this.BtnNewCustomer.Click += new System.EventHandler(this.BtnNewCustomer_Click);
            // 
            // PnlNewCustomer
            // 
            this.PnlNewCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PnlNewCustomer.Controls.Add(this.BtnClose);
            this.PnlNewCustomer.Controls.Add(this.TxbCustomerUser);
            this.PnlNewCustomer.Controls.Add(this.label4);
            this.PnlNewCustomer.Controls.Add(this.TxbCustomerIdNo);
            this.PnlNewCustomer.Controls.Add(this.label7);
            this.PnlNewCustomer.Controls.Add(this.TxbCustomerSurname);
            this.PnlNewCustomer.Controls.Add(this.label8);
            this.PnlNewCustomer.Controls.Add(this.TxbCustomerAddress);
            this.PnlNewCustomer.Controls.Add(this.label9);
            this.PnlNewCustomer.Controls.Add(this.TxbCustomerPhone);
            this.PnlNewCustomer.Controls.Add(this.BtnCreateCustomer);
            this.PnlNewCustomer.Controls.Add(this.TxbCustomerName);
            this.PnlNewCustomer.Controls.Add(this.label10);
            this.PnlNewCustomer.Controls.Add(this.label11);
            this.PnlNewCustomer.Location = new System.Drawing.Point(624, 134);
            this.PnlNewCustomer.Name = "PnlNewCustomer";
            this.PnlNewCustomer.Size = new System.Drawing.Size(436, 266);
            this.PnlNewCustomer.TabIndex = 11;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(398, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(23, 20);
            this.BtnClose.TabIndex = 48;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxbCustomerUser
            // 
            this.TxbCustomerUser.Location = new System.Drawing.Point(228, 161);
            this.TxbCustomerUser.Name = "TxbCustomerUser";
            this.TxbCustomerUser.ReadOnly = true;
            this.TxbCustomerUser.Size = new System.Drawing.Size(157, 20);
            this.TxbCustomerUser.TabIndex = 6;
            this.TxbCustomerUser.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "User";
            // 
            // TxbCustomerIdNo
            // 
            this.TxbCustomerIdNo.Location = new System.Drawing.Point(24, 103);
            this.TxbCustomerIdNo.Name = "TxbCustomerIdNo";
            this.TxbCustomerIdNo.Size = new System.Drawing.Size(154, 20);
            this.TxbCustomerIdNo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Identity card No";
            // 
            // TxbCustomerSurname
            // 
            this.TxbCustomerSurname.Location = new System.Drawing.Point(226, 42);
            this.TxbCustomerSurname.Name = "TxbCustomerSurname";
            this.TxbCustomerSurname.Size = new System.Drawing.Size(159, 20);
            this.TxbCustomerSurname.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Surname";
            // 
            // TxbCustomerAddress
            // 
            this.TxbCustomerAddress.Location = new System.Drawing.Point(24, 161);
            this.TxbCustomerAddress.Name = "TxbCustomerAddress";
            this.TxbCustomerAddress.Size = new System.Drawing.Size(154, 20);
            this.TxbCustomerAddress.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Address";
            // 
            // TxbCustomerPhone
            // 
            this.TxbCustomerPhone.Location = new System.Drawing.Point(226, 103);
            this.TxbCustomerPhone.Name = "TxbCustomerPhone";
            this.TxbCustomerPhone.Size = new System.Drawing.Size(159, 20);
            this.TxbCustomerPhone.TabIndex = 4;
            // 
            // BtnCreateCustomer
            // 
            this.BtnCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateCustomer.Location = new System.Drawing.Point(226, 206);
            this.BtnCreateCustomer.Name = "BtnCreateCustomer";
            this.BtnCreateCustomer.Size = new System.Drawing.Size(159, 36);
            this.BtnCreateCustomer.TabIndex = 35;
            this.BtnCreateCustomer.Text = "Add";
            this.BtnCreateCustomer.UseVisualStyleBackColor = true;
            this.BtnCreateCustomer.Click += new System.EventHandler(this.BtnCreateCustomer_Click);
            // 
            // TxbCustomerName
            // 
            this.TxbCustomerName.Location = new System.Drawing.Point(24, 42);
            this.TxbCustomerName.Name = "TxbCustomerName";
            this.TxbCustomerName.Size = new System.Drawing.Size(154, 20);
            this.TxbCustomerName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Name";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 521);
            this.Controls.Add(this.PnlNewCustomer);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.BtnNewCustomer);
            this.Controls.Add(this.DgvAllCustomers);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllCustomers)).EndInit();
            this.PnlDeleteEdit.ResumeLayout(false);
            this.PnlDeleteEdit.PerformLayout();
            this.PnlNewCustomer.ResumeLayout(false);
            this.PnlNewCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAllCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel PnlDeleteEdit;
        private System.Windows.Forms.TextBox TxbEditIdNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbEditSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbEditAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbEditPhone;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxbEditName;
        private System.Windows.Forms.Button BtnEditCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNewCustomer;
        private System.Windows.Forms.Panel PnlNewCustomer;
        private System.Windows.Forms.TextBox TxbCustomerUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbCustomerIdNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxbCustomerSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxbCustomerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxbCustomerPhone;
        private System.Windows.Forms.Button BtnCreateCustomer;
        private System.Windows.Forms.TextBox TxbCustomerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnClose;
    }
}