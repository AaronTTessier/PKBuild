namespace PKBuild.Models;

public class PkmnTeamsJointPageModel
{
    private int _pkmnID { get; set; }
    private int _teamID { get; set; }

    public int PkmnID
    {
        get => _pkmnID;
        set => _pkmnID = value;
    }
    
    public int TeamId
    {
        get => _teamID;
        set => _teamID = value;
    }
}