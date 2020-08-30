using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Blog_Test_Petros_Ohanyan.Configuration;
using Blog_Test_Petros_Ohanyan.Web;

namespace Blog_Test_Petros_Ohanyan.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Blog_Test_Petros_OhanyanDbContextFactory : IDesignTimeDbContextFactory<Blog_Test_Petros_OhanyanDbContext>
    {
        public Blog_Test_Petros_OhanyanDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Blog_Test_Petros_OhanyanDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Blog_Test_Petros_OhanyanDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Blog_Test_Petros_OhanyanConsts.ConnectionStringName));

            return new Blog_Test_Petros_OhanyanDbContext(builder.Options);
        }
    }
}
