using mold.test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace mold.test
{
    [DependsOn(
        typeof(testEntityFrameworkCoreTestModule)
        )]
    public class testDomainTestModule : AbpModule
    {

    }
}