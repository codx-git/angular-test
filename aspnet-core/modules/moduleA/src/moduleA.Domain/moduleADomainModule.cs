using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace moduleA
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(moduleADomainSharedModule)
    )]
    public class moduleADomainModule : AbpModule
    {

    }
}
