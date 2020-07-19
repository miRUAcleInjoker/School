using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.SchoolDao
{
    [Table("teacher")]
    public class Teacher
    {
        [Key]
        [Column("tid", TypeName = "int(11)")]
        public int Tid { get; set; }

        [Column("tname")] [StringLength(30)] public string Tname { get; set; }
    }
}