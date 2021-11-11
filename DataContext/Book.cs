using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataContext
{
    [Table("book")]
    public partial class Book
    {
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "NAME OF BOOK")]
        public string BookName { get; set; }
        
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "Author name is required")]
        public string Author { get; set; }
        
        [Display(Name = "YEAR OF PUBLISHING")]
        public long? YearOfPublishing { get; set; }
        
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Display(Name = "Book Cover")] 
        public byte[] BookCover { get; set; }
    }
}
