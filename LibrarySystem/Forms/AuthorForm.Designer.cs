namespace LibrarySystem.Forms
{
    partial class AuthorForm
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
            this.DgvAllAuthors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNewAuthor = new System.Windows.Forms.Button();
            this.BtnDeleteAuthor = new System.Windows.Forms.Button();
            this.BtnEditAuthor = new System.Windows.Forms.Button();
            this.PnlDeleteEdit = new System.Windows.Forms.Panel();
            this.LblErr = new System.Windows.Forms.Label();
            this.TxbAuthorEdit = new System.Windows.Forms.TextBox();
            this.PnlNewAuthor = new System.Windows.Forms.Panel();
            this.LblErr1 = new System.Windows.Forms.Label();
            this.BtnCreateAuthor = new System.Windows.Forms.Button();
            this.TxbNewAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllAuthors)).BeginInit();
            this.PnlDeleteEdit.SuspendLayout();
            this.PnlNewAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAllAuthors
            // 
            this.DgvAllAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvAllAuthors.Location = new System.Drawing.Point(26, 62);
            this.DgvAllAuthors.Name = "DgvAllAuthors";
            this.DgvAllAuthors.Size = new System.Drawing.Size(193, 376);
            this.DgvAllAuthors.TabIndex = 0;
            this.DgvAllAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllAuthors_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Authors";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All authors";
            // 
            // BtnNewAuthor
            // 
            this.BtnNewAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewAuthor.Location = new System.Drawing.Point(386, 62);
            this.BtnNewAuthor.Name = "BtnNewAuthor";
            this.BtnNewAuthor.Size = new System.Drawing.Size(137, 45);
            this.BtnNewAuthor.TabIndex = 2;
            this.BtnNewAuthor.Text = "New Author";
            this.BtnNewAuthor.UseVisualStyleBackColor = true;
            this.BtnNewAuthor.Click += new System.EventHandler(this.BtnNewAuthor_Click);
            // 
            // BtnDeleteAuthor
            // 
            this.BtnDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAuthor.Location = new System.Drawing.Point(161, 13);
            this.BtnDeleteAuthor.Name = "BtnDeleteAuthor";
            this.BtnDeleteAuthor.Size = new System.Drawing.Size(137, 28);
            this.BtnDeleteAuthor.TabIndex = 3;
            this.BtnDeleteAuthor.Text = "Delete";
            this.BtnDeleteAuthor.UseVisualStyleBackColor = true;
            this.BtnDeleteAuthor.Click += new System.EventHandler(this.BtnDeleteAuthor_Click);
            // 
            // BtnEditAuthor
            // 
            this.BtnEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditAuthor.Location = new System.Drawing.Point(161, 56);
            this.BtnEditAuthor.Name = "BtnEditAuthor";
            this.BtnEditAuthor.Size = new System.Drawing.Size(137, 29);
            this.BtnEditAuthor.TabIndex = 5;
            this.BtnEditAuthor.Text = "Edit";
            this.BtnEditAuthor.UseVisualStyleBackColor = true;
            this.BtnEditAuthor.Click += new System.EventHandler(this.BtnEditAuthor_Click);
            // 
            // PnlDeleteEdit
            // 
            this.PnlDeleteEdit.Controls.Add(this.LblErr);
            this.PnlDeleteEdit.Controls.Add(this.TxbAuthorEdit);
            this.PnlDeleteEdit.Controls.Add(this.BtnDeleteAuthor);
            this.PnlDeleteEdit.Controls.Add(this.BtnEditAuthor);
            this.PnlDeleteEdit.Location = new System.Drawing.Point(225, 126);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(334, 112);
            this.PnlDeleteEdit.TabIndex = 6;
            // 
            // LblErr
            // 
            this.LblErr.AutoSize = true;
            this.LblErr.ForeColor = System.Drawing.Color.Red;
            this.LblErr.Location = new System.Drawing.Point(13, 90);
            this.LblErr.Name = "LblErr";
            this.LblErr.Size = new System.Drawing.Size(96, 13);
            this.LblErr.TabIndex = 7;
            this.LblErr.Text = "* Please fill the row";
            this.LblErr.Visible = false;
            // 
            // TxbAuthorEdit
            // 
            this.TxbAuthorEdit.Location = new System.Drawing.Point(13, 63);
            this.TxbAuthorEdit.Name = "TxbAuthorEdit";
            this.TxbAuthorEdit.Size = new System.Drawing.Size(142, 20);
            this.TxbAuthorEdit.TabIndex = 6;
            // 
            // PnlNewAuthor
            // 
            this.PnlNewAuthor.Controls.Add(this.LblErr1);
            this.PnlNewAuthor.Controls.Add(this.BtnCreateAuthor);
            this.PnlNewAuthor.Controls.Add(this.TxbNewAuthor);
            this.PnlNewAuthor.Controls.Add(this.label2);
            this.PnlNewAuthor.Location = new System.Drawing.Point(565, 52);
            this.PnlNewAuthor.Name = "PnlNewAuthor";
            this.PnlNewAuthor.Size = new System.Drawing.Size(204, 157);
            this.PnlNewAuthor.TabIndex = 7;
            // 
            // LblErr1
            // 
            this.LblErr1.AutoSize = true;
            this.LblErr1.ForeColor = System.Drawing.Color.Red;
            this.LblErr1.Location = new System.Drawing.Point(24, 58);
            this.LblErr1.Name = "LblErr1";
            this.LblErr1.Size = new System.Drawing.Size(96, 13);
            this.LblErr1.TabIndex = 8;
            this.LblErr1.Text = "* Please fill the row";
            this.LblErr1.Visible = false;
            // 
            // BtnCreateAuthor
            // 
            this.BtnCreateAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateAuthor.Location = new System.Drawing.Point(27, 86);
            this.BtnCreateAuthor.Name = "BtnCreateAuthor";
            this.BtnCreateAuthor.Size = new System.Drawing.Size(133, 29);
            this.BtnCreateAuthor.TabIndex = 6;
            this.BtnCreateAuthor.Text = "Add";
            this.BtnCreateAuthor.UseVisualStyleBackColor = true;
            this.BtnCreateAuthor.Click += new System.EventHandler(this.BtnCreateAuthor_Click);
            // 
            // TxbNewAuthor
            // 
            this.TxbNewAuthor.Location = new System.Drawing.Point(27, 35);
            this.TxbNewAuthor.Name = "TxbNewAuthor";
            this.TxbNewAuthor.Size = new System.Drawing.Size(133, 20);
            this.TxbNewAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Author";
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlNewAuthor);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.BtnNewAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvAllAuthors);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllAuthors)).EndInit();
            this.PnlDeleteEdit.ResumeLayout(false);
            this.PnlDeleteEdit.PerformLayout();
            this.PnlNewAuthor.ResumeLayout(false);
            this.PnlNewAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAllAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNewAuthor;
        private System.Windows.Forms.Button BtnDeleteAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnEditAuthor;
        private System.Windows.Forms.Panel PnlDeleteEdit;
        private System.Windows.Forms.TextBox TxbAuthorEdit;
        private System.Windows.Forms.Panel PnlNewAuthor;
        private System.Windows.Forms.Button BtnCreateAuthor;
        private System.Windows.Forms.TextBox TxbNewAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblErr;
        private System.Windows.Forms.Label LblErr1;
    }
}