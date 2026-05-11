using System.Collections.Generic;

namespace PKBuild.Data;

public class Pokemon
{
    public string name { get; set; }
    public string dex { get; set; }
    public List<string> type { get; set; }
    public List<string> ability { get; set; }
    public Basestats basestats { get; set; }

    //public override string ToString() => name;
}