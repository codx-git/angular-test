using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Studio.ModuleInstalling;

namespace MyCompany.moduleA
{
    [Dependency(ServiceLifetime.Transient, ReplaceServices = true)]
    [ExposeServices(typeof(IModuleInstallingPipelineBuilder))]
    public class moduleAInstallerPipelineBuilder : ModuleInstallingPipelineBuilderBase, IModuleInstallingPipelineBuilder, ITransientDependency
    {
        public async Task<ModuleInstallingPipeline> BuildAsync(ModuleInstallingContext context)
        {
            return GetBasePipeline(context);
        }
    }
}
