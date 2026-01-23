using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PKBuild.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _test = "Test";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(BoxPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(PokemonPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(ItemPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(MovesPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(TeamsPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(AnalysisPageActiveButton))]
    private ViewModelBase _pkbCurrentPage;

    private readonly BoxPageViewModel _box = new  BoxPageViewModel();
    private readonly PokemonPageViewModel _pokemon = new PokemonPageViewModel();
    private readonly ItemsPageViewModel _items = new ItemsPageViewModel();
    private readonly MovesPageViewModel _moves = new MovesPageViewModel();
    private readonly TeamsPageViewModel _teams = new TeamsPageViewModel();
    private readonly AnalysisPageViewModel _analysis = new AnalysisPageViewModel();

    public bool BoxPageActiveButton => PkbCurrentPage == _box;
    public bool PokemonPageActiveButton => PkbCurrentPage == _pokemon;
    public bool ItemPageActiveButton => PkbCurrentPage == _items;
    public bool MovesPageActiveButton => PkbCurrentPage == _moves;
    public bool TeamsPageActiveButton => PkbCurrentPage == _teams;
    public bool AnalysisPageActiveButton => PkbCurrentPage == _analysis;

    public MainWindowViewModel()
    {
        PkbCurrentPage = _box;
    }

    [RelayCommand]
    private void ChangeToBox()
    {
        PkbCurrentPage = _box;
    }

    [RelayCommand]
    private void ChangeToPokemon()
    {
        PkbCurrentPage = _pokemon;
    }

    [RelayCommand]
    private void ChangeToItems()
    {
        PkbCurrentPage = _items;
    }

    [RelayCommand]
    private void ChangeToMoves()
    {
        PkbCurrentPage = _moves;
    }

    [RelayCommand]
    private void ChangeToTeams()
    {
        PkbCurrentPage = _teams;
    }

    [RelayCommand]
    private void ChangeToAnalysis()
    {
        PkbCurrentPage = _analysis;
    }
}