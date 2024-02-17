using MassTransit;
using TestTask.Bus.Events;

namespace TestTask.ItemsService.Bus.Consumers
{
    internal class UpdateItemEventConsumer : IConsumer<UpdateItemEvent>
    {
        private readonly ILogger<UpdateItemEventConsumer> logger;

        public UpdateItemEventConsumer(ILogger<UpdateItemEventConsumer> logger)
        {
            this.logger = logger;
        }
        public Task Consume(ConsumeContext<UpdateItemEvent> context)
        {
            logger.LogInformation($"{nameof(UpdateItemEventConsumer)} consumed {nameof(UpdateItemEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");
            throw new NotImplementedException();
        }
    }
}
