using TestTask.ItemsService.Domain.Enums;

namespace TestTask.ItemsService.Domain.Dtos
{
    public class UpdatedItemDto
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public UpdatedItemCategoryDto Category { get; set; }
    }
    public class UpdatedItemCategoryDto
    {
        public int Id { get; set; }
        public List<UpdatedItemAttributeDto> Attributes { get; set; }
    }
    public class UpdatedItemAttributeDto
    {
        public int Id { get; set; }
        public object Value { get; set; }
        public CategoryAttributesDataTypes DataType { get; set; }
    }
}
