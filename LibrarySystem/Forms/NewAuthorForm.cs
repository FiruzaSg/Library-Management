using LibrarySystem.Data;
using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Forms
{
    public partial class NewAuthorForm : Form
    {
        private readonly LibraryDbContext _context;
        public NewAuthorForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void BtnNewAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbNewAuthor.Text))
            {
                MessageBox.Show("Please enter author", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Author author = new Author
            {
                Fullname = TxbNewAuthor.Text
            };


            _context.Authors.Add(author);
            _context.SaveChanges();

            this.Close();

        
        }
    }
}
