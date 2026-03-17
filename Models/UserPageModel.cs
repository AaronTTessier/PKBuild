using CommunityToolkit.Mvvm.ComponentModel;

namespace PKBuild.Models;

public partial class UserPageModel : ObservableObject
{
    [ObservableProperty] private int _userId = 0;
    
    [ObservableProperty] private string _userName = string.Empty;

    [ObservableProperty] private string _firstName = string.Empty;

    [ObservableProperty] private string _email = string.Empty;

    [ObservableProperty] private string _passwordHash = string.Empty;
}