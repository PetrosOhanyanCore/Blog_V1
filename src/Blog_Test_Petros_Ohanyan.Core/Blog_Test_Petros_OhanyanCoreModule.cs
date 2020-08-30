using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Blog_Test_Petros_Ohanyan.Authorization.Roles;
using Blog_Test_Petros_Ohanyan.Authorization.Users;
using Blog_Test_Petros_Ohanyan.Configuration;
using Blog_Test_Petros_Ohanyan.Localization;
using Blog_Test_Petros_Ohanyan.MultiTenancy;
using Blog_Test_Petros_Ohanyan.Timing;

namespace Blog_Test_Petros_Ohanyan
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class Blog_Test_Petros_OhanyanCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            Blog_Test_Petros_OhanyanLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = Blog_Test_Petros_OhanyanConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Blog_Test_Petros_OhanyanCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
