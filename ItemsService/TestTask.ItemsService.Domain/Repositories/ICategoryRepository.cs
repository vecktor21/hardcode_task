using TestTask.ItemsService.Domain.Dtos;

namespace TestTask.ItemsService.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<CategoryInfoDto> GetCategoryById(int id);
        Task<CategoryInfoDto> GetCategoryByName(string name);
        Task CreateCategory(CreateCategoryInfoDto categoryInfo);
        Task UpdateCategory(CategoryInfoDto categoryInfo);
        Task DeleteCategory(int id);
    }
}
