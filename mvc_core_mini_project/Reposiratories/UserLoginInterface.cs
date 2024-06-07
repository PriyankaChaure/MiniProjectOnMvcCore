using mvc_core_mini_project.Models.LoginVM;

namespace mvc_core_mini_project.Reposiratories
{
    public interface UserLoginInterface
    {
        void Registration(UserLoginVM rec);
        UserLoginResult SignIn(UserLogin rec);
    }
}
