using MassTransit;
using TestTask.Bus.Events;

namespace TestTask.CategorysService.Bus.Consumers
{
    internal class CategoryCreatedEventConsumer : IConsumer<CategoryCreatedEvent>
    {
        private readonly ILogger<CategoryCreatedEventConsumer> logger;

        public CategoryCreatedEventConsumer(ILogger<CategoryCreatedEventConsumer> logger)
        {
            this.logger = logger;
        }
        public Task Consume(ConsumeContext<CategoryCreatedEvent> context)
        {
            logger.LogInformation($"{nameof(CategoryCreatedEventConsumer)} consumed {nameof(CategoryCreatedEvent)}");
            throw new NotImplementedException();
        }
    }
}
