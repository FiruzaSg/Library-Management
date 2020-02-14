namespace LibrarySystem.Forms
{
    partial class UserForm
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
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.DgvAllUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlDeleteEdit = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RbnActive = new System.Windows.Forms.RadioButton();
            this.RbnPassive = new System.Windows.Forms.RadioButton();
            this.TxbUserPhone = new System.Windows.Forms.TextBox();
            this.TxbUserEmail = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxbEditFullname = new System.Windows.Forms.TextBox();
            this.BtnEditBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbUserPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllUsers)).BeginInit();
            this.PnlDeleteEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewUser.Location = new System.Drawing.Point(473, 28);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(132, 39);
            this.BtnNewUser.TabIndex = 0;
            this.BtnNewUser.Text = "New User";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // DgvAllUsers
            // 
            this.DgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4});
            this.DgvAllUsers.Location = new System.Drawing.Point(28, 28);
            this.DgvAllUsers.Name = "DgvAllUsers";
            this.DgvAllUsers.Size = new System.Drawing.Size(418, 264);
            this.DgvAllUsers.TabIndex = 1;
            this.DgvAllUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllUsers_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // PnlDeleteEdit
            // 
            this.PnlDeleteEdit.Controls.Add(this.TxbUserPassword);
            this.PnlDeleteEdit.Controls.Add(this.label5);
            this.PnlDeleteEdit.Controls.Add(this.label4);
            this.PnlDeleteEdit.Controls.Add(this.RbnActive);
            this.PnlDeleteEdit.Controls.Add(this.RbnPassive);
            this.PnlDeleteEdit.Controls.Add(this.TxbUserPhone);
            this.PnlDeleteEdit.Controls.Add(this.TxbUserEmail);
            this.PnlDeleteEdit.Controls.Add(this.BtnDelete);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditFullname);
            this.PnlDeleteEdit.Controls.Add(this.BtnEditBook);
            this.PnlDeleteEdit.Controls.Add(this.label3);
            this.PnlDeleteEdit.Controls.Add(this.label1);
            this.PnlDeleteEdit.Controls.Add(this.label2);
            this.PnlDeleteEdit.Location = new System.Drawing.Point(473, 106);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(510, 214);
            this.PnlDeleteEdit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Status";
            // 
            // RbnActive
            // 
            this.RbnActive.AutoSize = true;
            this.RbnActive.Location = new System.Drawing.Point(163, 146);
            this.RbnActive.Name = "RbnActive";
            this.RbnActive.Size = new System.Drawing.Size(55, 17);
            this.RbnActive.TabIndex = 23;
            this.RbnActive.TabStop = true;
            this.RbnActive.Text = "Active";
            this.RbnActive.UseVisualStyleBackColor = true;
            // 
            // RbnPassive
            // 
            this.RbnPassive.AutoSize = true;
            this.RbnPassive.Location = new System.Drawing.Point(163, 169);
            this.RbnPassive.Name = "RbnPassive";
            this.RbnPassive.Size = new System.Drawing.Size(62, 17);
            this.RbnPassive.TabIndex = 22;
            this.RbnPassive.TabStop = true;
            this.RbnPassive.Text = "Passive";
            this.RbnPassive.UseVisualStyleBackColor = true;
            // 
            // TxbUserPhone
            // 
            this.TxbUserPhone.Location = new System.Drawing.Point(6, 87);
            this.TxbUserPhone.Name = "TxbUserPhone";
            this.TxbUserPhone.Size = new System.Drawing.Size(141, 20);
            this.TxbUserPhone.TabIndex = 21;
            // 
            // TxbUserEmail
            // 
            this.TxbUserEmail.Location = new System.Drawing.Point(163, 26);
            this.TxbUserEmail.Name = "TxbUserEmail";
            this.TxbUserEmail.Size = new System.Drawing.Size(141, 20);
            this.TxbUserEmail.TabIndex = 20;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(325, 71);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(159, 36);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxbEditFullname
            // 
            this.TxbEditFullname.Location = new System.Drawing.Point(6, 26);
            this.TxbEditFullname.Name = "TxbEditFullname";
            this.TxbEditFullname.Size = new System.Drawing.Size(141, 20);
            this.TxbEditFullname.TabIndex = 4;
            // 
            // BtnEditBook
            // 
            this.BtnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBook.Location = new System.Drawing.Point(325, 26);
            this.BtnEditBook.Name = "BtnEditBook";
            this.BtnEditBook.Size = new System.Drawing.Size(159, 36);
            this.BtnEditBook.TabIndex = 2;
            this.BtnEditBook.Text = "Edit";
            this.BtnEditBook.UseVisualStyleBackColor = true;
            this.BtnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
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
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // TxbUserPassword
            // 
            this.TxbUserPassword.Location = new System.Drawing.Point(163, 87);
            this.TxbUserPassword.Name = "TxbUserPassword";
            this.TxbUserPassword.Size = new System.Drawing.Size(141, 20);
            this.TxbUserPassword.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.DgvAllUsers);
            this.Controls.Add(this.BtnNewUser);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllUsers)).EndInit();
            this.PnlDeleteEdit.ResumeLayout(false);
            this.PnlDeleteEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.DataGridView DgvAllUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel PnlDeleteEdit;
        private System.Windows.Forms.RadioButton RbnActive;
        private System.Windows.Forms.RadioButton RbnPassive;
        private System.Windows.Forms.TextBox TxbUserPhone;
        private System.Windows.Forms.TextBox TxbUserEmail;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxbEditFullname;
        private System.Windows.Forms.Button BtnEditBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbUserPassword;
        private System.Windows.Forms.Label label5;
    }
}