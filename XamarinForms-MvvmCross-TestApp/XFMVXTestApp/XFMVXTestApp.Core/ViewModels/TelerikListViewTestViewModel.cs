using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;

namespace XFMVXTestApp.Core.ViewModels
{
    public class TelerikListViewTestViewModel : ListViewTestViewModel
    {

        #region Commands

        #endregion

        public TelerikListViewTestViewModel(
            IMvxNavigationService navService,
            IMvxMessenger messenger) : base(navService, messenger)
        {
        }
    }
  
}
