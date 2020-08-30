using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Blog_Test_Petros_Ohanyan.EntityFrameworkCore;
using Blog_Test_Petros_Ohanyan.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Blog_Test_Petros_Ohanyan.Web.Tests
{
    [DependsOn(
        typeof(Blog_Test_Petros_OhanyanWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Blog_Test_Petros_OhanyanWebTestModule : AbpModule
    {
        public Blog_Test_Petros_OhanyanWebTestModule(Blog_Test_Petros_OhanyanEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Blog_Test_Petros_OhanyanWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Blog_Test_Petros_OhanyanWebMvcModule).Assembly);
        }
    }
}