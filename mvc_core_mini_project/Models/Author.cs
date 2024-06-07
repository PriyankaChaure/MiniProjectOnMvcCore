using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core_mini_project.Models
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public Int64 AuthorId { get; set; }
        public string AuthorName { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}
