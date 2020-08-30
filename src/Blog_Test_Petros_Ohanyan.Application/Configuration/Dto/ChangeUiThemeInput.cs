using System.ComponentModel.DataAnnotations;

namespace Blog_Test_Petros_Ohanyan.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
