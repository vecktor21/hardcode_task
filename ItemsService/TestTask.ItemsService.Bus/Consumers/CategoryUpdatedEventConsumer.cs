using MassTransit;
using TestTask.Bus.Events;

namespace TestTask.CategorysService.Bus.Consumers
{
    internal class CategoryUpdatedEventConsumer : IConsumer<CategoryUpdatedEvent>
    {
        private readonly ILogger<CategoryUpdatedEventConsumer> logger;

        public CategoryUpdatedEventConsumer(ILogger<CategoryUpdatedEventConsumer> logger)
        {
            this.logger = logger;
        }
        public Task Consume(ConsumeContext<CategoryUpdatedEvent> context)
        {
            logger.LogInformation($"{nameof(CategoryUpdatedEventConsumer)} consumed {nameof(CategoryUpdatedEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");
            throw new NotImplementedException();
        }
    }
}
