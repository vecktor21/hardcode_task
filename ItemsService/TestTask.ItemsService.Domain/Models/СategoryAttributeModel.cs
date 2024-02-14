using TestTask.ItemsService.Domain.Enums;

namespace TestTask.ItemsService.Domain.Models
{
    public class СategoryAttributeModel
    {
        public СategoryAttributeModel(int id, string categoryAttributeName, object value, CategoryAttributesDataTypes attributeType)
        {
            Id = id;
            SetValue(attributeType, value);
            DataType = attributeType;
            AttributeName = categoryAttributeName;
        }

        public int Id { get; private set; }
        public string AttributeName { get; private set; } = null!;
        public CategoryAttributesDataTypes DataType { get; private set; }
        public object Value { get; private set; }
        public void SetValue(CategoryAttributesDataTypes dataType, object value)
        {
            if (dataType == DataType) Value = value;
            else throw new ArgumentException($"Provided dataType is other than attribute DataType. Attribute DataType: {nameof(DataType)}; Provided type: {nameof(dataType)}");
        }
        public bool IsNumeric()
        {
            return DataType == CategoryAttributesDataTypes.IntegerValue || DataType == CategoryAttributesDataTypes.FloatValue;
        }
        public bool IsFloat()
        {
            return DataType == CategoryAttributesDataTypes.FloatValue;
        }
        public bool IsInteger()
        {
            return DataType == CategoryAttributesDataTypes.IntegerValue;
        }
        public bool IsString()
        {
            return DataType == CategoryAttributesDataTypes.StringValue;
        }
        public bool IsDate()
        {
            return DataType == CategoryAttributesDataTypes.DateValue;
        }
        public bool IsTime()
        {
            return DataType == CategoryAttributesDataTypes.TimeValue;
        }
    }
}
