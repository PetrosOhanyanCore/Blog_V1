using Abp.Application.Services.Dto;

namespace Blog_Test_Petros_Ohanyan.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

