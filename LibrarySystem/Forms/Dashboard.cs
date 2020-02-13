using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Forms;

namespace LibrarySystem.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void BtnBookForm_Click(object sender, EventArgs e)
        {
            BooksForm createBook = new BooksForm();
            createBook.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();

            userForm.ShowDialog();


        }
    }
}
