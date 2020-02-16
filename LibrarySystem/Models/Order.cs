using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
   public class Order
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int BookCount { get; set; }

        [Required]
        public DateTime TakenAt { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

     
        [Column(TypeName = "money")]
        public decimal? FinePrice { get; set; }

        public bool IsDone { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}
