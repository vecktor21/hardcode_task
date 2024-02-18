namespace TestTask.ItemsService.Domain.Dtos
{
    public class CreateCategoryInfoDto
    {
        public string CategoryName { get; set; }
        public List<CreateCategoryAttributeInfo> AttributesInfo { get; set; }
    }

    public class CreateCategoryAttributeInfo
    {
        public string AttributeName { get; set; }
        public int AttributeDataTypeId { get; set; }
    }
}
