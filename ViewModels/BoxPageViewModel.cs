using System.Collections.ObjectModel;
using PKBuild.Data;
using PKBuild.Models;

namespace PKBuild.ViewModels;

public partial class BoxPageViewModel : PkPageViewModel
{
    // TODO: Change PokemonArrTest to production-ready format during Viewmodel finalizing
    private ObservableCollection<PokemonPageModel>? _pokemonArrTest;
    
    public ObservableCollection<PokemonPageModel>? PokemonArrTest
    {
        get => _pokemonArrTest;
        set => SetProperty(ref _pokemonArrTest, value);
    }
    public BoxPageViewModel()
    {
        PkbPageNames = PkbPageNames.Boxes;
    }
    
}