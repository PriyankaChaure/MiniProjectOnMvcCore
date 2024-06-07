using System.ComponentModel.DataAnnotations;

namespace mvc_core_mini_project.Models.LoginVM
{
    public class UserLogin
    {

        [Required(ErrorMessage = "UserName Required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
