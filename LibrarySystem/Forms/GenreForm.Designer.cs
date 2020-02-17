namespace LibrarySystem.Forms
{
    partial class GenreForm
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
            this.BtnNewGenre = new System.Windows.Forms.Button();
            this.DgvAllGenres = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeleteGenre = new System.Windows.Forms.Button();
            this.BtnEditGenre = new System.Windows.Forms.Button();
            this.PnlDeleteEdit = new System.Windows.Forms.Panel();
            this.LblErr = new System.Windows.Forms.Label();
            this.TxbEditGenre = new System.Windows.Forms.TextBox();
            this.PnlNewGenre = new System.Windows.Forms.Panel();
            this.LblErr1 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxbNewGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllGenres)).BeginInit();
            this.PnlDeleteEdit.SuspendLayout();
            this.PnlNewGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewGenre
            // 
            this.BtnNewGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGenre.Location = new System.Drawing.Point(424, 74);
            this.BtnNewGenre.Name = "BtnNewGenre";
            this.BtnNewGenre.Size = new System.Drawing.Size(142, 46);
            this.BtnNewGenre.TabIndex = 0;
            this.BtnNewGenre.Text = "New Genre";
            this.BtnNewGenre.UseVisualStyleBackColor = true;
            this.BtnNewGenre.Click += new System.EventHandler(this.BtnNewGenre_Click);
            // 
            // DgvAllGenres
            // 
            this.DgvAllGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvAllGenres.Location = new System.Drawing.Point(46, 74);
            this.DgvAllGenres.Name = "DgvAllGenres";
            this.DgvAllGenres.Size = new System.Drawing.Size(191, 364);
            this.DgvAllGenres.TabIndex = 1;
            this.DgvAllGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllGenres_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Genres";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "All genres";
            // 
            // BtnDeleteGenre
            // 
            this.BtnDeleteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteGenre.Location = new System.Drawing.Point(181, 12);
            this.BtnDeleteGenre.Name = "BtnDeleteGenre";
            this.BtnDeleteGenre.Size = new System.Drawing.Size(142, 29);
            this.BtnDeleteGenre.TabIndex = 3;
            this.BtnDeleteGenre.Text = "Delete";
            this.BtnDeleteGenre.UseVisualStyleBackColor = true;
            this.BtnDeleteGenre.Click += new System.EventHandler(this.BtnDeleteGenre_Click);
            // 
            // BtnEditGenre
            // 
            this.BtnEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditGenre.Location = new System.Drawing.Point(181, 57);
            this.BtnEditGenre.Name = "BtnEditGenre";
            this.BtnEditGenre.Size = new System.Drawing.Size(142, 29);
            this.BtnEditGenre.TabIndex = 4;
            this.BtnEditGenre.Text = "Edit";
            this.BtnEditGenre.UseVisualStyleBackColor = true;
            this.BtnEditGenre.Click += new System.EventHandler(this.BtnEditGenre_Click);
            // 
            // PnlDeleteEdit
            // 
            this.PnlDeleteEdit.Controls.Add(this.LblErr);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditGenre);
            this.PnlDeleteEdit.Controls.Add(this.BtnDeleteGenre);
            this.PnlDeleteEdit.Controls.Add(this.BtnEditGenre);
            this.PnlDeleteEdit.Location = new System.Drawing.Point(243, 140);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(336, 111);
            this.PnlDeleteEdit.TabIndex = 7;
            // 
            // LblErr
            // 
            this.LblErr.AutoSize = true;
            this.LblErr.ForeColor = System.Drawing.Color.Red;
            this.LblErr.Location = new System.Drawing.Point(30, 87);
            this.LblErr.Name = "LblErr";
            this.LblErr.Size = new System.Drawing.Size(96, 13);
            this.LblErr.TabIndex = 8;
            this.LblErr.Text = "* Please fill the row";
            this.LblErr.Visible = false;
            // 
            // TxbEditGenre
            // 
            this.TxbEditGenre.Location = new System.Drawing.Point(33, 64);
            this.TxbEditGenre.Name = "TxbEditGenre";
            this.TxbEditGenre.Size = new System.Drawing.Size(142, 20);
            this.TxbEditGenre.TabIndex = 5;
            // 
            // PnlNewGenre
            // 
            this.PnlNewGenre.Controls.Add(this.LblErr1);
            this.PnlNewGenre.Controls.Add(this.BtnSubmit);
            this.PnlNewGenre.Controls.Add(this.TxbNewGenre);
            this.PnlNewGenre.Controls.Add(this.label2);
            this.PnlNewGenre.Location = new System.Drawing.Point(585, 74);
            this.PnlNewGenre.Name = "PnlNewGenre";
            this.PnlNewGenre.Size = new System.Drawing.Size(170, 128);
            this.PnlNewGenre.TabIndex = 8;
            // 
            // LblErr1
            // 
            this.LblErr1.AutoSize = true;
            this.LblErr1.ForeColor = System.Drawing.Color.Red;
            this.LblErr1.Location = new System.Drawing.Point(13, 56);
            this.LblErr1.Name = "LblErr1";
            this.LblErr1.Size = new System.Drawing.Size(96, 13);
            this.LblErr1.TabIndex = 9;
            this.LblErr1.Text = "* Please fill the row";
            this.LblErr1.Visible = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(16, 78);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(142, 32);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Add";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click_1);
            // 
            // TxbNewGenre
            // 
            this.TxbNewGenre.Location = new System.Drawing.Point(16, 33);
            this.TxbNewGenre.Name = "TxbNewGenre";
            this.TxbNewGenre.Size = new System.Drawing.Size(142, 20);
            this.TxbNewGenre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Genre";
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlNewGenre);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvAllGenres);
            this.Controls.Add(this.BtnNewGenre);
            this.Name = "GenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenreForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllGenres)).EndInit();
            this.PnlDeleteEdit.ResumeLayout(false);
            this.PnlDeleteEdit.PerformLayout();
            this.PnlNewGenre.ResumeLayout(false);
            this.PnlNewGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNewGenre;
        private System.Windows.Forms.DataGridView DgvAllGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDeleteGenre;
        private System.Windows.Forms.Button BtnEditGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel PnlDeleteEdit;
        private System.Windows.Forms.TextBox TxbEditGenre;
        private System.Windows.Forms.Panel PnlNewGenre;
        private System.Windows.Forms.TextBox TxbNewGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblErr;
        private System.Windows.Forms.Label LblErr1;
    }
}