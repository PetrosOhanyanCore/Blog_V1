using System.ComponentModel.DataAnnotations;

namespace Blog_Test_Petros_Ohanyan.Users.Dto
{
    public class ChangePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
