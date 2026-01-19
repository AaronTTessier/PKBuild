using Avalonia.Controls;
using Avalonia.Controls.Templates;
using PKBuild.ViewModels;

namespace PKBuild;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        return null;
    }

    public bool Match(object? data) => data is ViewModelBase;
}