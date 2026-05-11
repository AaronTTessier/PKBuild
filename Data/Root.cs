using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PKBuild.Data;

public class Root
{
    public ObservableCollection<Pokemon> pokemon { get; set; }
}

public class Pokemon
{
    public string name { get; set; }
    public string dex { get; set; }
    public List<string> type { get; set; }
    public List<string> ability { get; set; }
    public Basestats basestats { get; set; }
    
    public override string ToString() => name;
}

public class Basestats(string hp, string atk, string def, string spa, string spd, string spe, string total)
{
    public string Hp { get; set; } = hp;
    public string Atk { get; set; } = atk;
    public string Def { get; set; } = def;
    public string Spa { get; set; } = spa;
    public string Spd { get; set; } = spd;
    public string Spe { get; set; } = spe;
    public string Total { get; set; } = total;
}