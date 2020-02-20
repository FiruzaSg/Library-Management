namespace LibrarySystem.Forms
{
    partial class BookForm
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
            this.LblErr1 = new System.Windows.Forms.Label();
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
            this.PnlCreateBook = new System.Windows.Forms.Panel();
            this.LblErr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NupCount = new System.Windows.Forms.NumericUpDown();
            this.TxbBookPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpPublish = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.CmbAuthor = new System.Windows.Forms.ComboBox();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.TxbBookTitle = new System.Windows.Forms.TextBox();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblGenre = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PnlDeleteEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).BeginInit();
            this.PnlCreateBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupCount)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateBook
            // 
            this.BtnCreateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateBook.Location = new System.Drawing.Point(693, 135);
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
            this.BtnEditBook.Location = new System.Drawing.Point(488, 71);
            this.BtnEditBook.Name = "BtnEditBook";
            this.BtnEditBook.Size = new System.Drawing.Size(159, 36);
            this.BtnEditBook.TabIndex = 2;
            this.BtnEditBook.Text = "Edit";
            this.BtnEditBook.UseVisualStyleBackColor = true;
            this.BtnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(488, 26);
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
            this.PnlDeleteEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PnlDeleteEdit.Controls.Add(this.LblErr1);
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
            this.PnlDeleteEdit.Location = new System.Drawing.Point(693, 219);
            this.PnlDeleteEdit.Name = "PnlDeleteEdit";
            this.PnlDeleteEdit.Size = new System.Drawing.Size(665, 158);
            this.PnlDeleteEdit.TabIndex = 6;
            // 
            // LblErr1
            // 
            this.LblErr1.AutoSize = true;
            this.LblErr1.ForeColor = System.Drawing.Color.Red;
            this.LblErr1.Location = new System.Drawing.Point(14, 129);
            this.LblErr1.Name = "LblErr1";
            this.LblErr1.Size = new System.Drawing.Size(101, 13);
            this.LblErr1.TabIndex = 30;
            this.LblErr1.Text = "* Please fill the rows";
            this.LblErr1.Visible = false;
            // 
            // NupBookCount
            // 
            this.NupBookCount.Location = new System.Drawing.Point(321, 87);
            this.NupBookCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NupBookCount.Name = "NupBookCount";
            this.NupBookCount.ReadOnly = true;
            this.NupBookCount.Size = new System.Drawing.Size(141, 20);
            this.NupBookCount.TabIndex = 6;
            this.NupBookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DtpPublishDate
            // 
            this.DtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPublishDate.Location = new System.Drawing.Point(6, 87);
            this.DtpPublishDate.Name = "DtpPublishDate";
            this.DtpPublishDate.Size = new System.Drawing.Size(141, 20);
            this.DtpPublishDate.TabIndex = 4;
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
            this.TxbPrice.TabIndex = 5;
            // 
            // TxbEditTitle
            // 
            this.TxbEditTitle.Location = new System.Drawing.Point(6, 26);
            this.TxbEditTitle.Name = "TxbEditTitle";
            this.TxbEditTitle.Size = new System.Drawing.Size(141, 20);
            this.TxbEditTitle.TabIndex = 1;
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
            this.CmbEditAuthors.TabIndex = 3;
            // 
            // CmbEditGenres
            // 
            this.CmbEditGenres.FormattingEnabled = true;
            this.CmbEditGenres.Location = new System.Drawing.Point(163, 25);
            this.CmbEditGenres.Name = "CmbEditGenres";
            this.CmbEditGenres.Size = new System.Drawing.Size(141, 21);
            this.CmbEditGenres.TabIndex = 2;
            // 
            // PnlCreateBook
            // 
            this.PnlCreateBook.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PnlCreateBook.Controls.Add(this.LblErr);
            this.PnlCreateBook.Controls.Add(this.button1);
            this.PnlCreateBook.Controls.Add(this.NupCount);
            this.PnlCreateBook.Controls.Add(this.TxbBookPrice);
            this.PnlCreateBook.Controls.Add(this.label7);
            this.PnlCreateBook.Controls.Add(this.label8);
            this.PnlCreateBook.Controls.Add(this.DtpPublish);
            this.PnlCreateBook.Controls.Add(this.label9);
            this.PnlCreateBook.Controls.Add(this.CmbGenre);
            this.PnlCreateBook.Controls.Add(this.CmbAuthor);
            this.PnlCreateBook.Controls.Add(this.BtnAddBook);
            this.PnlCreateBook.Controls.Add(this.TxbBookTitle);
            this.PnlCreateBook.Controls.Add(this.LblAuthor);
            this.PnlCreateBook.Controls.Add(this.LblGenre);
            this.PnlCreateBook.Controls.Add(this.LblTitle);
            this.PnlCreateBook.Location = new System.Drawing.Point(686, 200);
            this.PnlCreateBook.Name = "PnlCreateBook";
            this.PnlCreateBook.Size = new System.Drawing.Size(489, 188);
            this.PnlCreateBook.TabIndex = 8;
            this.PnlCreateBook.Visible = false;
            // 
            // LblErr
            // 
            this.LblErr.AutoSize = true;
            this.LblErr.ForeColor = System.Drawing.Color.Red;
            this.LblErr.Location = new System.Drawing.Point(95, 144);
            this.LblErr.Name = "LblErr";
            this.LblErr.Size = new System.Drawing.Size(101, 13);
            this.LblErr.TabIndex = 29;
            this.LblErr.Text = "* Please fill the rows";
            this.LblErr.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NupCount
            // 
            this.NupCount.Location = new System.Drawing.Point(310, 103);
            this.NupCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NupCount.Name = "NupCount";
            this.NupCount.ReadOnly = true;
            this.NupCount.Size = new System.Drawing.Size(139, 20);
            this.NupCount.TabIndex = 6;
            this.NupCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxbBookPrice
            // 
            this.TxbBookPrice.Location = new System.Drawing.Point(310, 66);
            this.TxbBookPrice.Name = "TxbBookPrice";
            this.TxbBookPrice.Size = new System.Drawing.Size(139, 20);
            this.TxbBookPrice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Count";
            // 
            // DtpPublish
            // 
            this.DtpPublish.CustomFormat = "";
            this.DtpPublish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPublish.Location = new System.Drawing.Point(93, 107);
            this.DtpPublish.Name = "DtpPublish";
            this.DtpPublish.Size = new System.Drawing.Size(139, 20);
            this.DtpPublish.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Published at";
            // 
            // CmbGenre
            // 
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(93, 70);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(139, 21);
            this.CmbGenre.TabIndex = 3;
            // 
            // CmbAuthor
            // 
            this.CmbAuthor.FormattingEnabled = true;
            this.CmbAuthor.Location = new System.Drawing.Point(310, 33);
            this.CmbAuthor.Name = "CmbAuthor";
            this.CmbAuthor.Size = new System.Drawing.Size(139, 21);
            this.CmbAuthor.TabIndex = 2;
            this.CmbAuthor.Tag = "Select author";
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(310, 144);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(139, 39);
            this.BtnAddBook.TabIndex = 22;
            this.BtnAddBook.Text = "Add";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click_1);
            // 
            // TxbBookTitle
            // 
            this.TxbBookTitle.Location = new System.Drawing.Point(93, 34);
            this.TxbBookTitle.Name = "TxbBookTitle";
            this.TxbBookTitle.Size = new System.Drawing.Size(139, 20);
            this.TxbBookTitle.TabIndex = 1;
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(266, 36);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 20;
            this.LblAuthor.Text = "Author";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Location = new System.Drawing.Point(51, 73);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(36, 13);
            this.LblGenre.TabIndex = 19;
            this.LblGenre.Text = "Genre";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(60, 37);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 18;
            this.LblTitle.Text = "Title";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 515);
            this.Controls.Add(this.PnlCreateBook);
            this.Controls.Add(this.PnlDeleteEdit);
            this.Controls.Add(this.DgvAllBooks);
            this.Controls.Add(this.BtnCreateBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlDeleteEdit.ResumeLayout(false);
            this.PnlDeleteEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).EndInit();
            this.PnlCreateBook.ResumeLayout(false);
            this.PnlCreateBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupCount)).EndInit();
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
        private System.Windows.Forms.Panel PnlCreateBook;
        private System.Windows.Forms.NumericUpDown NupCount;
        private System.Windows.Forms.TextBox TxbBookPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpPublish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.ComboBox CmbAuthor;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.TextBox TxbBookTitle;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblErr;
        private System.Windows.Forms.Label LblErr1;
    }
}