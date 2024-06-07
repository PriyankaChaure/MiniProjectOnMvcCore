using mvc_core_mini_project.Models;
using mvc_core_mini_project.Models.LoginVM;

namespace mvc_core_mini_project.Reposiratories
{
    public class UserLoginRepo : UserLoginInterface
    {
        CompanyContext cc;
        public UserLoginRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Registration(UserLoginVM rec)
        {
            Admin urec = new Admin();
            urec.FristName = rec.FristName;
            urec.LastName = rec.LastName;
            urec.UserName=rec.UserName;
            urec.Password = rec.Password;
            
            this.cc.Admins.Add(urec);
            this.cc.SaveChanges();
            
        }

       public UserLoginResult SignIn(UserLogin rec)
       {

            UserLoginResult result = new UserLoginResult();
           var urec = this.cc.Admins.SingleOrDefault(p =>( p.UserName == rec.UserName && p.Password == rec.Password));
            if (urec != null)
            {
                result.IsLoggedIn = true;
                result.LoggedInID = urec.AdminId;
                result.UserName = urec.UserName;
            }
            else
            {
                result.IsLoggedIn = false;
                result.Message = "Invalid User Name or Password!";
            }
            return result;
       }
    }
}
