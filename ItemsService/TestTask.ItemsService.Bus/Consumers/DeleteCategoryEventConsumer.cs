using MassTransit;
using TestTask.Bus.Events;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.CategorysService.Bus.Consumers
{
    internal class DeleteCategoryEventConsumer : IConsumer<DeleteCategoryEvent>
    {
        private readonly ILogger<DeleteCategoryEventConsumer> logger;
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoryEventConsumer(ILogger<DeleteCategoryEventConsumer> logger, ICategoryRepository categoryRepository)
        {
            this.logger = logger;
            this.categoryRepository = categoryRepository;
        }
        public async Task Consume(ConsumeContext<DeleteCategoryEvent> context)
        {
            logger.LogInformation($"{nameof(DeleteCategoryEventConsumer)} consumed {nameof(DeleteCategoryEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");

            try
            {
                await categoryRepository.DeleteCategory(context.Message.Id);
                logger.LogInformation($"Category {context.Message.Id} deleted Successfully");

            }
            catch (Exception ex)
            {
                logger.LogError($"Error while deleting category {context.Message.Id}");
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
