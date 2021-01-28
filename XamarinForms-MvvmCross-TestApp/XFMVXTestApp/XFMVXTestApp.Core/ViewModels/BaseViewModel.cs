using System;
using MvvmCross;
using MvvmCross.ViewModels;
using Yambay.mDrover.Core.Services.Device;

namespace XFMVXTestApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel()
        {
            var memoryTrackingService = Mvx.IoCProvider.Resolve<IMemoryTrackingService>();
            memoryTrackingService.Add(this, DeviceConstants.MemoryObjectTypes.ViewModel);
        }
    }
}
