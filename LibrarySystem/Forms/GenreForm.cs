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
            PnlDeleteEdit.Visible = true;
            PnlNewGenre.Visible = false;
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
            PnlNewGenre.Visible = true;
        }
       
        
        private void DgvAllGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (_selectedGenre == null)
            //{
            //    MessageBox.Show("Please select genre", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}

            int id = Convert.ToInt32(DgvAllGenres.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            _selectedGenre = _context.Genres.Find(id);

            TxbEditGenre.Text = _selectedGenre.ToString();
            PnlDeleteEdit.Visible = true;
            PnlNewGenre.Visible = false;

        }

        //Delete Genre
        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (_selectedGenre == null)
            {
                MessageBox.Show("Please select genre", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            TxbEditGenre.Clear();
        }


        private void BtnEditGenre_Click(object sender, EventArgs e)
        {
            if(_selectedGenre == null)
            {
                MessageBox.Show("Please select genre", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxbEditGenre.Text))
            {
                LblErr.Visible = true;
                return;
            }
            LblErr.Visible = false;
            DialogResult r = MessageBox.Show("Are you sure?","Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            

            if (r == DialogResult.Yes)
            {
                
                _selectedGenre.Name = TxbEditGenre.Text;
                 
                _context.SaveChanges();
                ClearGenres();
                FillGenres();
                TxbEditGenre.Clear();
                
            }
            if (r == DialogResult.No)
            {
                return;
            };
            TxbEditGenre.Clear();
        }




        private void BtnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbNewGenre.Text))
            {
                LblErr1.Visible = true;
                return;
            }
            LblErr1.Visible = false;
            Genre genre = new Genre
            {
                Name = TxbNewGenre.Text
            };


            _context.Genres.Add(genre);
            _context.SaveChanges();
            PnlNewGenre.Visible = false;
            ClearGenres();
            FillGenres();
            TxbNewGenre.Clear();
        }
    }
}
