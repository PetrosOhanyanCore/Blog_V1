using System.Threading.Tasks;
using Abp.Application.Services;
using Blog_Test_Petros_Ohanyan.Sessions.Dto;

namespace Blog_Test_Petros_Ohanyan.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
