using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace LibraryAppVer_3.Models
{
    public class ClientsModel
    {
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "NAME OF CLIENT")]
        [Required]
        public string NameOfClient { get; set; }

        [Range(5,150)]
        public long? Age { get; set; }

        [Column("LibraryID")]
        [Required]
        [Display(Name = "LIBRARY ID")]
        public long? LibraryId { get; set; }

        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Display(Name = "RENTED BOOK")]
        public string RentedBook { get; set; }
        
        [Display(Name = "Upload File")]
        [Required]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}