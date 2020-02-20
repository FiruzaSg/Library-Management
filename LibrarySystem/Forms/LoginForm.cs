using LibrarySystem.Data;
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
    public partial class LoginForm : Form
    {

        private readonly LibraryDbContext _context;


        public LoginForm()
        {
            InitializeComponent();
            _context = new LibraryDbContext();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbEmail.Text))
            {
                MessageBox.Show("Please enter email", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxbPassword.Text))
            {
                MessageBox.Show("Please enter password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxbEmail.Text &&
                                                          u.Password == TxbPassword.Text);
            if (user != null)
            {
                
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Wrong Email or Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
    }
        
     
}

