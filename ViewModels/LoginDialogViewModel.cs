using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PKBuild.Factory;

namespace PKBuild.ViewModels;

public partial class LoginDialogViewModel : DialogViewModel
{
    private readonly DbFactory _dbFactory;
    
    [ObservableProperty] private string _dialogTitle = "PKBuild";

    [ObservableProperty] private string _message = "Login to PKBuild";

    [ObservableProperty] private string _confirmText = "Login";

    [ObservableProperty] private string _switchModeText = "Need an account?  Click the Register button to get started.";
    
    [ObservableProperty] private bool _confirmedLogin;

    public LoginDialogViewModel(DbFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }
    
    [RelayCommand]
    public void Login()
    {
        
        CloseDialog();
    }

    [RelayCommand]
    public void CancelLogin()
    {
        ConfirmedLogin = false;
        CloseDialog();
    }
}