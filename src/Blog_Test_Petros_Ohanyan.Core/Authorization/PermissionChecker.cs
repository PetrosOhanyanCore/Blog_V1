using Abp.Authorization;
using Blog_Test_Petros_Ohanyan.Authorization.Roles;
using Blog_Test_Petros_Ohanyan.Authorization.Users;

namespace Blog_Test_Petros_Ohanyan.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
