using Prism.Navigation;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BlankApp1.ViewModels
{
    public class SplashPageViewModel : ViewModelBase
    {
        public SplashPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            Debug.WriteLine($"URI: {NavigationService.GetNavigationUriPath()}");
            await NavigationService.NavigateAsync("app:///RootPage/NavigationPage/MainPage");
            Debug.WriteLine($"URI: {NavigationService.GetNavigationUriPath()}");
        }
    }
}
