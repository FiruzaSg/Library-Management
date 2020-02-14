namespace LibrarySystem.Forms
{
    partial class AddBookForm
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblGenre = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.TxbBookTitle = new System.Windows.Forms.TextBox();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.CmbAuthor = new System.Windows.Forms.ComboBox();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpPublish = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NupBookCount = new System.Windows.Forms.NumericUpDown();
            this.TxbBookPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(78, 46);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Location = new System.Drawing.Point(77, 138);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(36, 13);
            this.LblGenre.TabIndex = 1;
            this.LblGenre.Text = "Genre";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(75, 92);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 2;
            this.LblAuthor.Text = "Author";
            // 
            // TxbBookTitle
            // 
            this.TxbBookTitle.Location = new System.Drawing.Point(127, 43);
            this.TxbBookTitle.Name = "TxbBookTitle";
            this.TxbBookTitle.Size = new System.Drawing.Size(139, 20);
            this.TxbBookTitle.TabIndex = 3;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(306, 125);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(139, 39);
            this.BtnAddBook.TabIndex = 6;
            this.BtnAddBook.Text = "Add";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // CmbAuthor
            // 
            this.CmbAuthor.FormattingEnabled = true;
            this.CmbAuthor.Location = new System.Drawing.Point(127, 89);
            this.CmbAuthor.Name = "CmbAuthor";
            this.CmbAuthor.Size = new System.Drawing.Size(139, 21);
            this.CmbAuthor.TabIndex = 7;
            // 
            // CmbGenre
            // 
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(127, 135);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(139, 21);
            this.CmbGenre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Published at";
            // 
            // DtpPublish
            // 
            this.DtpPublish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPublish.Location = new System.Drawing.Point(127, 175);
            this.DtpPublish.Name = "DtpPublish";
            this.DtpPublish.Size = new System.Drawing.Size(139, 20);
            this.DtpPublish.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // NupBookCount
            // 
            this.NupBookCount.Location = new System.Drawing.Point(127, 265);
            this.NupBookCount.Name = "NupBookCount";
            this.NupBookCount.Size = new System.Drawing.Size(139, 20);
            this.NupBookCount.TabIndex = 17;
            // 
            // TxbBookPrice
            // 
            this.TxbBookPrice.Location = new System.Drawing.Point(127, 222);
            this.TxbBookPrice.Name = "TxbBookPrice";
            this.TxbBookPrice.Size = new System.Drawing.Size(139, 20);
            this.TxbBookPrice.TabIndex = 15;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 332);
            this.Controls.Add(this.NupBookCount);
            this.Controls.Add(this.TxbBookPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpPublish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.CmbAuthor);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.TxbBookTitle);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.LblTitle);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.TextBox TxbBookTitle;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.ComboBox CmbAuthor;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpPublish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NupBookCount;
        private System.Windows.Forms.TextBox TxbBookPrice;
    }
}