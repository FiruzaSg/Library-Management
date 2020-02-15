using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Models;
using LibrarySystem.Data;

namespace LibrarySystem.Forms
{
    
    
    public partial class UserForm : Form
    {
        private readonly LibraryDbContext _context;
        private User _selectedUser;
        public UserForm()
        {
            _context = new LibraryDbContext();


            InitializeComponent();
            FillUsers();
            
        }


        private void FillUsers()
        {
            var Users = _context.Users.ToList();

            foreach (var item in Users)
            {
                DgvAllUsers.Rows.Add(item.Id,
                                     item.Fullname,
                                     item.Email,
                                     item.Phone,
                                     item.Status?"Active" : "Passive",
                                     item.Password
                                     
                                     );

            }
        }

        private void ClearUsers()
        {
            DgvAllUsers.Rows.Clear();
        }
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            PnlDeleteEdit.Visible = false;
            PnlCreateUser.Visible = true;
        }

        private void DgvAllUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DgvAllUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedUser = _context.Users.Find(id);

            TxbEditFullname.Text = _selectedUser.Fullname;
            TxbUserEmail.Text = _selectedUser.Email;
            TxbUserPhone.Text = _selectedUser.Phone;
            TxbUserPassword.Text = _selectedUser.Password;

            PnlDeleteEdit.Visible = true;
            PnlCreateUser.Visible = false;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _context.Users.Remove(_selectedUser);
               
                _context.SaveChanges();
                ClearUsers();
                FillUsers();

            }
            else if (r == DialogResult.No)
            {
                return;
            }
           
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxbEditFullname.Text) || 
                string.IsNullOrEmpty(TxbUserEmail.Text)||
                string.IsNullOrEmpty(TxbUserPassword.Text) ||
                string.IsNullOrEmpty(TxbUserPhone.Text))
            {
                MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult r = MessageBox.Show("Are you sure?", "User editing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _selectedUser.Fullname = TxbEditFullname.Text;
                _selectedUser.Email = TxbUserEmail.Text;
                _selectedUser.Phone = TxbUserPhone.Text;
                _selectedUser.Password = TxbUserPassword.Text;

                if (RbnActive.Checked)
                {
                    _selectedUser.Status = true;
                }
                else
                {
                    _selectedUser.Status = false;
                }
                _context.SaveChanges();
                ClearUsers();
                FillUsers();

            }
            if (r == DialogResult.No)
            {
                return;
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PnlCreateUser.Visible = false;
            PnlDeleteEdit.Visible = true;
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbFullname.Text) || string.IsNullOrEmpty(TxbEmail.Text) || string.IsNullOrEmpty(TxbPassword.Text))
            {
                MessageBox.Show("Please fill the rows", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User
            {
                Fullname = TxbFullname.Text,
                Email = TxbEmail.Text,
                Password = TxbPassword.Text,
                Phone = TxbPhone.Text,
                Status = true
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            ClearUsers();
            FillUsers();
            PnlCreateUser.Visible = false;
            PnlDeleteEdit.Visible = true;
            
            
        }
    }
}
