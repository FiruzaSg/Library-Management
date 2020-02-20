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
    public partial class CustomerForm : Form
    {
        private readonly LibraryDbContext _context;
        private Customer _selectedCustomer;
        public CustomerForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            PnlNewCustomer.Visible = false;
            FillCustomers();
        }


        private void FillCustomers()
        {
            var Customers = _context.Customers.ToList();

            foreach (var item in Customers)
            {
                DgvAllCustomers.Rows.Add(item.Id,
                                         item.Name,
                                         item.Surname,
                                         item.Phone,
                                         item.Address,
                                         item.IdentityCardNo);
            }
        }
        private void ClearCustomers()
        {
            DgvAllCustomers.Rows.Clear();
        }
        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            PnlNewCustomer.Visible = true;
            PnlDeleteEdit.Visible = false;

        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _context.Customers.Remove(_selectedCustomer);

                _context.SaveChanges();
                ClearCustomers();
                FillCustomers();

            }
            else if (r == DialogResult.No)
            {
                return;
            }


        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
           if(_selectedCustomer == null)
            {
                MessageBox.Show("Please select customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            DialogResult r = MessageBox.Show("Are you sure?", "Customer editing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Customer customer = _context.Customers.Find(_selectedCustomer.Id);

            customer.Name = TxbEditName.Text;
            customer.Surname = TxbEditSurname.Text;
            customer.IdentityCardNo = TxbEditIdNo.Text;
            customer.Phone = TxbEditPhone.Text;
            customer.Address = TxbEditAddress.Text;

                _context.SaveChanges();

                ClearCustomers();
                FillCustomers();

            }
            if (r == DialogResult.No)
            {
                return;
            }

        }

        private void DgvAllCustomers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PnlNewCustomer.Visible = false;
            PnlDeleteEdit.Visible = true;
            int id = Convert.ToInt32(DgvAllCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedCustomer = _context.Customers.Find(id);

            TxbEditName.Text = _selectedCustomer.Name;
            TxbEditSurname.Text = _selectedCustomer.Surname;
            TxbEditPhone.Text = _selectedCustomer.Phone;
            TxbEditAddress.Text = _selectedCustomer.Address;
            TxbEditIdNo.Text = _selectedCustomer.IdentityCardNo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PnlNewCustomer.Visible = false;
            PnlDeleteEdit.Visible = true;
        }

        private void BtnCreateCustomer_Click(object sender, EventArgs e)
        {
            if (TxbCustomerName.Text == null ||
               TxbCustomerSurname.Text == null ||
               TxbCustomerAddress.Text == null ||
               TxbCustomerIdNo.Text == null ||
               TxbCustomerPhone == null ||
               TxbCustomerUser.Text == null)
            {
                MessageBox.Show("Please enter author", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer Customer = new Customer
            {
                Name = TxbCustomerName.Text,
                Surname = TxbCustomerSurname.Text,
                Phone = TxbCustomerPhone.Text,
                Address = TxbCustomerAddress.Text,
                IdentityCardNo = TxbCustomerIdNo.Text,
                UserId = Convert.ToInt32(TxbCustomerUser.Text)
            };

            _context.Customers.Add(Customer);
            _context.SaveChanges();
            ClearCustomers();
            FillCustomers();
            PnlNewCustomer.Visible = false;
            PnlDeleteEdit.Visible = true;
        }

    
    }
}
