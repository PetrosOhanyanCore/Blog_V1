using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Blog_Test_Petros_Ohanyan.Authorization.Users;
using Blog_Test_Petros_Ohanyan.Editions;

namespace Blog_Test_Petros_Ohanyan.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
