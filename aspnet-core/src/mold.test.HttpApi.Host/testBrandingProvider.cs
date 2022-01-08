using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace mold.test
{
    [Dependency(ReplaceServices = true)]
    public class testBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "test";
    }
}
