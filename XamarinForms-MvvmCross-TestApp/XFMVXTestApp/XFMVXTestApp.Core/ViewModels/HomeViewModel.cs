using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Yambay.mDrover.Core.Services.Device;

namespace XFMVXTestApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Properties

        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private string _debugInfo;
        public string DebugInfo
        {
            get { return _debugInfo; }
            set { SetProperty(ref _debugInfo, value); }
        }

        private string _numberOfItems = "50";
        public string NumberOfItems
        {
            get { return _numberOfItems; }
            set { SetProperty(ref _numberOfItems, value); }
        }

        #endregion

        #region Commands

        public IMvxCommand ShowListViewCommand => new MvxCommand(ShowListViewHandler);
        private void ShowListViewHandler()
        {
            if (int.TryParse(NumberOfItems, out int numberOfItems))
            {
                _navService.Navigate<ListViewTestViewModel, ListViewTestParameter>(new ListViewTestParameter(numberOfItems));
            }
        }

        public IMvxCommand ShowTelerikListViewCommand => new MvxCommand(ShowTelerikListViewHandler);
        private void ShowTelerikListViewHandler()
        {
            if (int.TryParse(NumberOfItems, out int numberOfItems))
            {
                _navService.Navigate<TelerikListViewTestViewModel, ListViewTestParameter>(new ListViewTestParameter(numberOfItems));
            }
        }

        public IMvxCommand ShowMemoryUsageCommand => new MvxCommand(ShowMemoryUsageHandler);
        private void ShowMemoryUsageHandler()
        {
            DebugInfo = Mvx.IoCProvider.Resolve<IMemoryTrackingService>()?.LogDebugInfo();
        }

        #endregion

        #region Variables

        IMvxNavigationService _navService;

        #endregion

        public HomeViewModel(IMvxNavigationService navService)
        {
            _navService = navService;
        }

    }
}
