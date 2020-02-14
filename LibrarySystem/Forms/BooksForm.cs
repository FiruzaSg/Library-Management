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
            FillComboboxes();

        }

        #region Fill and Clear Methods

        public void FillBooks()
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
                                     item.Author.Fullname,
                                     item.PublishedDate.Year,
                                     item.Price,
                                     item.Count
                                     );

            }
        }

        private void ClearBooks()
        {
            DgvAllBooks.Rows.Clear();

        }

        public void FillComboboxes()
        {
            List<Author> authors = _context.Authors.ToList();


            foreach (var item in authors)
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    Text = item.Fullname,
                    Value = item.Id
                };
                CmbEditAuthors.Items.Add(comboboxItem);

            }


            List<Genre> genres = _context.Genres.ToList();

            foreach (var item in genres)
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    Text = item.Name,
                    Value = item.Id
                };
                CmbEditGenres.Items.Add(comboboxItem);

            }
        }
        #endregion

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            
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

            //PnlDeleteEdit.Visible = true;



            TxbEditTitle.Text = _selectedBook.Name;
            CmbEditAuthors.Text = _selectedBook.Author.Fullname;
            CmbEditGenres.Text = _selectedBook.Genre.Name;
            DtpPublishDate.Text = _selectedBook.PublishedDate.ToString();
            TxbPrice.Text = _selectedBook.Price.ToString();
            NupBookCount.Text = _selectedBook.Count.ToString();



     
            


        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbEditTitle.Text))
            {
                MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (CmbEditAuthors.SelectedItem == null)
            //{
            //    MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (CmbEditGenres.SelectedItem == null)
            //{
            //    MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (string.IsNullOrEmpty(TxbEditTitle.Text) || CmbEditAuthors.SelectedItem == null || CmbEditGenres.SelectedItem == null)
            {
                return;
            }

            DialogResult r = MessageBox.Show("Are you sure?","Book editing",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(r == DialogResult.Yes)
            {
                ComboboxItem selectedAuthor = CmbEditAuthors.SelectedItem as ComboboxItem;
                ComboboxItem selectedGenre = CmbEditGenres.SelectedItem as ComboboxItem;

                Book book = _context.Books.Find(_selectedBook.Id);

                book.Name = TxbEditTitle.Text;
                book.GenreId = selectedGenre.Value;
                book.AuthorId = selectedAuthor.Value;
                book.PublishedDate = DtpPublishDate.Value;
                book.Price = Convert.ToDecimal(TxbPrice.Text);
                book.Count = Int32.Parse(NupBookCount.Text);

                _context.SaveChanges();

                ClearBooks();
                FillBooks();

            }
            if(r == DialogResult.No)
            {
                return;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearBooks();
            FillBooks();
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
