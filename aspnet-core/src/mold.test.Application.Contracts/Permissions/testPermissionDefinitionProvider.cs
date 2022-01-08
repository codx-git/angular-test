using mold.test.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace mold.test.Permissions
{
    public class testPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(testPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(testPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<testResource>(name);
        }
    }
}
