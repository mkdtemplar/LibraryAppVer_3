using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataContext
{
    [Table("Client")]
    public partial class Client
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

        public byte[] Photo { get; set; }
        
        //[ForeignKey(nameof(Book))] public int bookID { get; set; }
    }
}
