using System.Collections.Generic;
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

    public List<Pokemon>? PokedexList { get; set; }
    private Root? PokemonRoot { get; }

    [ObservableProperty]
    private Pokemon? _selectedPokemon;

    public ObservableCollection<int> PokemonEvs { get; set; } = [0, 0, 0, 0, 0, 0];
    
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

    private List<Pokemon> LoadPokemonFromJson()
    { 
        List<Pokemon> list = new();
        foreach (Pokemon pkmn in PokemonRoot!.pokemon)
        {
            list.Add(pkmn);
        }

        return list;
    }
    
    public TeamsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Teams;
        PokemonRoot = RetrievePokedexFromJson();
        PokedexList = LoadPokemonFromJson();
        GatherPokemon();
    }
}