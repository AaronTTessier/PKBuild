using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class PokemonPageModel : ObservableObject
{
    public int PkmnId { get; init; }
    public int UserId { get; init; }
    
    public int? ItemId { get; init; }
    
    //Required for navigation to parent (User)
    public UserPageModel User { get; set; } = null!;

    //Required for navigation to parent (Base Stats)
    public BaseStatsPageModel BaseStats { get; set; } = null!;
    
    //Required for optional navigation to parent (Items)
    public ItemPageModel? Items { get; set; }

    public int StatId { get; init; }
    public int GenId { get; init; }
    
    //Required for mapping by convention for EF Core for PkmnTeams Join Table
    public ICollection<TeamsPageModel> Teams { get; } = [];

    [ObservableProperty] private int _pkdxRegNum;
    
    [ObservableProperty] private int _pkdxNatNum;

    [ObservableProperty] private int _eVHp;

    [ObservableProperty] private int _eVAtk;

    [ObservableProperty] private int _eVDef;
    
    [ObservableProperty] private int _eVSpA;
    
    [ObservableProperty] private int _eVSpD;
    
    [ObservableProperty] private int _eVSpe;
    
    [ObservableProperty] private int _iVHp;
    
    [ObservableProperty] private int _iVAtk;
    
    [ObservableProperty] private int _iVDef;
    
    [ObservableProperty] private int _iVSpA;
    
    [ObservableProperty] private int _iVSpD;
    
    [ObservableProperty] private int _iVSpe;

    [ObservableProperty] private bool? _alpha;
    
    [ObservableProperty] private bool? _gMax;
    
    [ObservableProperty] private int? _teraBaseType;
    
    [ObservableProperty] private int? _teraOverrideType;
    
}
