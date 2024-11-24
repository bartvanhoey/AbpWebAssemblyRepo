using Volo.Abp.Settings;

namespace AbpLeptonXLite.Settings;

public class AbpLeptonXLiteSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpLeptonXLiteSettings.MySetting1));
    }
}
