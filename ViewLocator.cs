using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Microsoft.Extensions.DependencyInjection;
using PKBuild.Data;
using PKBuild.ViewModels;
using PKBuild.Views;

namespace PKBuild;

public class ViewLocator : IDataTemplate
{
    /*private readonly IServiceProvider _serviceProvider;

    public ViewLocator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }*/
    public Control? Build(object? expectedViewModel)
    {
        /*return expectedViewModel switch
        {
            TeamsPageViewModel => _serviceProvider.GetRequiredService<TeamsPageView>(),
            _ => new TextBlock { Text = $"No view for {expectedViewModel.GetType().Name}" }
        };*/
        if (expectedViewModel is null)
        {
            return null;
        }

        var dataViewName = expectedViewModel.GetType().FullName!.Replace("ViewModel", "View");
        var viewType = Type.GetType(dataViewName);

        if (viewType is null)
        {
            return null;
        }

        var control = (Control)Activator.CreateInstance(viewType)!;

        control.DataContext= expectedViewModel;

        return control;
    }

    public bool Match(object? expectedViewModel) => expectedViewModel is ViewModelBase or DialogViewModel;
}