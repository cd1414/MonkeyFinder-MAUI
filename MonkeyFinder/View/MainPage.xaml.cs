namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{

    public MainPage(ViewModel.MonkeysViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}


