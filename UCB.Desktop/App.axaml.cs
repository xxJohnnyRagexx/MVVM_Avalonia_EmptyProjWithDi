using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using CommunityToolkit.Mvvm.DependencyInjection;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using UCB.Desktop.Infrastructure;
using UCB.Desktop.ViewModels;
using UCB.Desktop.Views;

namespace UCB.Desktop;

public partial class App : Application
{
    private IServiceCollection _serviceCollection;
    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        _serviceCollection = new ServiceCollection();
        Ioc.Default.ConfigureServices(
            _serviceCollection
                .RegisterServices()
                .RegisterViewModels()
                .BuildServiceProvider()
            );
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            BindingPlugins.DataValidators.RemoveAt(0);
            desktop.MainWindow = new MainWindow
            {
                DataContext = Ioc.Default.GetRequiredService<MainWindowViewModel>(),
            };
        }
    
        base.OnFrameworkInitializationCompleted();
    }
}