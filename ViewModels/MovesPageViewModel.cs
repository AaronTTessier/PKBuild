using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class MovesPageViewModel : PkPageViewModel
{
    public MovesPageViewModel()
    {
        PkbPageNames = PkbPageNames.Moves;
    }
    public string BuildTest { get; set; } = "Moves";
}