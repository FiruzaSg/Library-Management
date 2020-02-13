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
            if(string.IsNullOrEmpty(TxbEmail.Text))
            {
                MessageBox.Show("Please enter Email");
                return;
            } 
            if(string.IsNullOrEmpty(TxbEmail.Text))
            {
                MessageBox.Show("Please enter Password");
                return;
            }
            if (_context.Users.Any(t => t.Email != TxbEmail.Text ||
                                        t.Password != TxbPassword.Text))
            {
                MessageBox.Show("Wrong Email or Password","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            User user = _context.Users.FirstOrDefault(u => u.Email == TxbEmail.Text && 
                                                           u.Password == TxbPassword.Text);
           
            Dashboard dashboard = new Dashboard();

            dashboard.ShowDialog();

            this.Hide();
            return;
           
 
        }
    }
}
