using AbpLeptonXLite.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpLeptonXLite.Permissions;

public class AbpLeptonXLitePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpLeptonXLitePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpLeptonXLitePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpLeptonXLiteResource>(name);
    }
}
