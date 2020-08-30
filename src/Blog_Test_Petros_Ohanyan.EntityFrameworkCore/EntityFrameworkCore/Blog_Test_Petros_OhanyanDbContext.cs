using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Blog_Test_Petros_Ohanyan.Authorization.Roles;
using Blog_Test_Petros_Ohanyan.Authorization.Users;
using Blog_Test_Petros_Ohanyan.MultiTenancy;

namespace Blog_Test_Petros_Ohanyan.EntityFrameworkCore
{
    public class Blog_Test_Petros_OhanyanDbContext : AbpZeroDbContext<Tenant, Role, User, Blog_Test_Petros_OhanyanDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Blog_Test_Petros_OhanyanDbContext(DbContextOptions<Blog_Test_Petros_OhanyanDbContext> options)
            : base(options)
        {
        }
    }
}
