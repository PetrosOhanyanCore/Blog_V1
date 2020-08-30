using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Blog_Test_Petros_Ohanyan.Configuration;
using Blog_Test_Petros_Ohanyan.EntityFrameworkCore;
using Blog_Test_Petros_Ohanyan.Migrator.DependencyInjection;

namespace Blog_Test_Petros_Ohanyan.Migrator
{
    [DependsOn(typeof(Blog_Test_Petros_OhanyanEntityFrameworkModule))]
    public class Blog_Test_Petros_OhanyanMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Blog_Test_Petros_OhanyanMigratorModule(Blog_Test_Petros_OhanyanEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Blog_Test_Petros_OhanyanMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Blog_Test_Petros_OhanyanConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Blog_Test_Petros_OhanyanMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
