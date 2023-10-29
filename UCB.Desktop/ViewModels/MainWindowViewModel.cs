namespace UCB.Desktop.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _content;
    private readonly MainMenuViewModel _mainMenuViewModel;
    
    public ViewModelBase Content
    {
        get => _content;
        set => this.SetProperty(ref _content, value);
    }

    public MainWindowViewModel(MainMenuViewModel mainMenuViewModel)
    {
        _mainMenuViewModel = mainMenuViewModel;

        Content = _mainMenuViewModel;
    }
}
