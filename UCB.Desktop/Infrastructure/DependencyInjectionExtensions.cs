using Microsoft.Extensions.DependencyInjection;
using UCB.Desktop.ViewModels;

namespace UCB.Desktop.Infrastructure;

/// <summary>
/// Use this static class for service registration.
/// </summary>
public static class DependencyInjectionExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection _services)
    {
        return _services;
    }

    /// <summary>
    /// Adds the view models to the DI container.
    /// </summary>
    /// <param name="_service"><see cref="IServiceCollection"/></param>
    /// <returns><see cref="IServiceCollection"/></returns>
    public static IServiceCollection RegisterViewModels(this IServiceCollection _services)
    {
        return _services
            .AddTransient<MainWindowViewModel>()
            .AddTransient<MainMenuViewModel>();
    }
}