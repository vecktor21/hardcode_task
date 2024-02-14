namespace TestTask.Gateway.Dtos
{
    public class ItemCategoryFilter
    {
        public string? CategoryNameFilter { get; set; }
        public List<AttributeFilterDto>? AttributeFilters { get; set; }
    }
    public class AttributeFilterDto
    {
        public string AttributeName { get; set; } = null!;
        public string AttributeValue { get; set; } = null!;
    }
}
