using Grpc.Core;
using TestTask.protos.Items;

namespace TestTask.Api.Grpc.Services
{
    public class ItemsServiceImplementation : TestTask.protos.Items.ItemService.ItemServiceBase
    {
        private readonly ILogger<ItemsServiceImplementation> _logger;
        public ItemsServiceImplementation(ILogger<ItemsServiceImplementation> logger)
        {
            _logger = logger;
        }

        public override Task<ItemListResponse> GetItemsByFilter(ItemCategoryFilter request, ServerCallContext context)
        {
            return base.GetItemsByFilter(request, context);
        }

        public override Task<Item> GetItemsById(ItemFilterById request, ServerCallContext context)
        {
            return base.GetItemsById(request, context);
        }
    }
}