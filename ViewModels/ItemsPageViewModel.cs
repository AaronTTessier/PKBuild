using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class ItemsPageViewModel : PkPageViewModel
{
    public ItemsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Items;
    }
    public string BuildTest { get; set; } = "Items";
}