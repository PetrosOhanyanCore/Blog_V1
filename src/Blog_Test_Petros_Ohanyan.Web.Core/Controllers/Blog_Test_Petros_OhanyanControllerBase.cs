using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Blog_Test_Petros_Ohanyan.Controllers
{
    public abstract class Blog_Test_Petros_OhanyanControllerBase: AbpController
    {
        protected Blog_Test_Petros_OhanyanControllerBase()
        {
            LocalizationSourceName = Blog_Test_Petros_OhanyanConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
