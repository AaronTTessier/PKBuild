using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PKBuild.Data;
using PKBuild.Models;

namespace PKBuild.ViewModels;

public partial class TeamsPageViewModel : PkPageViewModel
{
    public ObservableCollection<PokemonPageModel>? PokemonTeamList;
    
    [ObservableProperty]
    public partial Root? PokedexList { get; set; }
    public ObservableCollection<int> PokemonEvs { get; set; } = [0, 0, 0, 0, 0, 0];
    public Items[] Pokeballs { get; } = Enum.GetValues<Items>();
    public Nature[] Natures { get; } = Enum.GetValues<Nature>();

    [ObservableProperty]
    private Pokemon? _selectedPokemon;
    
    [ObservableProperty]
    private Items _selectedPokeBallItem;
    
    [RelayCommand]
    private void ChangePokemon()
    {
        
    }

    [RelayCommand]
    private void GatherPokemon()
    {
        // TODO: Fetch from database of currently logged in user
    }

    private static Root? RetrievePokedexFromJson()
    {
        using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PKBuild.Data.Pokemon.json")!;
        using StreamReader reader = new StreamReader(stream);
        string json = reader.ReadToEnd();
        return JsonSerializer.Deserialize<Root>(json);
    }
    
    public TeamsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Teams;
        PokedexList = RetrievePokedexFromJson();
        GatherPokemon();
    }
}