using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TestTask.Gateway.Dtos;
using TestTask.Gateway.Options;
using TestTask.protos.Category;
using TestTask.protos.Items;

namespace TestTask.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        ItemService.ItemServiceClient itemClient;
        private readonly IOptions<GrpcOptions> itemGrpcOptions;
        private readonly ILogger<ItemsController> logger;

        public ItemsController(IOptions<GrpcOptions> itemGrpcOptions, ILogger<ItemsController> logger)
        {
            if (String.IsNullOrEmpty(itemGrpcOptions.Value.ItemsGrpcServer)) throw new ArgumentNullException("Empty Grpc.ItemsGrpcServer value");
            var channel = GrpcChannel.ForAddress(itemGrpcOptions.Value.ItemsGrpcServer);
            itemClient = new ItemService.ItemServiceClient(channel);
            this.logger = logger;
            this.itemGrpcOptions = itemGrpcOptions;
        }
        /// <summary>
        /// детальная информация о товаре
        /// </summary>
        /// <param name="itemId">id товара</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{itemId:int}")]
        public async Task<ItemDto> GetItemById(int itemId)
        {
            try
            {
                var result = await itemClient.GetItemsByIdAsync(new ItemFilterById { Id = itemId });

                return ItemGrpcResponseToItemDto(result);
            }
            catch (RpcException rpcEx)
            {
                logger.LogError($"Error while executing gRPC request; Status: {rpcEx.StatusCode}");
                logger.LogError(rpcEx.Message);
                logger.LogError(rpcEx.StackTrace);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// получение товаров по фильтрам: название категории, или по атрибутам категории
        /// </summary>
        /// <param name="filter">фильтр по категориям или атрибутам категории</param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<List<ItemDto>> GetItemsByFilter(Dtos.ItemCategoryFilter filter)
        {
            var rpcFilter = new protos.Items.ItemCategoryFilter
            {
                CategoryNameFilter = filter.CategoryNameFilter,
                AttributeFilters = {filter.AttributeFilters?.Select(s => new AttributeFilter
                {
                    AttributeName = s.AttributeName ?? "",
                    AttributeValue = s.AttributeValue?.ToString()

                })}
            };

            try
            {
                var result = await itemClient.GetItemsByFilterAsync(rpcFilter);

                return result.Items.Select(s=>  ItemGrpcResponseToItemDto(s)).ToList();
            }
            catch (RpcException rpcEx)
            {
                logger.LogError($"Error while executing gRPC request; Status: {rpcEx.StatusCode}");
                logger.LogError(rpcEx.Message);
                logger.LogError(rpcEx.StackTrace);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
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



        private static ItemDto ItemGrpcResponseToItemDto(Item item)
        {
            ItemDto itemResult = new ItemDto
            {
                Description = item.Description,
                Id = item.Id,
                ItemName = item.ItemName,
                Price = item.Price,
                Category = CategoryGrpcResponseToCategoryDto(item.Category)
            };

            return itemResult;
        }



        private static CategoryDto CategoryGrpcResponseToCategoryDto(protos.Items.Category category)
        {
            CategoryDto categoryDto = new CategoryDto
            {
                CategoryName = category.CategoryName,
                Id = category.Id,
                Attributes = category.Attributes
                    .Select(s => new CategoryAttributeDto
                    {
                        AttributeName = s.AttributeName,
                        DataType = s.DataType,
                        Id = s.Id,
                        Value = s.Value
                    })
                    .ToList()
            };

            return categoryDto;
        }
    }
}
