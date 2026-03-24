using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PKBuild.Data;
using PKBuild.Factory;
using PKBuild.Models;
using PKBuild.Services;

namespace PKBuild.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly PkPageFactory _pageFactory;
    private readonly DbFactory _dbFactory;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(BoxPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(PokemonPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(ItemPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(MovesPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(TeamsPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(AnalysisPageActiveButton))]
    [NotifyPropertyChangedFor(nameof(SettingsPageActiveButton))]
    private PkPageViewModel? _pkbCurrentPage;

    [ObservableProperty] private DialogViewModel? _loginDialog;

    public bool BoxPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Boxes;
    public bool PokemonPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Pokemon;
    public bool ItemPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Items;
    public bool MovesPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Moves;
    public bool TeamsPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Teams;
    public bool AnalysisPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Analysis;
    public bool SettingsPageActiveButton => PkbCurrentPage!.PkbPageNames == PkbPageNames.Settings;

    /// <summary>
    /// No-Parameter Constructor for Design-Time only
    /// TODO: Remove after finishing design
    /// </summary>
    /*public MainWindowViewModel()
    {
        PkbCurrentPage = new TeamsPageViewModel();
    }*/
    public MainWindowViewModel(PkPageFactory pageFactory, DbFactory dbFactory)
    {
        _pageFactory = pageFactory ?? throw new ArgumentNullException(nameof(pageFactory));
        _dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));

        using var dbContext = _dbFactory.GetDbService();
        dbContext.ApplyAllMigrations();

        UserPageModel userTest = new UserPageModel
        {
            UserId = 0,
            UserName = "Attessier",
            FirstName = "Aaron",
            Email = "test@gmail.com",
            PasswordHash = ""
        };
        dbContext.UserRegister(userTest, "testword");
        ChangeToTeams();
    }

    [RelayCommand]
    private void OpenLoginDialog()
    {
        LoginDialog.IsOpen = true;
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