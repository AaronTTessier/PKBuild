using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class TeamsPageModel : ObservableObject
{
    [ObservableProperty] private int _teamId = 0;

    [ObservableProperty] private int _userId = 0;

    [ObservableProperty] private string _teamName = string.Empty;

    [ObservableProperty] private bool _favorite = false;
}