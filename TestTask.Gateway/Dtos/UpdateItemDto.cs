namespace TestTask.Gateway.Dtos
{
    public class UpdateItemDto
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public UpdateItemCategoryDto Category { get; set; }
    }
    public class UpdateItemCategoryDto
    {
        public int Id { get; set; }
        public List<UpdateItemAttributeDto> Attributes { get; set; }
    }
    public class UpdateItemAttributeDto
    {
        public int Id { get; set; }
        public object Value { get; set; }
        public int DataType { get; set; }
    }
}
