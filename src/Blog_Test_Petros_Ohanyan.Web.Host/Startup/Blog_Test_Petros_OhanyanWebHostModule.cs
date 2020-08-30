using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Blog_Test_Petros_Ohanyan.Configuration;

namespace Blog_Test_Petros_Ohanyan.Web.Host.Startup
{
    [DependsOn(
       typeof(Blog_Test_Petros_OhanyanWebCoreModule))]
    public class Blog_Test_Petros_OhanyanWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Blog_Test_Petros_OhanyanWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Blog_Test_Petros_OhanyanWebHostModule).GetAssembly());
        }
    }
}
