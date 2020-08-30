using System.Threading.Tasks;
using Blog_Test_Petros_Ohanyan.Configuration.Dto;

namespace Blog_Test_Petros_Ohanyan.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
