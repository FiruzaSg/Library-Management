﻿using System;
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
    public partial class AuthorForm : Form
    {
        private readonly LibraryDbContext _context;
        private Author _selectedAuthor;
        public AuthorForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillAuthors();

        }

        #region Fill And Clear Methods
        private void FillAuthors()
        {

            var Authors = _context.Authors.ToList();

            foreach (var item in Authors)
            {
                DgvAllAuthors.Rows.Add(item.Id,
                                     item.Fullname);
            }
        }
        
        private void ClearAuthors()
        {
            var Authors = _context.Authors.ToList();

            foreach (var item in Authors)
            {
                DgvAllAuthors.Rows.Clear();

            }
        }
        #endregion


        //Create New Author
        private void BtnNewAuthor_Click(object sender, EventArgs e)
        {
            PnlDeleteEdit.Visible = false;
            NewAuthorForm newAuthorForm = new NewAuthorForm();
            newAuthorForm.ShowDialog();
        }

        //Delete Author
        private void BtnDeleteAuthor_Click(object sender, EventArgs e)
        {
           
            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _context.Authors.Remove(_selectedAuthor);

                _context.SaveChanges();
               
            }
            else if (r == DialogResult.No)
            {
                return;
            }

            ClearAuthors();
            FillAuthors();
            PnlDeleteEdit.Visible = false;
        }


        private void DgvAllAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PnlDeleteEdit.Visible = true;
           
            int id = Convert.ToInt32(DgvAllAuthors.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedAuthor = _context.Authors.Find(id);

        }





        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearAuthors();
            FillAuthors();
        }

      
    }
}
