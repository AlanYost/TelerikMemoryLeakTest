using System;
using System.Collections.Generic;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;

namespace XFMVXTestApp.XF.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Root, WrapInNavigationPage = true, NoHistory = false, Title = "Root")]
    public partial class MDRootPage
    {
        public MDRootPage()
        {
            InitializeComponent();
        }
    }
}
