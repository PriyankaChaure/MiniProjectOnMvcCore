using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace mvc_core_mini_project.CustFilter
{
    public class CustomFilter : ActionFilterAttribute, IAuthorizationFilter
    {
      public  void OnAuthorization(AuthorizationFilterContext context)
        {
          if(context.HttpContext.Session.GetString("UID")==null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller="Home", action="SignIn", Area=""}));
            }
        }
    }
}
