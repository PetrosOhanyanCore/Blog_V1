using System.Collections.Generic;

namespace Blog_Test_Petros_Ohanyan.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
