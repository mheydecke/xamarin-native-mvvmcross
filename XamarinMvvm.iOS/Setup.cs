using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;
using XamarinMvvm.Core;
using MvvmCross.iOS.Views.Presenters;

namespace XamarinMvvm.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
            : base(appDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}