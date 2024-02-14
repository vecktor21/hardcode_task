namespace TestTask.Gateway.Dtos
{
    public class ItemDto
    {
        /// <summary>
        /// id товара
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// название товара
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// описание товара
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// цена на товар
        /// </summary>
        public double Price { get; private set; }
        /// <summary>
        /// категория товара
        /// </summary>
        public CategoryDto Category { get; private set; }
    }
}
