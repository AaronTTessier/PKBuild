using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class BoxPageViewModel : PkPageViewModel
{
    public BoxPageViewModel()
    {
        PkbPageNames = PkbPageNames.Boxes;
    }
    public string BuildTest { get; set; } = "Boxes";
}