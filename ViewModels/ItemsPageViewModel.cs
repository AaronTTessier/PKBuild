using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PKBuild.Data;
using PokeApiNet;

namespace PKBuild.ViewModels;

public partial class ItemsPageViewModel : PkPageViewModel
{
    private ObservableCollection<string>? _searchedItems;

    public ObservableCollection<string>? SearchedItems
    {
        get => _searchedItems;
        set => SetProperty(ref _searchedItems, value);
    }
    
    private ObservableCollection<string>?  _retrievedItems;

    public ObservableCollection<string>? RetrievedItems
    {
        get => _retrievedItems;
        set => SetProperty(ref _retrievedItems, value);
    }

    public ItemsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Items;
        _searchedItems = [];
    }

    [RelayCommand]
    private async Task SearchTest()
    {
        
    }
}