using MassTransit;
using TestTask.Bus.Events;

namespace TestTask.ItemsService.Bus.Consumers
{
    internal class DeleteItemEventConsumer : IConsumer<DeleteItemEvent>
    {
        private readonly ILogger<DeleteItemEventConsumer> logger;

        public DeleteItemEventConsumer(ILogger<DeleteItemEventConsumer> logger)
        {
            this.logger = logger;
        }
        public Task Consume(ConsumeContext<DeleteItemEvent> context)
        {
            logger.LogInformation($"{nameof(DeleteItemEventConsumer)} consumed {nameof(DeleteItemEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");
            throw new NotImplementedException();
        }
    }
}
