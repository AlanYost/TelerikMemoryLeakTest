using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;
using Core = XFMVXTestApp.Core;
using FormsUI = XFMVXTestApp;
using MvvmCross.Forms.Presenters;

namespace XFMVXTestApp.Droid
{
    [Activity(Label = "XFMVXTestApp", MainLauncher = true, Theme = "@style/MainTheme", NoHistory = true)]
    public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<Core.App, FormsUI.App>, Core.App, FormsUI.App>
    {
        
    }
}