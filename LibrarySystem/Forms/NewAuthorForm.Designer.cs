namespace LibrarySystem.Forms
{
    partial class NewAuthorForm
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
            this.TxbNewAuthor = new System.Windows.Forms.TextBox();
            this.BtnNewAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Author";
            // 
            // TxbNewAuthor
            // 
            this.TxbNewAuthor.Location = new System.Drawing.Point(33, 53);
            this.TxbNewAuthor.Name = "TxbNewAuthor";
            this.TxbNewAuthor.Size = new System.Drawing.Size(116, 20);
            this.TxbNewAuthor.TabIndex = 1;
            // 
            // BtnNewAuthor
            // 
            this.BtnNewAuthor.Location = new System.Drawing.Point(33, 88);
            this.BtnNewAuthor.Name = "BtnNewAuthor";
            this.BtnNewAuthor.Size = new System.Drawing.Size(116, 23);
            this.BtnNewAuthor.TabIndex = 2;
            this.BtnNewAuthor.Text = "Submit";
            this.BtnNewAuthor.UseVisualStyleBackColor = true;
            this.BtnNewAuthor.Click += new System.EventHandler(this.BtnNewAuthor_Click);
            // 
            // NewAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 148);
            this.Controls.Add(this.BtnNewAuthor);
            this.Controls.Add(this.TxbNewAuthor);
            this.Controls.Add(this.label1);
            this.Name = "NewAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNewAuthor;
        private System.Windows.Forms.Button BtnNewAuthor;
    }
}