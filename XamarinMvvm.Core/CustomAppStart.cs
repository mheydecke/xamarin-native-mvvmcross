using MvvmCross.Core.ViewModels;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm
{
    class CustomAppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {            
            ShowViewModel<ItemDetailViewModel>(new { itemId = 4 });
        }
    }
}
