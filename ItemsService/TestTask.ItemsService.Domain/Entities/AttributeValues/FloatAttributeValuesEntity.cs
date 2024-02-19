﻿namespace TestTask.ItemsService.Domain.Entities.AttributeValues
{
    public class FloatAttributeValuesEntity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public ItemEntity Item { get; set; }
        public double? Value { get; set; }
        public int RefAttributeId { get; set; }
        public RefAttributes RefAttribute { get; set; }
    }
}
