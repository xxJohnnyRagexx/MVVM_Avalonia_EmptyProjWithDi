using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.DependencyInjection;
using UCB.Desktop.ViewModels;

namespace UCB.Desktop.Views;

public partial class MainMenuView : UserControl
{
    public MainMenuView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetRequiredService<MainMenuViewModel>();
    }
}