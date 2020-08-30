using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Blog_Test_Petros_Ohanyan.EntityFrameworkCore.Seed;

namespace Blog_Test_Petros_Ohanyan.EntityFrameworkCore
{
    [DependsOn(
        typeof(Blog_Test_Petros_OhanyanCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Blog_Test_Petros_OhanyanEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Blog_Test_Petros_OhanyanDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        Blog_Test_Petros_OhanyanDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        Blog_Test_Petros_OhanyanDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Blog_Test_Petros_OhanyanEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
