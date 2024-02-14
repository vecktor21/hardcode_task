using Grpc.Core;
using TestTask.Api.Grpc.Items;

namespace TestTask.Api.Grpc.Services
{
    public class ItemsService : Items.Items.ItemsBase
    {
        private readonly ILogger<ItemsService> _logger;
        public ItemsService(ILogger<ItemsService> logger)
        {
            _logger = logger;
        }

    }
}