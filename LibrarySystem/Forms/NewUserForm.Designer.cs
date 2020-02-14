namespace LibrarySystem.Forms
{
    partial class NewUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxbFullname = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.TxbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // TxbFullname
            // 
            this.TxbFullname.Location = new System.Drawing.Point(104, 37);
            this.TxbFullname.Name = "TxbFullname";
            this.TxbFullname.Size = new System.Drawing.Size(123, 20);
            this.TxbFullname.TabIndex = 1;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(324, 35);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(123, 20);
            this.TxbEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(324, 81);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(123, 20);
            this.TxbPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewUser.Location = new System.Drawing.Point(210, 142);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(123, 42);
            this.BtnNewUser.TabIndex = 6;
            this.BtnNewUser.Text = "Submit";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // TxbPhone
            // 
            this.TxbPhone.Location = new System.Drawing.Point(104, 78);
            this.TxbPhone.Name = "TxbPhone";
            this.TxbPhone.Size = new System.Drawing.Size(123, 20);
            this.TxbPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 275);
            this.Controls.Add(this.TxbPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbFullname);
            this.Controls.Add(this.label1);
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbFullname;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.TextBox TxbPhone;
        private System.Windows.Forms.Label label5;
    }
}