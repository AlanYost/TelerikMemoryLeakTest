using System;
using System.Collections.ObjectModel;
using MvvmCross;
using MvvmCross.Forms.Views;
using MvvmCross.WeakSubscription;
using Xamarin.Forms.Xaml;
using XFMVXTestApp.Core.ViewModels;
using Yambay.mDrover.Core.Services.Device;

namespace XFMVXTestApp.XF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelerikListViewTestView : MvxContentPage
    {
        public ObservableCollection<TestItem> TestItemsCollection { get; } = new ObservableCollection<TestItem>();

        public TelerikListViewTestViewModel CurrentViewModel
        {
            get { return DataContext as TelerikListViewTestViewModel; }
        }

        public TelerikListViewTestView()
        {
            InitializeComponent();
            var memtracker = Mvx.IoCProvider.Resolve<IMemoryTrackingService>();
            memtracker.Add(this, DeviceConstants.MemoryObjectTypes.View);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (CurrentViewModel != null)
            {
                CurrentViewModel.WeakSubscribe(() => CurrentViewModel.TestItemsUpdated, (s, e) => RefreshTestItemsCollection());
            }
        }

        private void RefreshTestItemsCollection()
        {
            try
            {

                TestItemsCollection.Clear();

                foreach (var record in CurrentViewModel.TestItems)
                {
                    if (CurrentViewModel.IsExpanded || (int.Parse(record.SequenceNumber) % 2 == 0))
                    {
                        TestItemsCollection.Add(record);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        void TestListViewItemTemplate_Tapped(System.Object sender, System.EventArgs e)
        {
            TestItemsCollection.Clear();
            dataGrid.ItemsSource = null;
            this.DataContext = null;
        }

        void TestListView_NativeControlLoaded(System.Object sender, System.EventArgs e)
        {
            RefreshTestItemsCollection();
        }
    }
}
