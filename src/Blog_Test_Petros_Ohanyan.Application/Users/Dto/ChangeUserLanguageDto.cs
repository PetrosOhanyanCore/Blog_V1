using System.ComponentModel.DataAnnotations;

namespace Blog_Test_Petros_Ohanyan.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}