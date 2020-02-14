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
    public partial class GenreForm : Form
    {
        private readonly LibraryDbContext _context;
        private  Genre _selectedGenre; 
        public GenreForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillGenres();
        }

        #region Fill and Clear Methods
        private void FillGenres()
        {
            var Genres = _context.Genres.ToList();

            foreach (var item in Genres)
            {
                DgvAllGenres.Rows.Add(item.Id,
                                     item.Name);

            }
        }

        private void ClearGenres()
        {
            var Genres = _context.Genres.ToList();

            foreach (var item in Genres)
            {
                DgvAllGenres.Rows.Clear();

            }
        }
        #endregion

        //Create New Genre
        private void BtnNewGenre_Click(object sender, EventArgs e)
        {
            PnlDeleteEdit.Visible = false;
            NewGenreForm newGenreForm = new NewGenreForm();
            newGenreForm.ShowDialog();
        }
        private void DgvAllGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int id = Convert.ToInt32(DgvAllGenres.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedGenre = _context.Genres.Find(id);

            TxbEditGenre.Text = _selectedGenre.ToString();

        }

        //Delete Genre
        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(r == DialogResult.Yes)
            {
                _context.Genres.Remove(_selectedGenre);

                _context.SaveChanges();
                ClearGenres();
                FillGenres();
                
            }
            else if (r == DialogResult.No)
            {
                return;
            }

        }


        private void BtnEditGenre_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Are you sure?","Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            
            if (r == DialogResult.Yes)
            {
                _selectedGenre.Name = TxbEditGenre.Text;
                 
                _context.SaveChanges();
                ClearGenres();
                FillGenres();
                



            }
            if (r == DialogResult.No)
            {
                return;
            };
        }




        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearGenres();
            FillGenres();
        }
    }
}
