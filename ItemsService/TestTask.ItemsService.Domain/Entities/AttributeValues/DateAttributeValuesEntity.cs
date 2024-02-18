namespace TestTask.ItemsService.Domain.Entities.AttributeValues
{
    internal class DateAttributeValuesEntity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public ItemEntity Item { get; set; }
        public DateTimeOffset Value { get; set; }
        public int RefAttributeId { get; set; }
        public RefAttributes RefAttribute {  get; set; }
    }
}
