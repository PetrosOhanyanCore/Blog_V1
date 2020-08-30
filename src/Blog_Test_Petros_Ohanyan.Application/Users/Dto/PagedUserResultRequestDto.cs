using Abp.Application.Services.Dto;
using System;

namespace Blog_Test_Petros_Ohanyan.Users.Dto
{
    //custom PagedResultRequestDto
    public class PagedUserResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
