using Volo.Abp.Studio;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyCompany.moduleA
{
    [DependsOn(
        typeof(AbpStudioModuleInstallerModule),
        typeof(AbpVirtualFileSystemModule)
        )]
    public class moduleAInstallerModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<moduleAInstallerModule>();
            });
        }
    }
}
