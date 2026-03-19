using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using PKBuild.Data;
using PKBuild.Models;

namespace PKBuild.ViewModels;

public partial class TeamsPageViewModel : PkPageViewModel
{
    private ObservableCollection<PokemonPageModel>? _pokemon;

    public ObservableCollection<PokemonPageModel>? Pokemon
    {
        get => _pokemon;
        set => SetProperty(ref _pokemon, value);
    }

    [RelayCommand]
    private void ChangePokemon()
    {
        
    }

    [RelayCommand]
    public void GatherPokemon()
    {
        // TODO: Fetch from database of currently logged in user
        /*var pkmnTest = new PokemonPageModel
        {
            PkmnId = 0,
            UserId = 0,
            StatId = 0,
            GenId = 0,
            PkdxRegNum = 143,
            PkdxNatNum = 143,
            EVHp = 252,
            EVAtk = 252,
            EVDef = 4,
            EVSpA = 16,
            EVSpD = 9,
            EVSpe = 41,
            IVHp = 31,
            IVAtk = 31,
            IVDef = 31,
            IVSpA = 31,
            IVSpD = 31,
            IVSpe = 31,
            Alpha = true,
            GMax = true,
            TeraBaseType = 0,
            TeraOverrideType = null

        Pokemon =
        [
            pkmnTest
        ];
        };*/
    }
    
    public TeamsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Teams;
        GatherPokemon();
    }
}