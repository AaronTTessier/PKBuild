using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
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
    
    [ObservableProperty] private string _errMessage = "";
    
    [ObservableProperty] private bool _confirmedLogin;

    [ObservableProperty] private string _username = "";
    
    [ObservableProperty] private string _password = "";

    public LoginDialogViewModel()
    {
        
    }
    
    /*public LoginDialogViewModel(DbFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }*/
    
    [RelayCommand]
    public void Login()
    {
        ConfirmedLogin = true;
        CloseDialog();
    }

    [RelayCommand]
    public void CancelLogin()
    {
        ConfirmedLogin = false;
        CloseDialog();
    }
    
}