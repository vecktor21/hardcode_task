using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Gateway.Dtos;

namespace TestTask.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        /// <summary>
        /// получение информации о категории: доступные атрибуты и их типы
        /// </summary>
        /// <param name="id">id категории</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{id:int}")]
        public Task<CategoryInfoDto> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// получение информации о категории: доступные атрибуты и их типы
        /// </summary>
        /// <param name="name">название категории</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{name}")]
        public Task<CategoryInfoDto> GetCategory(string name)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// создание категории
        /// </summary>
        /// <param name="newCategory">информация о новой категории</param>
        /// <returns></returns>
        [HttpPost]
        public Task CreateCategory([FromBody] CreateCategoryInfoDto newCategory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// изменение информации о категории: изменение доступных атрибутов или их типов данных
        /// </summary>
        /// <param name="updatedCategory"></param>
        /// <returns></returns>
        [HttpPut]
        public Task UpdateCategoryInfo([FromBody]CategoryInfoDto updatedCategory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// удаление категории товаров. удаляет категорию только если нет ни одного товара с этой категорией. 
        /// </summary>
        /// <param name="categoryId">id категории</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">кидает исключение если есть хоть один товар с этой категорией</exception>
        [HttpDelete]
        public Task DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
