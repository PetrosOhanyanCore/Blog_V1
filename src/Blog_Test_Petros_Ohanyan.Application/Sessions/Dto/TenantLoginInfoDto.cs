using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Blog_Test_Petros_Ohanyan.MultiTenancy;

namespace Blog_Test_Petros_Ohanyan.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
