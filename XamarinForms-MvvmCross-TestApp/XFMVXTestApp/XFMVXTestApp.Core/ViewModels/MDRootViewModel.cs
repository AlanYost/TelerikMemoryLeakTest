using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace XFMVXTestApp.Core.ViewModels
{
    public class MDRootViewModel : MvxViewModel
    {
        private IMvxNavigationService _navService;
        public MDRootViewModel(IMvxNavigationService mvxNavigationService)
        {
            _navService = mvxNavigationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();           
        }

        public override async void ViewAppearing()
        {

            base.ViewAppearing();
            await _navService.Navigate<MenuViewModel>();

        }
    }
}
