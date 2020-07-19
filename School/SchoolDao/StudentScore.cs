using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.SchoolDao
{
    [Table("StudentScore")]
    public class StudentScore
    {
        [Key]
        [Column("sid", TypeName = "int(11)")]
        public int Sid { get; set; }

        [Key]
        [Column("cid", TypeName = "int(11)")]
        public int Cid { get; set; }

        [Column("score", TypeName = "int(11)")]
        public int Score { get; set; }
    }
}