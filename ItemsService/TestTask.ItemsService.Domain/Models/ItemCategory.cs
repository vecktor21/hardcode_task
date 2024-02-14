using TestTask.ItemsService.Domain.Dtos;
using TestTask.ItemsService.Domain.Enums;

namespace TestTask.ItemsService.Domain.Models
{
    public class ItemCategory
    {
        public int Id { get; private set; }
        public string CategoryName { get; private set; } = null!;
        public List<СategoryAttributeModel> Attributes { get; private set; } = null!;

        public ItemCategory(string categoryName, List<CategoryAttributeDto> attributes)
        {
            CategoryName = categoryName;
            Attributes = attributes
                .Select(s => new СategoryAttributeModel(s.CategoryAttributeId, s.AttributeName, s.Value, s.AttributesDataType))
                .ToList();
        }

        public void AddNewAtribute(CategoryAttributeDto newAttribute)
        {
            var existingAttribute = Attributes.Where(x => newAttribute.AttributeName == x.AttributeName).FirstOrDefault();

            if (existingAttribute != null)
            {
                throw new ArgumentException($"Already exists attribute with name {newAttribute.AttributeName}");
            }

            Attributes.Add(new СategoryAttributeModel(newAttribute.CategoryAttributeId, newAttribute.AttributeName, newAttribute.Value, newAttribute.AttributesDataType));
        }

        public void SetExistingAttributeValue(int attributeId, CategoryAttributesDataTypes attributeType, object value)
        {
            var attribute = Attributes.Where(x => x.Id == attributeId && x.DataType == attributeType).FirstOrDefault();
            if (attribute == null)
            {
                throw new ArgumentException($"Cant find attribute for category: {CategoryName} with Id: {attributeId} DataType {attributeType}");
            }
            attribute.SetValue(attributeType, value);
        }

        public void SetExistingAttributeValue(string attributeName, CategoryAttributesDataTypes attributeType, object value)
        {
            var attribute = Attributes.Where(x => x.AttributeName== attributeName && x.DataType == attributeType).FirstOrDefault();
            if (attribute == null)
            {
                throw new ArgumentException($"Cant find attribute for category: {CategoryName} with attributeName: {attributeName} DataType {attributeType}");
            }
            attribute.SetValue(attributeType, value);
        }
    }
}