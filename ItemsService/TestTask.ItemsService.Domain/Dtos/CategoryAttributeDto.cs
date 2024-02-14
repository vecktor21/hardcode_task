using TestTask.ItemsService.Domain.Enums;

namespace TestTask.ItemsService.Domain.Dtos
{
    public class CategoryAttributeDto
    {
        public int CategoryAttributeId { get; set; } 
        public string AttributeName { get; set; } = null!;
        public CategoryAttributesDataTypes AttributesDataType { get; set; }
        public object Value { get; set; } = null!;

    }
}
