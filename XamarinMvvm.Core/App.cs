using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using XamarinMvvm.Services;

namespace XamarinMvvm
{
    public class App : MvxApplication
    {
        public App()
        {
            Bootstrap();
        }

        private void Bootstrap()
        {
            Mvx.RegisterType<IItemService, ItemService>();

            var appStart = new CustomAppStart();
            Mvx.RegisterSingleton<IMvxAppStart>(appStart);
        }
    }
}
