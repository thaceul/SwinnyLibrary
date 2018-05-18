namespace SwinnyLibraryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Key]
        [StringLength(17)]
        public string ISBN { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
    }
}
