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
using LibrarySystem.Data;
using LibrarySystem.Models;


namespace LibrarySystem.Forms
{
    

    public partial class Dashboard : Form
    {
        private readonly LibraryDbContext _context;
        public Dashboard()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillOrders();
        }

        private void FillOrders()
        {
            var Orders = _context.Orders.Include("Customer").Include("Book").ToList();

            foreach (var item in Orders)
            {
                DgvAllOrders.Rows.Add(item.Id,
                                      item.Customer.Name + " " + item.Customer.Surname,
                                      item.Book.Name,
                                      item.BookCount,
                                      item.TakenAt,
                                      item.Deadline, 
                                      
                                      item.FinePrice
                                     );

            }
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
