using Grpc.Core;
using TestTask.ItemsService.Domain.Repositories;
using TestTask.protos.Items;

namespace TestTask.Api.Grpc.Services
{
    public class ItemsServiceImplementation : TestTask.protos.Items.ItemService.ItemServiceBase
    {
        private readonly ILogger<ItemsServiceImplementation> _logger;
        private readonly IItemRepository itemRepository;

        public ItemsServiceImplementation(ILogger<ItemsServiceImplementation> logger, IItemRepository itemRepository)
        {
            _logger = logger;
            this.itemRepository = itemRepository;
        }

        public override async Task<ItemListResponse> GetItemsByFilter(ItemCategoryFilter request, ServerCallContext context)
        {
            var foundItem = await itemRepository.FindItemByFilter(new TestTask.ItemsService.Domain.Dtos.ItemCategoryFilter
            {
                CategoryNameFilter = request.CategoryNameFilter,
                AttributeFilters = request.AttributeFilters.Select(s => new ItemsService.Domain.Dtos.AttributeFilterDto
                {
                    AttributeName = s.AttributeName,
                    AttributeValue = s.AttributeValue
                })
                .ToList()
            });

            if (foundItem.Count() == 0)
            {
                return new ItemListResponse { Items = { new List<Item>() } };
            }

            var itemsresponse = new ItemListResponse
            {
                Items = { foundItem.Select(s =>
                    new Item()
                    {
                        Id = s.Id,
                        Price = s.Price,
                        ItemName = s.ItemName,
                        Description = s.Description,
                        Category = new Category
                        {
                            Id = s.Category.Id,
                            CategoryName = s.Category.CategoryName,
                            Attributes ={ s.Category.Attributes.Select(a=> new CategoryAttribute
                            {
                                AttributeName=a.AttributeName,
                                DataType=(int)a.DataType,
                                Id=a.Id,
                                Value=a.Value.ToString()
                            })}
                        }
                    })
                }
            };

            return itemsresponse;

        }

        public override async Task<Item> GetItemsById(ItemFilterById request, ServerCallContext context)
        {
            var item = await itemRepository.FindItemById(request.Id);

            if (item == null)
            {
                return new Item { Id = 0 };
            }

            var responseItem = new Item
            {
                Id = item.Id,
                Price = item.Price,
                ItemName = item.ItemName,
                Description = item.Description,
                Category = new Category
                {
                    Id = item.Category.Id,
                    CategoryName = item.Category.CategoryName,
                    Attributes ={ item.Category.Attributes.Select(a=> new CategoryAttribute
                    {
                        AttributeName=a.AttributeName,
                        DataType=(int)a.DataType,
                        Id=a.Id,
                        Value=a.Value.ToString()
                    })}
                }
            };

            return responseItem;
        }
    }
}