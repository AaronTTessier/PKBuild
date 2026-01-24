using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class TeamsPageViewModel : PkPageViewModel
{
    public TeamsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Teams;
    }
    public string BuildTest { get; set; } = "Teams";
}