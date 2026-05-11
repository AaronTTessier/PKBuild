namespace PKBuild.Data;

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