using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using PKBuild.ViewModels;
using PKBuild.Views;

namespace PKBuild;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? expectedViewModel)
    {
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

    public bool Match(object? expectedViewModel) => expectedViewModel is ViewModelBase;
}