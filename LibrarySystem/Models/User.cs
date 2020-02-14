using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public bool Status { get; set; }

        public List<Customer> Customers { get; set; }

    }
}
