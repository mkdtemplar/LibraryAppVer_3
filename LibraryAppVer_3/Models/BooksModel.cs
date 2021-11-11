using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace LibraryAppVer_3.Models
{
    public class BooksModel
    {
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "NAME OF BOOK")]
        public string BookName { get; set; }
        
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "Author name is required")]
        public string Author { get; set; }
        
        [Display(Name = "YEAR OF PUBLISHING")]
        public long? YearOfPublishing { get; set; }
        
        [Display(Name = "Book Cover")] 
       
        [Required]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}