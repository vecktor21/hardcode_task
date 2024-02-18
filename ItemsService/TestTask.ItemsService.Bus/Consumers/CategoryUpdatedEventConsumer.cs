using MassTransit;
using TestTask.Bus.Events;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.CategorysService.Bus.Consumers
{
    internal class CategoryUpdatedEventConsumer : IConsumer<CategoryUpdatedEvent>
    {
        private readonly ILogger<CategoryUpdatedEventConsumer> logger;
        private readonly ICategoryRepository categoryRepository;

        public CategoryUpdatedEventConsumer(ILogger<CategoryUpdatedEventConsumer> logger, ICategoryRepository categoryRepository)
        {
            this.logger = logger;
            this.categoryRepository = categoryRepository;
        }
        public async Task Consume(ConsumeContext<CategoryUpdatedEvent> context)
        {
            logger.LogInformation($"{nameof(CategoryUpdatedEventConsumer)} consumed {nameof(CategoryUpdatedEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");

            try
            {
                await categoryRepository.UpdateCategory( new ItemsService.Domain.Dtos.CategoryInfoDto
                {
                    Id = context.Message.Id,
                    CategoryName = context.Message.CategoryName,
                    AttributesInfo = context.Message.AttributesInfo.Select(s => new ItemsService.Domain.Dtos.CategoryAttributeInfo
                    {
                        Id= s.Id,
                        AttributeDataTypeName = s.AttributeDataTypeName,
                        AttributeDataTypeId = s.AttributeDataTypeId,
                        AttributeName = s.AttributeName,
                    })
                    .ToList()
                });
                logger.LogInformation($"Category {context.Message.CategoryName} updated Successfully");

            }
            catch (Exception ex)
            {
                logger.LogError($"Error while updating category {context.Message.CategoryName}");
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
