namespace TestTask.Bus.Events
{
    internal class ItemCreatedEvent
    {
        public string ItemName { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public CreateCategory Category { get; set; }
    }

    internal class CreateCategory
    {
        public string CategoryName { get; set; }
        public List<CreateCategoryAttribute> Attributes { get; set; }
    }
    internal class CreateCategoryAttribute
    {
        public string AttributeName { get; set; }
        public object Value { get; set; }
        public int DataType { get; set; }
    }
}
