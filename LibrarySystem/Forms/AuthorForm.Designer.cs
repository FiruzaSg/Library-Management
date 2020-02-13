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
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnUpdateAuthor = new System.Windows.Forms.Button();
            this.PnlDeleteEdit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllAuthors)).BeginInit();
            this.PnlDeleteEdit.SuspendLayout();
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
            this.DgvAllAuthors.Size = new System.Drawing.Size(166, 287);
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
            this.BtnNewAuthor.Location = new System.Drawing.Point(359, 62);
            this.BtnNewAuthor.Name = "BtnNewAuthor";
            this.BtnNewAuthor.Size = new System.Drawing.Size(148, 45);
            this.BtnNewAuthor.TabIndex = 2;
            this.BtnNewAuthor.Text = "New author";
            this.BtnNewAuthor.UseVisualStyleBackColor = true;
            this.BtnNewAuthor.Click += new System.EventHandler(this.BtnNewAuthor_Click);
            // 
            // BtnDeleteAuthor
            // 
            this.BtnDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAuthor.Location = new System.Drawing.Point(25, 10);
            this.BtnDeleteAuthor.Name = "BtnDeleteAuthor";
            this.BtnDeleteAuthor.Size = new System.Drawing.Size(148, 45);
            this.BtnDeleteAuthor.TabIndex = 3;
            this.BtnDeleteAuthor.Text = "Delete";
            this.BtnDeleteAuthor.UseVisualStyleBackColor = true;
            this.BtnDeleteAuthor.Click += new System.EventHandler(this.BtnDeleteAuthor_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRefresh.Location = new System.Drawing.Point(198, 62);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(53, 20);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnUpdateAuthor
            // 
            this.BtnUpdateAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateAuthor.Location = new System.Drawing.Point(25, 75);
            this.BtnUpdateAuthor.Name = "BtnUpdateAuthor";
            this.BtnUpdateAuthor.Size = new System.Drawing.Size(148, 45);
            this.BtnUpdateAuthor.TabIndex = 5;
            this.BtnUpdateAuthor.Text = "Update";
            this.BtnUpdateAuthor.UseVisualStyleBackColor = true;
            // 
            // PnlDeleteEdit
            // 
            this.PnlDeleteEdit.Controls.Add(this.BtnDeleteAuthor);
            this.PnlDeleteEdit.Controls.Add(this.BtnUpdateAuthor);
            this.PnlDeleteEdit.Location = new System.Drawing.Point(334, 113);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(204, 142);
            this.PnlDeleteEdit.TabIndex = 6;
            this.PnlDeleteEdit.Visible = false;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 409);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnNewAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvAllAuthors);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllAuthors)).EndInit();
            this.PnlDeleteEdit.ResumeLayout(false);
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
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnUpdateAuthor;
        private System.Windows.Forms.Panel PnlDeleteEdit;
    }
}