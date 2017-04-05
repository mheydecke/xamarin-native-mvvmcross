using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinMvvm.Model;

namespace XamarinMvvm.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAllAsync();
        Task<Item> GetItemAsync(int id);
    }
}
