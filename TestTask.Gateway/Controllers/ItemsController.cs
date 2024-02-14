using Microsoft.AspNetCore.Mvc;
using TestTask.Gateway.Dtos;

namespace TestTask.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        /// <summary>
        /// детальная информация о товаре
        /// </summary>
        /// <param name="itemId">id товара</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{itemId:int}")]
        public Task<ItemDto> GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// получение товаров по фильтрам: название категории, или по атрибутам категории
        /// </summary>
        /// <param name="filter">фильтр по категориям или атрибутам категории</param>
        /// <returns></returns>
        [HttpGet("filter")]
        public Task<List<ItemDto>> GetItemsByFilter(ItemCategoryFilter filter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// создание товара с информацией по категории
        /// </summary>
        /// <param name="newItem">информация о товаре</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task CreateItem([FromBody] CreateItemDto newItem)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// изменение информации о товаре
        /// </summary>
        /// <param name="updatedItem">информация о товаре</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task UpdateItem([FromBody] ItemDto updatedItem)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// удаление товара
        /// </summary>
        /// <param name="itemId">id товара</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpDelete("{itemId:int}")]
        public Task UpdateItem(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
