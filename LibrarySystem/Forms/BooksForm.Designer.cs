namespace LibrarySystem.Forms
{
    partial class BooksForm
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
            this.BtnCreateBook = new System.Windows.Forms.Button();
            this.BtnEditBook = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvAllBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlDeleteEdit = new System.Windows.Forms.Panel();
            this.NupBookCount = new System.Windows.Forms.NumericUpDown();
            this.DtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbPrice = new System.Windows.Forms.TextBox();
            this.TxbEditTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbEditAuthors = new System.Windows.Forms.ComboBox();
            this.CmbEditGenres = new System.Windows.Forms.ComboBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PnlDeleteEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateBook
            // 
            this.BtnCreateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateBook.Location = new System.Drawing.Point(693, 163);
            this.BtnCreateBook.Name = "BtnCreateBook";
            this.BtnCreateBook.Size = new System.Drawing.Size(160, 46);
            this.BtnCreateBook.TabIndex = 1;
            this.BtnCreateBook.Text = "New book";
            this.BtnCreateBook.UseVisualStyleBackColor = true;
            this.BtnCreateBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnEditBook
            // 
            this.BtnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBook.Location = new System.Drawing.Point(481, 26);
            this.BtnEditBook.Name = "BtnEditBook";
            this.BtnEditBook.Size = new System.Drawing.Size(159, 39);
            this.BtnEditBook.TabIndex = 2;
            this.BtnEditBook.Text = "Edit";
            this.BtnEditBook.UseVisualStyleBackColor = true;
            this.BtnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(481, 71);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(159, 36);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvAllBooks
            // 
            this.DgvAllBooks.AllowUserToAddRows = false;
            this.DgvAllBooks.AllowUserToDeleteRows = false;
            this.DgvAllBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.DgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAllBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvAllBooks.Location = new System.Drawing.Point(12, 135);
            this.DgvAllBooks.Name = "DgvAllBooks";
            this.DgvAllBooks.ReadOnly = true;
            this.DgvAllBooks.Size = new System.Drawing.Size(653, 335);
            this.DgvAllBooks.TabIndex = 4;
            this.DgvAllBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllBooks_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Published at";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Count";
            this.Column7.MaxInputLength = 32500;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genresToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.genresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.authorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // PnlDeleteEdit
            // 
            this.PnlDeleteEdit.Controls.Add(this.NupBookCount);
            this.PnlDeleteEdit.Controls.Add(this.DtpPublishDate);
            this.PnlDeleteEdit.Controls.Add(this.label6);
            this.PnlDeleteEdit.Controls.Add(this.label5);
            this.PnlDeleteEdit.Controls.Add(this.label4);
            this.PnlDeleteEdit.Controls.Add(this.TxbPrice);
            this.PnlDeleteEdit.Controls.Add(this.BtnDelete);
            this.PnlDeleteEdit.Controls.Add(this.TxbEditTitle);
            this.PnlDeleteEdit.Controls.Add(this.BtnEditBook);
            this.PnlDeleteEdit.Controls.Add(this.label3);
            this.PnlDeleteEdit.Controls.Add(this.label1);
            this.PnlDeleteEdit.Controls.Add(this.label2);
            this.PnlDeleteEdit.Controls.Add(this.CmbEditAuthors);
            this.PnlDeleteEdit.Controls.Add(this.CmbEditGenres);
            this.PnlDeleteEdit.Location = new System.Drawing.Point(693, 256);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(665, 138);
            this.PnlDeleteEdit.TabIndex = 6;
            // 
            // NupBookCount
            // 
            this.NupBookCount.Location = new System.Drawing.Point(321, 87);
            this.NupBookCount.Name = "NupBookCount";
            this.NupBookCount.Size = new System.Drawing.Size(141, 20);
            this.NupBookCount.TabIndex = 19;
            // 
            // DtpPublishDate
            // 
            this.DtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPublishDate.Location = new System.Drawing.Point(6, 87);
            this.DtpPublishDate.Name = "DtpPublishDate";
            this.DtpPublishDate.Size = new System.Drawing.Size(141, 20);
            this.DtpPublishDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Count";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Publication date";
            // 
            // TxbPrice
            // 
            this.TxbPrice.Location = new System.Drawing.Point(163, 87);
            this.TxbPrice.Name = "TxbPrice";
            this.TxbPrice.Size = new System.Drawing.Size(141, 20);
            this.TxbPrice.TabIndex = 13;
            // 
            // TxbEditTitle
            // 
            this.TxbEditTitle.Location = new System.Drawing.Point(6, 26);
            this.TxbEditTitle.Name = "TxbEditTitle";
            this.TxbEditTitle.Size = new System.Drawing.Size(141, 20);
            this.TxbEditTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Author";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genre";
            // 
            // CmbEditAuthors
            // 
            this.CmbEditAuthors.FormattingEnabled = true;
            this.CmbEditAuthors.Location = new System.Drawing.Point(321, 25);
            this.CmbEditAuthors.Name = "CmbEditAuthors";
            this.CmbEditAuthors.Size = new System.Drawing.Size(141, 21);
            this.CmbEditAuthors.TabIndex = 11;
            // 
            // CmbEditGenres
            // 
            this.CmbEditGenres.FormattingEnabled = true;
            this.CmbEditGenres.Location = new System.Drawing.Point(163, 25);
            this.CmbEditGenres.Name = "CmbEditGenres";
            this.CmbEditGenres.Size = new System.Drawing.Size(141, 21);
            this.CmbEditGenres.TabIndex = 10;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(694, 137);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(60, 20);
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 515);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.DgvAllBooks);
            this.Controls.Add(this.BtnCreateBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlDeleteEdit.ResumeLayout(false);
            this.PnlDeleteEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCreateBook;
        private System.Windows.Forms.Button BtnEditBook;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgvAllBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Panel PnlDeleteEdit;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbEditTitle;
        private System.Windows.Forms.ComboBox CmbEditAuthors;
        private System.Windows.Forms.ComboBox CmbEditGenres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbPrice;
        private System.Windows.Forms.DateTimePicker DtpPublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.NumericUpDown NupBookCount;
    }
}