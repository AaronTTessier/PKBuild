using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class PokemonPageModel : ObservableObject
{
    public int PkmnId { get; set; }
    public int UserId { get; set; }
    public int StatId { get; set; }
    public int GenId { get; set; }

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

    public PokemonPageModel()
    {
        PkmnId = 0;
        UserId = 0;
        StatId = 0;
        GenId = 0;
        PkdxRegNum = 1996;
        PkdxNatNum = 1996;
        EVHp = 0;
        EVAtk = 0;
        EVDef = 0;
        EVSpA = 0;
        EVSpD = 0;
        EVSpe = 0;
        
        IVHp = 0;
        IVAtk = 0;
        IVDef = 0;
        IVSpA = 0;
        IVSpD = 0;
        IVSpe = 0;
    }
}
