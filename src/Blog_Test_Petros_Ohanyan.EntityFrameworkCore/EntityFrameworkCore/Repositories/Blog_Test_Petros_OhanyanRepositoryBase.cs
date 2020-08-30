using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace Blog_Test_Petros_Ohanyan.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class Blog_Test_Petros_OhanyanRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<Blog_Test_Petros_OhanyanDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Blog_Test_Petros_OhanyanRepositoryBase(IDbContextProvider<Blog_Test_Petros_OhanyanDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="Blog_Test_Petros_OhanyanRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class Blog_Test_Petros_OhanyanRepositoryBase<TEntity> : Blog_Test_Petros_OhanyanRepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        protected Blog_Test_Petros_OhanyanRepositoryBase(IDbContextProvider<Blog_Test_Petros_OhanyanDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
