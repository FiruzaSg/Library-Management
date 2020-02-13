using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Data;
using LibrarySystem.Models;

namespace LibrarySystem.Forms
{
    public partial class AddBookForm : Form
    {
        private readonly LibraryDbContext _context;
        public AddBookForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillComboboxes();
           
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbBookTitle.Text))
            {
                MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CmbAuthor.SelectedItem == null)
            {
                MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CmbGenre.SelectedItem == null)
            {
                MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxbBookTitle.Text) || CmbAuthor.SelectedItem == null || CmbGenre.SelectedItem == null)
            {
                return;
            }

            ComboboxItem selectedAuthor = CmbAuthor.SelectedItem as ComboboxItem;
            ComboboxItem selectedGenre = CmbGenre.SelectedItem as ComboboxItem;
            Book book = new Book
            {
                Name = TxbBookTitle.Text,
                AuthorId = selectedAuthor.Value,
                GenreId = selectedGenre.Value
            };

            _context.Books.Add(book);
            _context.SaveChanges();

            this.Close();
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

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

      

        private void BtnNewAuthor_Click_1(object sender, EventArgs e)
        {
            NewAuthorForm newAuthorForm = new NewAuthorForm();
         
            newAuthorForm.ShowDialog();


        }

        
        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
