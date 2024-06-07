using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core_mini_project.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public Int64 AdminId { get; set; }
        [Required(ErrorMessage ="First Name Required!!")]
        public string FristName { get; set; }
        [Required(ErrorMessage = "Last Name Required!!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "User Name Required!!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Required!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
