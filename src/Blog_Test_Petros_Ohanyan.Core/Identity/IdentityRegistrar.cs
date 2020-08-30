using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Blog_Test_Petros_Ohanyan.Authorization;
using Blog_Test_Petros_Ohanyan.Authorization.Roles;
using Blog_Test_Petros_Ohanyan.Authorization.Users;
using Blog_Test_Petros_Ohanyan.Editions;
using Blog_Test_Petros_Ohanyan.MultiTenancy;

namespace Blog_Test_Petros_Ohanyan.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
