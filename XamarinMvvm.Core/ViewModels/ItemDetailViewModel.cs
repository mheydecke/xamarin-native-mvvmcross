using MvvmCross.Core.ViewModels;
using XamarinMvvm.Services;

namespace XamarinMvvm.ViewModels
{
    public class ItemDetailViewModel : MvxViewModel
    {
        private readonly IItemService _itemService;

        private string _description;


        public ItemDetailViewModel(IItemService itemService)
        {
            _itemService = itemService;
        }        

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        public async void Init(int itemId)
        {
            var item = await _itemService.GetItemAsync(itemId);
            Description = item.Description;
        }
    }
}
