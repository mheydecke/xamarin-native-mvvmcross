using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm.iOS.Views
{
    public partial class ItemDetailView : MvxViewController<ItemDetailViewModel>
    {
        public ItemDetailView() : base("ItemDetailView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VcDescription).For(label => label.Text).To((ItemDetailViewModel vm) => vm.Description).Apply();
        }
    }
}