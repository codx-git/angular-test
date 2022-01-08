using Volo.Abp.Modularity;

namespace mold.test
{
    [DependsOn(
        typeof(testApplicationModule),
        typeof(testDomainTestModule)
        )]
    public class testApplicationTestModule : AbpModule
    {

    }
}