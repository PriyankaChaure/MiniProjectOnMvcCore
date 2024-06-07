using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core_mini_project.Models
{
    [Table("Subject")]

    public class Subject
    {
        [Key]
        public Int64 SubjectId { get; set; }
        public string SubjectName { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
