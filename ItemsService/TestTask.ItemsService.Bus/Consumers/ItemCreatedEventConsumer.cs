using MassTransit;
using TestTask.Bus.Events;

namespace TestTask.ItemsService.Bus.Consumers
{
    internal class ItemCreatedEventConsumer : IConsumer<ItemCreatedEvent>
    {
        private readonly ILogger<ItemCreatedEventConsumer> logger;

        public ItemCreatedEventConsumer(ILogger<ItemCreatedEventConsumer> logger)
        {
            this.logger = logger;
        }
        public Task Consume(ConsumeContext<ItemCreatedEvent> context)
        {
            logger.LogInformation($"{nameof(ItemCreatedEventConsumer)} consumed {nameof(ItemCreatedEvent)}");
            throw new NotImplementedException();
        }
    }
}
