using TestTask.ItemsService.Domain.Dtos;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.ItemsService.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task CreateCategory(CreateCategoryInfoDto categoryInfo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryInfoDto> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryInfoDto> GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(CategoryInfoDto categoryInfo)
        {
            throw new NotImplementedException();
        }
    }
}
