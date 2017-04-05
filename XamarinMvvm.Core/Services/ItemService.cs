using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinMvvm.Model;

namespace XamarinMvvm.Services
{
    public class ItemService : IItemService
    {
        Dictionary<int, Item> _itemRepo = new Dictionary<int, Item>
        {
            { 0, new Item(0, "Laptop") },
            { 1, new Item(1, "Dockingstation") },
            { 2, new Item(2, "Telephone") },
            { 3, new Item(3, "Display") },
            { 4, new Item(4, "Smartphone") },
            { 5, new Item(5, "Waterbottle") },
            { 6, new Item(6, "Cable") },
            { 7, new Item(7, "Cup") },
            { 8, new Item(8, "Paper") },
        };

        public async Task<List<Item>> GetAllAsync()
        {
            return await Task.FromResult(_itemRepo.Values.ToList());
        }

        public async Task<Item> GetItemAsync(int id)
        {
            if (!_itemRepo.ContainsKey(id))
                return null;

            return await Task.FromResult(_itemRepo[id]);
        }
    }
}
