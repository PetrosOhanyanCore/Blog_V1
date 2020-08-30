using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Blog_Test_Petros_Ohanyan.Authorization
{
    public class Blog_Test_Petros_OhanyanAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, Blog_Test_Petros_OhanyanConsts.LocalizationSourceName);
        }
    }
}
