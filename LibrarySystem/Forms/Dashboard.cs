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

            FillActiveOrders();
            FillCustomersSearch();
            FillBooksSearch();
        }

        #region Fill and Clear methods

       
        private void FillPassiveOrders() // Fills closed orders to datagridview
        {
            var Orders = _context.Orders.Include("Book").Include("Customer")
                                               .Where(c => c.IsOpen == false)
                                               .ToList();

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
                                      item.IsOpen ? "Active" : "Passive",
                                      item.BookId
                                     );
            }
        } 

       
        private void FillActiveOrders() // Fills opened orders to datagridview
        {
            var Orders = _context.Orders.Include("Book").Include("Customer")
                                                .Where(c => c.IsOpen ==true)
                                                .ToList();
            
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
                                      item.IsOpen ? "Active" : "Passive",
                                      item.BookId
                                     ) ;

            }
        }
        private void FillAllOrders() // Fills all orders to datagridview
        {
            var Orders = _context.Orders.Include("Book").Include("Customer").ToList();

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
                                      item.IsOpen ? "Active" : "Passive",
                                      item.BookId
                                     );

            }

        }

            private void FillLateOrders()  // Fills late orders to datagridview
        {
            var Orders = _context.Orders.Include("Book").Include("Customer")
                                              .Where(c => c.Deadline < DateTime.Now && c.IsOpen == true)
                                              .ToList();

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
                                      item.IsOpen ? "Active" : "Passive",
                                      item.BookId
                                     );
            }
        }

        
        private void FillCustomersSearch() // Fills customers to datagridview
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

       
        public void FillBooksSearch()  // Fills late books to datagridview
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

        
        private void BtnBookForm_Click(object sender, EventArgs e) //Opens book form for adding,editin,deleting book
        {
            BookForm createBook = new BookForm();
            createBook.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) //Opens user form for adding,editin,deleting user
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //Opens customer form for adding,editin,deleting customer
        {
            CustomerForm customersForm = new CustomerForm();
            customersForm.ShowDialog();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e) //Opens for creating order
        {
            PnlNewOrder.Visible = true;
            PnlAllOrders.Visible = false;
            BtnAllOrders.Visible = true;
            BtnNewOrder.Visible = false;
        }

        private void BtnAllOrders_Click(object sender, EventArgs e)
        {
            DgvAllOrders.Rows.Clear();
            FillActiveOrders();
            PnlAllOrders.Visible = true;
            PnlNewOrder.Visible = false;
            BtnNewOrder.Visible = true;
            BtnReturn.Visible = true;
            LblAllOrders.Visible = true;
            LblReturn.Visible = false;
            
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

                FillActiveOrders();
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
                                      item.IsOpen ? "Active" : "Passive");
            }

            


        }

       

        private void BtnNewOrder_Click_1(object sender, EventArgs e)
        {
            PnlNewOrder.Visible = true;
            PnlAllOrders.Visible = false;
            BtnAllOrders.Visible = true;
            BtnAllReturns.Visible = true;
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
                IsOpen = true

            };


            _context.Orders.Add(order);
            _selectedBook.Count -= Convert.ToInt32(NupBookCount.Value);
            _context.SaveChanges();
            RtbTotalPrice.Clear();
            NupBookCount.Value = 1;
            PnlOrderInfo.Visible = false;
            ClearOrders();
            FillActiveOrders();
            ClearBooks();
            FillBooksSearch();

        }

        // Return book
        private void BtnReturn_Click(object sender, EventArgs e)
        {

            if (_selectedOrder == null)
            {
                MessageBox.Show("Please select order to return","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
            decimal Percent = 0.1M;
            decimal FinePrice = _selectedOrder.Price * ((DateTime.Now - _selectedOrder.Deadline).Days) * Percent;
            RtbFinePrice.Text = FinePrice.ToString();
            PnlPaymentInfo.Visible = true;
            

            
        }

        // Inserts AllReturns to Datagridview
        private void BtnAllReturns_Click(object sender, EventArgs e)
        {
            
            PnlNewOrder.Visible = false;
            PnlAllOrders.Visible = true;
            DgvAllOrders.Rows.Clear();
            FillPassiveOrders();
            LblAllOrders.Visible = false;
            LblReturn.Visible = true;
            BtnReturn.Visible = false;
        }

        //Inserts LateReturns to Datagridview
        private void BtnLateReturn_Click(object sender, EventArgs e)
        {
            
            DgvAllOrders.Rows.Clear();
            FillLateOrders();
            GrbReportRange.Hide();
            BtnReturn.Visible = true;
        }

        //Shows fine for late return
        private void BtnPayFine_Click_1(object sender, EventArgs e)
        {
            
             DialogResult r = MessageBox.Show("Are you sure?", "Book return", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                

                if(_selectedOrder.Deadline < DateTime.Now)
                {

                }
                //(sender as DataGridView).CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Green;
                _selectedOrder.IsOpen = false;

                _returnBook.Count += _selectedOrder.BookCount;
                _selectedOrder.FinePrice = Convert.ToDecimal(RtbFinePrice.Text);
                
                _context.SaveChanges();
                ClearOrders();
                FillLateOrders();
                RtbFinePrice.Clear();
            }
            if (r == DialogResult.No)
            {
                return;

            }
            
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            
            
            DgvAllOrders.Rows.Clear();
            FillAllOrders();
            BtnExcel.Show();
            GrbReportRange.Show();
            BtnNewOrder.Hide();
            BtnReturn.Hide();
        }
    }

}
