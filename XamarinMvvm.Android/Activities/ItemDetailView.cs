using Android.App;
using MvvmCross.Droid.Views;

namespace XamarinMvvm.Droid.Activities
{
    [Activity(Label = "Item Detail")]
    public class ItemDetailView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.ItemDetail);
        }
    }
}