using System.Threading.Tasks;
using Abp.Application.Services;
using Blog_Test_Petros_Ohanyan.Authorization.Accounts.Dto;

namespace Blog_Test_Petros_Ohanyan.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
