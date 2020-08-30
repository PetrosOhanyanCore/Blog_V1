using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Blog_Test_Petros_Ohanyan.Configuration.Dto;

namespace Blog_Test_Petros_Ohanyan.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Blog_Test_Petros_OhanyanAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
