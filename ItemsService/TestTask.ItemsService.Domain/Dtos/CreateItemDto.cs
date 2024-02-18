using TestTask.ItemsService.Domain.Enums;

namespace TestTask.ItemsService.Domain.Dtos
{
    public class CreateItemDto
    {
        public string ItemName { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public CreateCategoryDto Category { get; set; }
    }

    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }
        public List<CreateCategoryAttributeDto> Attributes { get; set; }
    }
    public class CreateCategoryAttributeDto
    {
        public string AttributeName { get; set; }
        public object Value { get; set; }
        public CategoryAttributesDataTypes DataType { get; set; }
    }
}
