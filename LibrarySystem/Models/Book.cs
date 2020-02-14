using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int GenreId { get; set; }

        
        [Required]
        [Column(TypeName = "date")]
        public DateTime PublishedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public int Count { get; set; }


        public Author Author { get; set; }
        public Genre Genre { get; set; }


    }
}
