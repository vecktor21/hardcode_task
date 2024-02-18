using MassTransit;
using TestTask.Bus.Events;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.CategorysService.Bus.Consumers
{
    internal class CategoryCreatedEventConsumer : IConsumer<CategoryCreatedEvent>
    {
        private readonly ILogger<CategoryCreatedEventConsumer> logger;
        private readonly ICategoryRepository categoryRepository;

        public CategoryCreatedEventConsumer(ILogger<CategoryCreatedEventConsumer> logger, ICategoryRepository categoryRepository)
        {
            this.logger = logger;
            this.categoryRepository = categoryRepository;
        }
        public async Task Consume(ConsumeContext<CategoryCreatedEvent> context)
        {
            logger.LogInformation($"{nameof(CategoryCreatedEventConsumer)} consumed {nameof(CategoryCreatedEvent)}");

            try
            {
                await categoryRepository.CreateCategory(new ItemsService.Domain.Dtos.CreateCategoryInfoDto
                {
                    CategoryName = context.Message.CategoryName,
                    AttributesInfo = context.Message.AttributesInfo.Select(s => new ItemsService.Domain.Dtos.CreateCategoryAttributeInfo
                    {
                        AttributeDataTypeId = s.AttributeDataTypeId,
                        AttributeName = s.AttributeName,
                    })
                .ToList()
                });
                logger.LogInformation($"Category {context.Message.CategoryName} created Successfully");

            }catch (Exception ex)
            {
                logger.LogError($"Error while creating category {context.Message.CategoryName}");
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
