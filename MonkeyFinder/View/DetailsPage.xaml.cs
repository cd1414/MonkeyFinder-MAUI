using MonkeyFinder.ViewModel;

namespace MonkeyFinder.View;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(MonkeysDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
