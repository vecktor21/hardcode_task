using TestTask.ItemsService.Domain.Dtos;

namespace TestTask.ItemsService.Domain.Models
{
    public class ItemModel
    {
        public int Id { get; private set; }
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; private set; }
        public ItemCategory Category { get; private set; } = null!;
        public ItemModel(int id, string itemName, double price, string? description, ItemCategoryDto category)
        {
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }
            Price = price;
            Id = id;
            ItemName = itemName;
            Description = description ?? string.Empty;
            Category = new ItemCategory(category.CategoryName, category.CategoryAttributes);
        }
    }
}
