using System;
using System.Collections.Generic;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;

namespace XFMVXTestApp.XF.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, Title = "Menu")]

    public partial class MenuPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
    }
}
