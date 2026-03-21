using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PKBuild.Data;
using PKBuild.Factory;
using PKBuild.Models;
using PKBuild.Services;
using PKBuild.ViewModels;

namespace PKBuild;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var collection = new ServiceCollection();
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddTransient<BoxPageViewModel>();
        collection.AddTransient<PokemonPageViewModel>();
        collection.AddTransient<ItemsPageViewModel>();
        collection.AddTransient<MovesPageViewModel>();
        collection.AddTransient<TeamsPageViewModel>();
        collection.AddTransient<AnalysisPageViewModel>();
        collection.AddTransient<SettingsPageViewModel>();

        collection.AddSingleton<Func<PkbPageNames, PkPageViewModel>>(x => name => name switch
        {
            PkbPageNames.Boxes => x.GetRequiredService<BoxPageViewModel>(),
            PkbPageNames.Pokemon => x.GetRequiredService<PokemonPageViewModel>(),
            PkbPageNames.Items => x.GetRequiredService<ItemsPageViewModel>(),
            PkbPageNames.Moves => x.GetRequiredService<MovesPageViewModel>(),
            PkbPageNames.Teams => x.GetRequiredService<TeamsPageViewModel>(),
            PkbPageNames.Analysis => x.GetRequiredService<AnalysisPageViewModel>(),
            PkbPageNames.Settings => x.GetRequiredService<SettingsPageViewModel>(),
            _ => throw new InvalidOperationException(),
        });
        
        collection.AddSingleton<PkPageFactory>();

        collection.AddTransient<PKBuildDbContext>();
        collection.AddTransient<PkDatabaseService>();
        
        var services = collection.BuildServiceProvider();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindowView()
            {
                DataContext = services.GetRequiredService<MainWindowViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}