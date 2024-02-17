namespace TestTask.Bus.Events
{
    internal class CategoryCreatedEvent
    {
        public string CategoryName { get; set; }
        public List<CreateCategoryAttributeInfo> AttributesInfo { get; set; }
    }

    internal class CreateCategoryAttributeInfo
    {
        public string AttributeName { get; set; }
        public int AttributeDataTypeId { get; set; }
    }
}
