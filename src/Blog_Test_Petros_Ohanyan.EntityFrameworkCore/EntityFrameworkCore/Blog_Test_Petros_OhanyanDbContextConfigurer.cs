using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Blog_Test_Petros_Ohanyan.EntityFrameworkCore
{
    public static class Blog_Test_Petros_OhanyanDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Blog_Test_Petros_OhanyanDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Blog_Test_Petros_OhanyanDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
