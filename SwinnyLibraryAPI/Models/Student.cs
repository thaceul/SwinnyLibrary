namespace SwinnyLibraryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(9)]
        public string ID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "text")]
        public string Email { get; set; }

        [StringLength(12)]
        public string Mobile { get; set; }
    }
}
