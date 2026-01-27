using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class ItemsPageViewModel : PkPageViewModel
{
    [ObservableProperty] 
    private List<string> _testItems;
    
    public ItemsPageViewModel()
    {
        PkbPageNames = PkbPageNames.Items;
        
        // TEMP: Please remove after testing
        TestItems =
        [
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5"
        ];
    }
    
}