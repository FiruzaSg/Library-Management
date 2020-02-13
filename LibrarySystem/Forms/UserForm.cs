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
                                     item.Password
                                     );

            }
        }
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
        }
    }
}
