using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Blog_Test_Petros_Ohanyan.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
