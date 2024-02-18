namespace TestTask.ItemsService.Domain.Entities
{
    internal class CategoryEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<ItemEntity> Items { get; set; }
    }
}
