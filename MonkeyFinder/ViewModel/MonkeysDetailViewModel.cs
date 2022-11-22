using CommunityToolkit.Mvvm.ComponentModel;
using MonkeyFinder.Model;

namespace MonkeyFinder.ViewModel
{
    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeysDetailViewModel
        : BaseViewModel
    {

        public MonkeysDetailViewModel()
        {
        }

        [ObservableProperty]
        Monkey monkey;
    }
}

