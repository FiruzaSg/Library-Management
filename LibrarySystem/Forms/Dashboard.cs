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
        private LibraryDbContext _context;
        private Order _selectedOrder;
        private Customer _selectedCustomer;
        private Book _selectedBook;
        public Book _returnBook;
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
                                      item.Customer.Name,
                                      item.Customer.Surname,
                                      item.Book.Name,
                                      item.BookCount,
                                      item.TakenAt,
                                      item.Deadline,
                                      item.Price,
                                      item.FinePrice,
                                      item.IsDone ? "Active" : "Passive",
                                      item.BookId
                                     ) ;

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

        public void FillBasket()
        {

            decimal price = _selectedBook.Price * NupBookCount.Value;
            DgvBasket.Rows.Add(_selectedBook.Id,
                               _selectedBook.Name,
                               NupBookCount.Value,
                               price
                               );

           

        }
        private void UpdateContext()
        {
            _context = new LibraryDbContext();
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


        #region Events and Actions
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

        private void DgvAllOrders_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(DgvAllOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
                _selectedOrder = _context.Orders.Find(id);

                int bookId = Convert.ToInt32(DgvAllOrders.Rows[e.RowIndex].Cells[10].Value.ToString());
                _returnBook = _context.Books.Find(bookId);

            }
            catch (NullReferenceException error)
            {
                //pass
            }
            catch (ArgumentOutOfRangeException error)
            {
                // pass
            }

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
            BtnAllOrders.Visible = true;
            BtnNewOrder.Visible = false;
        }

        private void BtnAllOrders_Click(object sender, EventArgs e)
        {
            PnlAllOrders.Visible = true;
            PnlNewOrder.Visible = false;
            BtnNewOrder.Visible = true;
            BtnAllOrders.Visible = false;
        }

  


        private void DgvCustomersSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DgvCustomersSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                _selectedCustomer = _context.Customers.Find(id);
            }
            catch (NullReferenceException error)
            {
                // pass
            }
            catch (ArgumentOutOfRangeException error)
            {
                // pass
            }
        }
        private void DgvBookSearch_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DgvBookSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                _selectedBook = _context.Books.Find(id);
            }
            catch (NullReferenceException error)
            {
                // pass
            }
            catch (ArgumentOutOfRangeException error)
            {

                // pass
            }
        }



        private void BtnCustomerSearch_Click_1(object sender, EventArgs e)
        {
            DgvCustomersSearch.Rows.Clear();
            //UpdateContext();
            string searchText = TxbCustomerSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {

                FillCustomersSearch();
                return;
            }

            var customers = _context.Customers
                .Where(c => searchText != string.Empty ? c.Name.StartsWith(searchText) : false)
                .OrderBy(c => c.Name)
                .ToList();



            foreach (var item in customers)
            {
                DgvCustomersSearch.Rows.Add(item.Id,
                                            item.Name,
                                            item.Surname,
                                            item.Phone,
                                            item.Address
                                            );
            }
            TxbCustomerSearch.Clear();
        }

        private void BtnBookSearch_Click_1(object sender, EventArgs e)
        {
            DgvBookSearch.Rows.Clear();
            string searchText = TxbBookSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {

                FillBooksSearch();
                return;
            }

            var books = _context.Books
                .Where(b => searchText != string.Empty ? b.Name.StartsWith(searchText) : false)
                .OrderBy(b => b.Name)
                .ToList();



            foreach (var item in books)
            {
                DgvBookSearch.Rows.Add(item.Id,
                                            item.Name,
                                            item.Genre.Name,
                                            item.Author.Fullname,
                                            item.Price,
                                            item.Count
                                            );
            }
            
            TxbBookSearch.Clear();
        }

        private void BtnCancelOrder_Click_1(object sender, EventArgs e)
        {
            DgvCustomersSearch.ClearSelection();
            DgvBookSearch.ClearSelection();
            NupBookCount.Value = 1;
            RtbTotalPrice.Clear();
            PnlOrderInfo.Visible = false;
        }

        #endregion

        private void BtnOrderSearch_Click_1(object sender, EventArgs e)
        {
            DgvAllOrders.Rows.Clear();
            string searchText = TxbOrderSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {

                FillOrders();
                return;
            }
            var orders = _context.Orders
                .Where(o => searchText != string.Empty ? o.Customer.Name.StartsWith(searchText) : false)
                .OrderBy(o => o.Customer.Name)
                .ToList();



            foreach (var item in orders)
            {
                DgvAllOrders.Rows.Add(item.Id,
                                      item.Customer.Name,
                                      item.Customer.Surname,
                                      item.Book.Name,
                                      item.BookCount,
                                      item.TakenAt,
                                      item.Deadline,
                                      item.Price,
                                      item.IsDone ? "Active" : "Passive");
            }

            


        }

       

        private void BtnNewOrder_Click_1(object sender, EventArgs e)
        {
            PnlNewOrder.Visible = true;
            PnlAllOrders.Visible = false;
            BtnAllOrders.Visible = true;
            BtnNewOrder.Visible = false;
        }

        private void BtnAddToCard_Click_1(object sender, EventArgs e)
        {
            if (_selectedCustomer == null ||
                _selectedBook == null)
            {
                MessageBox.Show("Please select customer and book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_selectedBook.Count < NupBookCount.Value)
            {
                MessageBox.Show("No available books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PnlOrderInfo.Visible = true;
            DgvBasket.Rows.Clear();


            decimal price = _selectedBook.Price * NupBookCount.Value;
            RtbTotalPrice.Text = price.ToString();
            FillBasket();
            TxbCustomerSearch.Clear();
            TxbBookSearch.Clear();
            
        }

        private void BtnCreateOrder_Click_1(object sender, EventArgs e)
        {
            if (_selectedCustomer == null || _selectedBook == null)
            {
                MessageBox.Show("Please select customer and book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult r = MessageBox.Show("Are you sure?", "Order confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.No)
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
                Price = Convert.ToDecimal(RtbTotalPrice.Text) * NupBookCount.Value,
                IsDone = true

            };


            _context.Orders.Add(order);
            _selectedBook.Count -= Convert.ToInt32(NupBookCount.Value);
            _context.SaveChanges();
            RtbTotalPrice.Clear();
            NupBookCount.Value = 1;
            PnlOrderInfo.Visible = false;
            ClearOrders();
            FillOrders();
            ClearBooks();
            FillBooksSearch();

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            DialogResult r  = MessageBox.Show("Are you sure?", "Book return", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            


            if(r == DialogResult.Yes)
            {
                //(sender as DataGridView).CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Green;
                _selectedOrder.IsDone = false;

                 _returnBook.Count += _selectedOrder.BookCount;
                _context.SaveChanges();
                ClearOrders();
                FillOrders();
            }
            if (r == DialogResult.No)
            {
                return;

            }

        }

  
    }

}
