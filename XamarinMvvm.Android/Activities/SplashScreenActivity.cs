using Android.App;
using MvvmCross.Droid.Views;

namespace XamarinMvvm.Droid.Activities
{
    [Activity(Label = "My App", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity() : base(Resource.Layout.SplashScreen)
        {
        }
    }
}