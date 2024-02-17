namespace TestTask.Gateway.Dtos
{
    public class CategoryInfoDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<CategoryAttributeInfo> AttributesInfo { get; set; } = new();
    }

    public class CategoryAttributeInfo
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public int AttributeDataTypeId { get; set; }
        public string AttributeDataTypeName { get; set;}
    }
}
