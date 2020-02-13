using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext():base("LibraryDbContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }


    }
}
