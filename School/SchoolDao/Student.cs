using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.SchoolDao
{
    [Table("student")]
    public class Student
    {
        [Key]
        [Column("sid", TypeName = "int(11)")]
        public int Sid { get; set; }

        [Required]
        [Column("sname")]
        [StringLength(30)]
        public string Sname { get; set; }

        [Column("sage", TypeName = "int(3)")] public int Sage { get; set; }

        [Required] [Column("ssex")] public string Ssex { get; set; }
    }
}