using Abp.Application.Services.Dto;

namespace Blog_Test_Petros_Ohanyan.MultiTenancy.Dto
{
    public class PagedTenantResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}

