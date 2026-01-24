using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class SettingsPageViewModel : PkPageViewModel
{
    public SettingsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Settings;
    }
    public string BuildTest { get; set; } = "Settings";
}