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
        private Order _selectedOrder;
        private Customer _selectedCustomer;
        private Book _selectedBook;
        public Dashboard()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
           
            FillOrders();
            FillCustomersSearch();
            FillBooksSearch();


    }

        #region Fill and Clear methods
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
        private void FillCustomersSearch()
        {
            var Customers = _context.Customers.ToList();

            foreach (var item in Customers)
            {
                DgvCustomersSearch.Rows.Add(item.Id,
                                         item.Name,
                                         item.Surname,
                                         item.Phone,
                                         item.Address,
                                         item.IdentityCardNo);
            }
        }

        public void FillBooksSearch()
        {

            var Books = _context.Books
                                        .Include("Author")
                                        .Include("Genre")
                                        .ToList();

            foreach (var item in Books)
            {
                DgvBookSearch.Rows.Add(item.Id,
                                     item.Name,
                                     item.Author.Fullname,
                                     item.Genre.Name,
                                     item.Price,
                                     item.Count
                                     );

            }
        }

        public void ClearBooks()
        {
            DgvBookSearch.Rows.Clear();
        }

        public void ClearOrders()
        {
            DgvAllOrders.Rows.Clear();
        }

       

        #endregion



        private void BtnBookForm_Click(object sender, EventArgs e)
        {
            BookForm createBook = new BookForm();
            createBook.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();

            userForm.ShowDialog();

            
        }

        private void DgvAllOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvAllOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedOrder = _context.Orders.Find(id);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerForm customersForm = new CustomerForm();
            customersForm.ShowDialog();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            PnlNewOrder.Visible = true;
            PnlAllOrders.Visible = false;
        }

        private void BtnAllOrders_Click(object sender, EventArgs e)
        {
            PnlAllOrders.Visible = true;
            PnlNewOrder.Visible = false;
        }

        private void BtnAddToCard_Click(object sender, EventArgs e)
        {

            if(_selectedCustomer == null ||
                _selectedBook == null)
            {
                MessageBox.Show("Please select customer and book","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            PnlOrderInfo.Visible = true;


            decimal price;
            price = NupBookCount.Value * (_selectedBook.Price);
            RtbTotalPrice.Text = price.ToString();
            TxbCustomerSearch.Clear();
            TxbBookSearch.Clear();
            
        }


        private void DgvCustomersSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvCustomersSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedCustomer = _context.Customers.Find(id);
        }
        private void DgvBookSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvBookSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedBook = _context.Books.Find(id);
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Order confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.No)
            {
                return;
                
            }
            Order order = new Order
            {
                CustomerId = _selectedCustomer.Id,
                BookId = _selectedBook.Id,
                BookCount = Convert.ToInt32(NupBookCount.Value),
                TakenAt = DtpNewTaken.Value,
                Deadline = DtpNewDeadline.Value,
                FinePrice = 0

            };

           
            _context.Orders.Add(order);
            _selectedBook.Count -= Convert.ToInt32(NupBookCount.Value);
            _context.SaveChanges();
            RtbTotalPrice.Clear();

            ClearOrders();
            FillOrders();
            ClearBooks();
            FillBooksSearch();
        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbCustomerSearch.Text))
            {
                MessageBox.Show("Please enter customer's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customers = _context.Customers.Where(c => TxbCustomerSearch.Text != string.Empty ? c.Name.StartsWith(TxbCustomerSearch.Text) : false).OrderBy(p => p.Name).ToList();

            DgvCustomersSearch.Rows.Clear();

            foreach (var item in customers)
            {
                DgvCustomersSearch.Rows.Add(item.Id,
                                            item.Name,
                                            item.Surname,
                                            item.Phone,
                                            item.Address
                                            );
            }
           

        }

        private void BtnBookSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbBookSearch.Text))
            {
                MessageBox.Show("Please enter book's title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var books = _context.Books.Where(b => TxbBookSearch.Text != string.Empty ? b.Name.StartsWith(TxbBookSearch.Text) : false).OrderBy(b => b.Name).ToList();
            DgvBookSearch.Rows.Clear();
            foreach (var item in books)
            {
                DgvBookSearch.Rows.Add(item.Id,
                                       item.Name,
                                       item.Author.Fullname,
                                       item.Genre.Name,
                                       item.Price,
                                       item.Count);
            }
        }

        
    }
}
