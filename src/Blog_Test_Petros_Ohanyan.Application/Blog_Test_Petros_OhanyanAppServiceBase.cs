using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Blog_Test_Petros_Ohanyan.Authorization.Users;
using Blog_Test_Petros_Ohanyan.MultiTenancy;

namespace Blog_Test_Petros_Ohanyan
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Blog_Test_Petros_OhanyanAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected Blog_Test_Petros_OhanyanAppServiceBase()
        {
            LocalizationSourceName = Blog_Test_Petros_OhanyanConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
