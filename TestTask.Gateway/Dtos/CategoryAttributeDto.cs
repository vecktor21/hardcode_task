namespace TestTask.Gateway.Dtos
{
    public class CategoryAttributeDto
    {
        /// <summary>
        /// id атрибута
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// название атрибута
        /// </summary>
        public string AttributeName { get; set; }
        /// <summary>
        /// значение атрибута
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// тип данных значения
        /// </summary>
        public int DataType { get; set; }
    }
}
