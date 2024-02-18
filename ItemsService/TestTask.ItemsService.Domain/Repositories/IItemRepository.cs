using TestTask.ItemsService.Domain.Dtos;
using TestTask.ItemsService.Domain.Models;

namespace TestTask.ItemsService.Domain.Repositories
{
    public interface IItemRepository
    {
        Task<ItemModel> FindItemById(int id);
        Task<List<ItemModel>> FindItemByFilter(ItemCategoryFilter filter);
        Task CreateItem(CreateItemDto item);
        Task UpdateItem(UpdatedItemDto item);
        Task DeleteItem(int id);
    }
}
