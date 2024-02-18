using Grpc.Core;
using Grpc.Net.Client;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TestTask.Bus.Events;
using TestTask.Gateway.Dtos;
using TestTask.Gateway.Options;
using TestTask.protos.Category;

namespace TestTask.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        TestTask.protos.Category.CategoryService.CategoryServiceClient categoryClient;
        private readonly IOptions<GrpcOptions> categoryGrpcOptions;
        private readonly ILogger<CategoriesController> logger;
        private readonly IBus bus;
        private readonly ISendEndpointProvider sendEndpointProvider;

        public CategoriesController(IOptions<GrpcOptions> categoryGrpcOptions, ILogger<CategoriesController> logger,
            IBus bus, ISendEndpointProvider sendEndpointProvider)
        {
            if (String.IsNullOrEmpty(categoryGrpcOptions.Value.ItemsGrpcServer)) throw new ArgumentNullException("Empty Grpc.ItemsGrpcServer value");
            var channel = GrpcChannel.ForAddress(categoryGrpcOptions.Value.ItemsGrpcServer);
            categoryClient = new CategoryService.CategoryServiceClient(channel);
            this.categoryGrpcOptions = categoryGrpcOptions;
            this.logger = logger;
            this.bus = bus;
            this.sendEndpointProvider = sendEndpointProvider;
        }

        /// <summary>
        /// получение информации о категории: доступные атрибуты и их типы
        /// </summary>
        /// <param name="id">id категории</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{id:int}")]
        public async Task<CategoryInfoDto> GetCategory(int id)
        {
            try
            {
                var result = await categoryClient.GetCategoryByIdAsync(new GetCategoryByIdFilter { Id = id });

                return CategoryGrpcResponseToCategoryInfoDto(result);
            }
            catch(RpcException rpcEx)
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
        /// получение информации о категории: доступные атрибуты и их типы
        /// </summary>
        /// <param name="name">название категории</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{name}")]
        public async Task<CategoryInfoDto> GetCategory(string name)
        {
            try
            {
                var result = await categoryClient.GetCategoryByNameAsync(new GetCategoryByNameFilter { Name = name });

                return CategoryGrpcResponseToCategoryInfoDto(result);
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
        /// создание категории
        /// </summary>
        /// <param name="newCategory">информация о новой категории</param>
        /// <returns></returns>
        [HttpPost]
        public async Task CreateCategory([FromBody] CreateCategoryInfoDto newCategory)
        {
            logger.LogError($"Creating category {newCategory.CategoryName}");
            try
            {
                var result = await categoryClient.GetCategoryByNameAsync(new GetCategoryByNameFilter { Name = newCategory.CategoryName });

                if(result != null || result.Id != 0)
                {
                    logger.LogError($"Category {newCategory.CategoryName} already exists");
                }
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

            await bus.Publish<CategoryCreatedEvent>(new CategoryCreatedEvent
            {
                CategoryName = newCategory.CategoryName,
                AttributesInfo = newCategory.AttributesInfo.Select(s => new Bus.Events.CreateCategoryAttributeInfo
                {
                    AttributeDataTypeId = s.AttributeDataTypeId,
                    AttributeName = s.AttributeName,
                })
                .ToList()
            });
        }

        /// <summary>
        /// изменение информации о категории: изменение доступных атрибутов или их типов данных
        /// </summary>
        /// <param name="updatedCategory"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task UpdateCategoryInfo([FromBody]CategoryInfoDto updatedCategory)
        {
            logger.LogError($"Updating category {updatedCategory.CategoryName}");
            try
            {
                var result = await categoryClient.GetCategoryByNameAsync(new GetCategoryByNameFilter { Name = updatedCategory.CategoryName });

                if (result == null || result.Id == 0)
                {
                    logger.LogError($"Category {updatedCategory.CategoryName} does not exists");
                }
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

            await bus.Publish<CategoryUpdatedEvent>(new CategoryUpdatedEvent
            {
                Id = updatedCategory.Id,
                CategoryName = updatedCategory.CategoryName,
                AttributesInfo = updatedCategory.AttributesInfo.Select(s => new Bus.Events.CategoryAttributeInfo
                {
                    Id = s.Id,
                    AttributeDataTypeId = s.AttributeDataTypeId,
                    AttributeName = s.AttributeName,
                })
                .ToList()
            });
        }

        /// <summary>
        /// удаление категории товаров. удаляет категорию только если нет ни одного товара с этой категорией. 
        /// </summary>
        /// <param name="categoryId">id категории</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">кидает исключение если есть хоть один товар с этой категорией</exception>
        [HttpDelete]
        public async Task DeleteCategory(int categoryId)
        {
            logger.LogError($"Deleting category {categoryId}");
            try
            {
                var result = await categoryClient.GetCategoryByIdAsync(new GetCategoryByIdFilter { Id = categoryId });

                if (result == null || result.Id == 0)
                {
                    logger.LogError($"Category {categoryId} does not exists");
                }
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

            await bus.Publish<DeleteCategoryEvent>(new DeleteCategoryEvent
            {
                Id = categoryId
            });
        }


        private static CategoryInfoDto CategoryGrpcResponseToCategoryInfoDto(protos.Category.Category category)
        {
            CategoryInfoDto categoryInfoDto = new CategoryInfoDto();

            categoryInfoDto.Id = category.Id;
            categoryInfoDto.CategoryName = category.CategoryName;
            categoryInfoDto.AttributesInfo = category.AttributesInfo.Select(s => new Dtos.CategoryAttributeInfo
            {
                    Id = s.Id,
                    AttributeDataTypeId = s.AttributeDataTypeId,
                    AttributeDataTypeName = s.AttributeDataTypeName,
                    AttributeName = s.AttributeName,
                })
                .ToList();

            return categoryInfoDto;
        }
    }
}
