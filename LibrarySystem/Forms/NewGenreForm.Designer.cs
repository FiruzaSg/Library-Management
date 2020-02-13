namespace LibrarySystem.Forms
{
    partial class NewGenreForm
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
            this.TxbNewGenre = new System.Windows.Forms.TextBox();
            this.BtnNewGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New genre";
            // 
            // TxbNewGenre
            // 
            this.TxbNewGenre.Location = new System.Drawing.Point(38, 55);
            this.TxbNewGenre.Name = "TxbNewGenre";
            this.TxbNewGenre.Size = new System.Drawing.Size(115, 20);
            this.TxbNewGenre.TabIndex = 1;
            // 
            // BtnNewGenre
            // 
            this.BtnNewGenre.Location = new System.Drawing.Point(38, 91);
            this.BtnNewGenre.Name = "BtnNewGenre";
            this.BtnNewGenre.Size = new System.Drawing.Size(115, 23);
            this.BtnNewGenre.TabIndex = 2;
            this.BtnNewGenre.Text = "Submit";
            this.BtnNewGenre.UseVisualStyleBackColor = true;
            this.BtnNewGenre.Click += new System.EventHandler(this.BtnNewGenre_Click);
            // 
            // NewGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 149);
            this.Controls.Add(this.BtnNewGenre);
            this.Controls.Add(this.TxbNewGenre);
            this.Controls.Add(this.label1);
            this.Name = "NewGenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewGenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNewGenre;
        private System.Windows.Forms.Button BtnNewGenre;
    }
}