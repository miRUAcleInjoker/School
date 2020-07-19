using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.SchoolDao
{
    [Table("course")]
    public class Course
    {
        [Key]
        [Column("cid", TypeName = "int(11)")]
        public int Cid { get; set; }

        [Column("cname")] [StringLength(30)] public string Cname { get; set; }
        [Column("tid", TypeName = "int(11)")] public int? Tid { get; set; }
    }
}