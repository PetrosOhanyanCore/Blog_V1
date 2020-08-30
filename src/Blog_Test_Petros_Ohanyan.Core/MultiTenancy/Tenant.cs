using Abp.MultiTenancy;
using Blog_Test_Petros_Ohanyan.Authorization.Users;

namespace Blog_Test_Petros_Ohanyan.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
