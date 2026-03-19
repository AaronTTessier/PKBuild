using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class UserPageModel : ObservableObject
{
    [ObservableProperty] private int _userId;
    
    [ObservableProperty] private string _userName = string.Empty;

    [ObservableProperty] private string _firstName = string.Empty;

    [ObservableProperty] private string _email = string.Empty;

    [ObservableProperty] private string _passwordHash = string.Empty;
    
    //One-to-many navigation with Pokémon dependents
    public ICollection<PokemonPageModel> Pokemon { get; } = new List<PokemonPageModel>();
    
    //One-to-many navigation with Teams dependents
    public ICollection<TeamsPageModel> Teams { get; } = new List<TeamsPageModel>();
}
