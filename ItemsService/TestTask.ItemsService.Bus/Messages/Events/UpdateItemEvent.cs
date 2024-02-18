namespace TestTask.Bus.Events
{
    internal class UpdateItemEvent
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
    internal class Category
    {
        public int Id { get; set; }
        public List<CategoryAttribute> Attributes { get; set; }
    }
    internal class CategoryAttribute
    {
        public int Id { get; set; }
        public object Value { get; set; }
        public int DataType { get; set; }
    }
}
