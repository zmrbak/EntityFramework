namespace EF29
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 5, ErrorMessage = "���Ƚ���5-10���ַ�")]
        [Required]
        public string StuName { get; set; }

        public int? ClassId { get; set; }

        [NotMapped]
        public bool Gender { get; set; }

        public virtual StuClass StuClass { get; set; }
    }
}
