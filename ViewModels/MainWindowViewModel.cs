using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PKBuild.Data;
using PKBuild.Factory;

namespace PKBuild.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly PkPageFactory _pageFactory;
    
    [ObservableProperty]
    private string _test = "Test";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(BoxPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(PokemonPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(ItemPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(MovesPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(TeamsPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(AnalysisPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(SettingsPageActiveButton))]
    private PkPageViewModel _pkbCurrentPage;

    public bool BoxPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Boxes;
    public bool PokemonPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Pokemon;
    public bool ItemPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Items;
    public bool MovesPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Moves;
    public bool TeamsPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Teams;
    public bool AnalysisPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Analysis;
    public bool SettingsPageActiveButton => PkbCurrentPage.PkbPageNames == PkbPageNames.Settings;

    
    // TODO: Remove after finishing design
    public MainWindowViewModel()
    {
        PkbCurrentPage = new ItemsPageViewModel();
    }
    public MainWindowViewModel(PkPageFactory pageFactory)
    {
        _pageFactory = pageFactory;
        ChangeToItems();
    }

    [RelayCommand]
    private void ChangeToBox()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Boxes);
    }

    [RelayCommand]
    private void ChangeToPokemon()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Pokemon);
    }

    [RelayCommand]
    private void ChangeToItems()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Items);
    }

    [RelayCommand]
    private void ChangeToMoves()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Moves);
    }

    [RelayCommand]
    private void ChangeToTeams()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Teams);
    }

    [RelayCommand]
    private void ChangeToAnalysis()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Analysis);
    }

    [RelayCommand]
    private void ChangeToSettings()
    {
        PkbCurrentPage = _pageFactory.GetPkPageViewModel(PkbPageNames.Settings);
    }
}