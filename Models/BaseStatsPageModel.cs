using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class BaseStatsPageModel : ObservableObject
{
    [ObservableProperty] private int _statId = 0;

    [ObservableProperty] private int _natNum = 0;

    [ObservableProperty] private int _statTotal = 0;

    [ObservableProperty] private int _statHp = 0;
    
    [ObservableProperty] private int _statAtk = 0;
    
    [ObservableProperty] private int _statDef = 0;
    
    [ObservableProperty] private int _statSpA = 0;
    
    [ObservableProperty] private int _statSpD = 0;
    
    [ObservableProperty] private int _statSpe = 0;
    
    //One-to-many navigation with Pokémon dependents
    public ICollection<PokemonPageModel>  Pokemon { get; } = new List<PokemonPageModel>();
}