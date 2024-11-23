using AbpWebAssembly.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpWebAssembly.Permissions;

public class AbpWebAssemblyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpWebAssemblyPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpWebAssemblyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpWebAssemblyResource>(name);
    }
}
