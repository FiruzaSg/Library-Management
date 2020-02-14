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
    public partial class NewUserForm : Form
    {
        private readonly LibraryDbContext _context;
        public NewUserForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

     

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxbFullname.Text) || string.IsNullOrEmpty(TxbEmail.Text) || string.IsNullOrEmpty(TxbPassword.Text))
            {
                MessageBox.Show("Please fill the rows","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            this.Close();
            
        }

    
    }
}
