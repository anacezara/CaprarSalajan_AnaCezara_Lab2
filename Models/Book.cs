﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace CaprarSalajan_AnaCezara_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Book Title")]
        [StringLength(150, MinimumLength = 3)]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]   
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID {  get; set; }
        [Display(Name = "Publisher")]
        public Publisher? Publisher {get; set; }

        [Display(Name = "Author")]
        public int? AuthorID { get; set; }

        public Author? Author { get; set; }
        
        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
