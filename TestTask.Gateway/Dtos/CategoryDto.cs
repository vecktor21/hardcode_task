namespace TestTask.Gateway.Dtos
{
    public class CategoryDto
    {
        /// <summary>
        /// id категории
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// название категории
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// атрибуты категории
        /// </summary>
        public List<CategoryAttributeDto> Attributes { get; set; }
    }
}
