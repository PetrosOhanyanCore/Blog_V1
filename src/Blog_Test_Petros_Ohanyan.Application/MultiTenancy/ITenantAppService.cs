using Abp.Application.Services;
using Blog_Test_Petros_Ohanyan.MultiTenancy.Dto;

namespace Blog_Test_Petros_Ohanyan.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

