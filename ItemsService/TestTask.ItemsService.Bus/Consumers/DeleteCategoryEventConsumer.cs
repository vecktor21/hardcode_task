using MassTransit;
using TestTask.Bus.Events;

namespace TestTask.CategorysService.Bus.Consumers
{
    internal class DeleteCategoryEventConsumer : IConsumer<DeleteCategoryEvent>
    {
        private readonly ILogger<DeleteCategoryEventConsumer> logger;

        public DeleteCategoryEventConsumer(ILogger<DeleteCategoryEventConsumer> logger)
        {
            this.logger = logger;
        }
        public Task Consume(ConsumeContext<DeleteCategoryEvent> context)
        {
            logger.LogInformation($"{nameof(DeleteCategoryEventConsumer)} consumed {nameof(DeleteCategoryEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");
            throw new NotImplementedException();
        }
    }
}
