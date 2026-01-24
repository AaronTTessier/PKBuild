using CommunityToolkit.Mvvm.ComponentModel;
using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class PkPageViewModel : ViewModelBase
{
    [ObservableProperty] 
    private PkbPageNames _pkbPageNames;
}