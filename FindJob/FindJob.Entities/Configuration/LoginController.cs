using System;
using System.Collections.Generic;
using System.Text;

namespace FindJob.Entities.Configuration
{
   public class LoginController/*AuthorizeAttribute*/
    {
       
        /* public class LoginController : 
    {

        if (!HttpContext.Current.Request.IsAuthenticated)
            {
                HttpContext.Response.Redirect("~/Account/Login");
            }


    //     //Kullanıcı giriş yapmamışsa login sayfasına at
    //        if (!HttpContext.Current.Request.IsAuthenticated)
    //        {
    //            httpContext.Response.Redirect("~/admin/login");
    //        }

    ////cookie'deki kullanıcı idsini alıyorum
    //int rolid = Convert.ToInt32(httpContext.User.Identity.Name);
    ////idsini aldığım kullanıcıyı db'den çekiyorum
    //var user = repo.GetQueryable().FirstOrDefault(c => c.ID == rolid);
    //var roles = Roles.Split(',');
    //        //kullanıcı admin ise 
    //        if (user.IsAdmin)
    //        {
    //            if (roles.Contains("Admin"))
    //                return true;
    //        }
    //        //kullanıcı company ise
    //        else if (user.IsCompany)
    //        {
    //            if (roles.Contains("Company"))
    //                return true;
    //        }
    //        return base.AuthorizeCore(httpContext);
}*/
    }
}
