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
    public partial class NewGenreForm : Form
    {
        private readonly LibraryDbContext _context;
        public NewGenreForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
        }

        private void BtnNewGenre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbNewGenre.Text))
            {
                MessageBox.Show("Please enter genre", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Genre genre = new Genre
            {
                Name = TxbNewGenre.Text
            };


            _context.Genres.Add(genre);
            _context.SaveChanges();

            this.Close();
          
        }

      
        
    }
}
