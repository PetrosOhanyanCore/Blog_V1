using Abp.AutoMapper;
using Blog_Test_Petros_Ohanyan.Authentication.External;

namespace Blog_Test_Petros_Ohanyan.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
