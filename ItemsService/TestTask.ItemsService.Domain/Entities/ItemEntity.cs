namespace TestTask.ItemsService.Domain.Entities
{
    internal class ItemEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
