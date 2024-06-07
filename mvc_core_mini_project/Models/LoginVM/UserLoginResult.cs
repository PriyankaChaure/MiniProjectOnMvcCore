namespace mvc_core_mini_project.Models.LoginVM
{
    public class UserLoginResult
    {
        public bool IsLoggedIn { get; set; }
        public Int64 LoggedInID { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}
