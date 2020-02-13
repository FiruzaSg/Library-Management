using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Models;
using LibrarySystem.Data;

namespace LibrarySystem.Forms
{
    public partial class BooksForm : Form
    {
        private readonly LibraryDbContext _context;
        private Book _selectedBook;
        public BooksForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent(); 
            FillBooks();

        }

        #region Fill and Clear Methods

        private void FillBooks()
        {
            var Books = _context.Books
                                        .Include("Author")
                                        .Include("Genre")
                                        .ToList();

            foreach (var item in Books)
            {
                DgvAllBooks.Rows.Add(item.Id,
                                     item.Name,
                                     item.Genre.Name,
                                     item.Author.Fullname
                                     );

            }
        }

        private void ClearBooks()
        {
            var Books = _context.Books.ToList();

            foreach (var item in Books)
            {
                DgvAllBooks.Rows.Clear();

            }
        }
        #endregion

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            PnlDeleteEdit.Visible = false;
            AddBookForm addbookform = new AddBookForm();

            addbookform.ShowDialog();
            
        }
        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenreForm genreForm = new GenreForm();
            genreForm.ShowDialog();

        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _context.Books.Remove(_selectedBook);

                _context.SaveChanges();
                ClearBooks();
                FillBooks();
                PnlDeleteEdit.Visible = false;
            }
            else if (r == DialogResult.No)
            {
                return;
            }
        }

        private void DgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvAllBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedBook = _context.Books.Find(id);

            PnlDeleteEdit.Visible = true;
        }






        //private void BtnSearch_Click(object sender, EventArgs e)
        //{
        //    if(string.IsNullOrEmpty(TxbSearchTitle.Text) &&
        //        string.IsNullOrEmpty(TxbSearchGenre.Text) &&
        //        string.IsNullOrEmpty(TxbSearchAuthor.Text))
        //    {
        //        MessageBox.Show("Please fill at least one field","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //        return;
        //    }


        //}
    }
}
