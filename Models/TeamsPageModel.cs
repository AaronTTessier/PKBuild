using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class TeamsPageModel : ObservableObject
{
    [ObservableProperty] private int _teamId = 0;

    [ObservableProperty] private int _userId = 0;

    [ObservableProperty] private string _teamName = string.Empty;

    [ObservableProperty] private bool _favorite = false;
    
    //Required for mapping by convention for EF Core for PkmnTeams Join Table
    public ICollection<PokemonPageModel> Pokemon { get; } = [];
}