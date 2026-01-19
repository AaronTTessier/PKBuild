using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _test = "Test";

    [ObservableProperty]
    private ViewModelBase _pkbCurrentPage;

    private readonly BoxPageViewModel _box = new  BoxPageViewModel();
    private readonly PokemonPageViewModel _pokemon = new PokemonPageViewModel();

    public MainWindowViewModel()
    {
        PkbCurrentPage = _box;
    }
}