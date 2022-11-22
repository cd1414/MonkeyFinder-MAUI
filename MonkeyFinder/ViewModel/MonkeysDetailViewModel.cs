using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Model;

namespace MonkeyFinder.ViewModel
{
    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeysDetailViewModel
        : BaseViewModel
    {

        IMap map;

        public MonkeysDetailViewModel(IMap map)
        {
            this.map = map;
        }

        [ObservableProperty]
        Monkey monkey;

        [RelayCommand]
        async Task OpenMapAsync()
        {
            try
            {
                await map.TryOpenAsync(monkey.Latitude, monkey.Longitude, new MapLaunchOptions { Name = monkey.Name, NavigationMode = NavigationMode.None });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", $"Unable to open map: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
