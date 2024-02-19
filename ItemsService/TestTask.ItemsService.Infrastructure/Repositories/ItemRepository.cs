using TestTask.ItemsService.Domain.Dtos;
using TestTask.ItemsService.Domain.Models;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.ItemsService.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public Task CreateItem(CreateItemDto item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemModel>> FindItemByFilter(ItemCategoryFilter id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemModel> FindItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItem(UpdatedItemDto item)
        {
            throw new NotImplementedException();
        }
    }
}
