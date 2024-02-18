using MassTransit;
using TestTask.Bus.Events;
using TestTask.CategorysService.Bus.Consumers;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.ItemsService.Bus.Consumers
{
    internal class DeleteItemEventConsumer : IConsumer<DeleteItemEvent>
    {
        private readonly ILogger<DeleteItemEventConsumer> logger;
        private readonly IItemRepository itemRepository;

        public DeleteItemEventConsumer(ILogger<DeleteItemEventConsumer> logger, IItemRepository itemRepository)
        {
            this.logger = logger;
            this.itemRepository = itemRepository;
        }
        public async Task Consume(ConsumeContext<DeleteItemEvent> context)
        {
            logger.LogInformation($"{nameof(DeleteItemEventConsumer)} consumed {nameof(DeleteItemEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");

            try
            {
                await itemRepository.DeleteItem(context.Message.Id);
                logger.LogInformation($"Item {context.Message.Id} deleted Successfully");

            }
            catch (Exception ex)
            {
                logger.LogError($"Error while deleting item {context.Message.Id}");
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
