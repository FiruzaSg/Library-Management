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
    public partial class BookForm : Form
    {
        private readonly LibraryDbContext _context;
        private Book _selectedBook;
        public BookForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
            ClearBooks();
            FillBooks();
            FillEditComboboxes();
            FillComboboxes();
          

        }

        #region Fill Methods

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

        public void ClearBooks()
        {
            DgvAllBooks.Rows.Clear();
        }

        public void FillEditComboboxes()
        {
            List<Author> authors = _context.Authors.ToList();

            CmbEditAuthors.Items.Clear();
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
            CmbEditGenres.Items.Clear();
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
            PnlDeleteEdit.Visible = false;
            PnlCreateBook.Visible = true;
            FillEditComboboxes();
            
        }


        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenreForm genreForm = new GenreForm();
            genreForm.ShowDialog();
            this.Close();

        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.ShowDialog();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(_selectedBook == null)
            {
                MessageBox.Show("Please select book", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _context.Books.Remove(_selectedBook);

                _context.SaveChanges();
                DgvAllBooks.Rows.Clear(); 
                FillBooks();  
            }
            else if (r == DialogResult.No)
            {
                return;
            }
            ClearTxb();

        }

        private void DgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvAllBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedBook = _context.Books.Find(id);

            PnlDeleteEdit.Visible = true;
            PnlCreateBook.Visible = false;



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
            if (_selectedBook == null)
            {
                MessageBox.Show("Please select book", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxbEditTitle.Text) || CmbEditAuthors.SelectedItem == null || CmbEditGenres.SelectedItem == null || string.IsNullOrEmpty(TxbPrice.Text))
            {
                LblErr1.Visible = true;
                return;
            }
            LblErr1.Visible = false;

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

                ClearTxb();
                ClearBooks();
                FillBooks();
                FillComboboxes();


            }
            if(r == DialogResult.No)
            {
                return;
            }
 
        }

        public void ClearTxb()
        {
            TxbEditTitle.Clear();
            TxbBookTitle.Text = "";
            TxbPrice.Clear();
            TxbBookPrice.Clear();
            CmbEditAuthors.Text = "";
            CmbEditGenres.Text = "";
            NupBookCount.Value = 1;
            NupCount.Value = 1;
        }

        public void FillComboboxes()
        {
            List<Author> authors = _context.Authors.ToList();

            CmbAuthor.Items.Clear();
            foreach (var item in authors)
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    Text = item.Fullname,
                    Value = item.Id
                };
                CmbAuthor.Items.Add(comboboxItem);

            }


            List<Genre> genres = _context.Genres.ToList();

            CmbGenre.Items.Clear();
            foreach (var item in genres)
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    Text = item.Name,
                    Value = item.Id
                };
                CmbGenre.Items.Add(comboboxItem);

            }
        }

        private void BtnAddBook_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbBookTitle.Text) ||
                CmbAuthor.SelectedItem == null ||
                CmbGenre.SelectedItem == null ||
                string.IsNullOrEmpty(TxbBookPrice.Text))
            {
                LblErr.Visible = true;
                return;
            }

            LblErr.Visible = false;

            ComboboxItem selectedAuthor = CmbAuthor.SelectedItem as ComboboxItem;
            ComboboxItem selectedGenre = CmbGenre.SelectedItem as ComboboxItem;
            
            Book book = new Book
            {
                Name = TxbBookTitle.Text,
                AuthorId = selectedAuthor.Value,
                GenreId = selectedGenre.Value,
                PublishedDate = Convert.ToDateTime(DtpPublish.Text),
                Price = Convert.ToDecimal(TxbBookPrice.Text),
                Count = Convert.ToInt32(NupCount.Value)

            };

            _context.Books.Add(book);
            _context.SaveChanges();
            ClearBooks(); FillBooks();
            PnlCreateBook.Visible = false;
            PnlDeleteEdit.Visible = true;
            ClearTxb();
        }



      

        private void button1_Click(object sender, EventArgs e)
        {
            PnlCreateBook.Visible = false;
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
