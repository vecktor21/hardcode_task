
namespace TestTask.ItemsService.Domain.Dtos
{
    public class ItemCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<CategoryAttributeDto> CategoryAttributes { get; set; } = null!;
    }
}
