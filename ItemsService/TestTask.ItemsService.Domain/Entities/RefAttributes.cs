using TestTask.ItemsService.Domain.Enums;

namespace TestTask.ItemsService.Domain.Entities
{
    public class RefAttributes
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public CategoryAttributesDataTypes DataType { get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
