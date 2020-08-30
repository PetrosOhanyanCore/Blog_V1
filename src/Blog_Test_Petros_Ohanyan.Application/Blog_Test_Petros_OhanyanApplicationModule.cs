using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Blog_Test_Petros_Ohanyan.Authorization;

namespace Blog_Test_Petros_Ohanyan
{
    [DependsOn(
        typeof(Blog_Test_Petros_OhanyanCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Blog_Test_Petros_OhanyanApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Blog_Test_Petros_OhanyanAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Blog_Test_Petros_OhanyanApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
