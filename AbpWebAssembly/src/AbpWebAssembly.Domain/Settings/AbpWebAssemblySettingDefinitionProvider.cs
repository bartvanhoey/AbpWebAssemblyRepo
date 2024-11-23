using Volo.Abp.Settings;

namespace AbpWebAssembly.Settings;

public class AbpWebAssemblySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpWebAssemblySettings.MySetting1));
    }
}
