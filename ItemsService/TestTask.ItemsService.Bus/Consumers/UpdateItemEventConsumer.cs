using MassTransit;
using TestTask.Bus.Events;
using TestTask.ItemsService.Domain.Enums;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.ItemsService.Bus.Consumers
{
    internal class UpdateItemEventConsumer : IConsumer<UpdateItemEvent>
    {
        private readonly ILogger<UpdateItemEventConsumer> logger;
        private readonly IItemRepository itemRepository;

        public UpdateItemEventConsumer(ILogger<UpdateItemEventConsumer> logger, IItemRepository itemRepository)
        {
            this.logger = logger;
            this.itemRepository = itemRepository;
        }
        public async Task Consume(ConsumeContext<UpdateItemEvent> context)
        {
            logger.LogInformation($"{nameof(UpdateItemEventConsumer)} consumed {nameof(UpdateItemEvent)}");
            logger.LogInformation($"CorrelationId {context.CorrelationId}");

            try
            {
                await itemRepository.UpdateItem(new ItemsService.Domain.Dtos.UpdatedItemDto
                {
                    Id = context.Message.Id,
                    Description = context.Message.Description,
                    Price = context.Message.Price,
                    ItemName = context.Message.ItemName,
                    Category = new Domain.Dtos.UpdatedItemCategoryDto
                    {
                        Id = context.Message.Category.Id,
                        Attributes = context.Message.Category.Attributes.Select(s=> new Domain.Dtos.UpdatedItemAttributeDto
                        {
                            Id =s.Id,
                            Value = s.Value,
                            DataType = (CategoryAttributesDataTypes) s.DataType
                        })
                        .ToList()
                    }
                });
                logger.LogInformation($"Item {context.Message.Id} updated Successfully");
            }
            catch (Exception ex)
            {
                logger.LogError($"Error while updating item {context.Message.Id}");
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
