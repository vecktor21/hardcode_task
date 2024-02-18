using MassTransit;
using TestTask.Bus.Events;
using TestTask.ItemsService.Domain.Enums;
using TestTask.ItemsService.Domain.Repositories;

namespace TestTask.ItemsService.Bus.Consumers
{
    internal class ItemCreatedEventConsumer : IConsumer<ItemCreatedEvent>
    {
        private readonly ILogger<ItemCreatedEventConsumer> logger;
        private readonly IItemRepository itemRepository;

        public ItemCreatedEventConsumer(ILogger<ItemCreatedEventConsumer> logger, IItemRepository itemRepository)
        {
            this.logger = logger;
            this.itemRepository = itemRepository;
        }
        public async Task Consume(ConsumeContext<ItemCreatedEvent> context)
        {
            logger.LogInformation($"{nameof(ItemCreatedEventConsumer)} consumed {nameof(ItemCreatedEvent)}");


            try
            {
                await itemRepository.CreateItem(new Domain.Dtos.CreateItemDto
                {
                    ItemName = context.Message.ItemName,
                    Price = context.Message.Price,
                    Description = context.Message.Description,
                    Category = new Domain.Dtos.CreateCategoryDto
                    {
                        CategoryName=context.Message.Category.CategoryName,
                        Attributes = context.Message.Category.Attributes.Select(s=> new Domain.Dtos.CreateCategoryAttributeDto
                        {
                            Value = s.Value,
                            DataType=(CategoryAttributesDataTypes)s.DataType,
                            AttributeName=s.AttributeName
                        })
                        .ToList()
                    }
                });
                logger.LogInformation($"Item {context.Message.ItemName} created Successfully");

            }
            catch (Exception ex)
            {
                logger.LogError($"Error while creating item {context.Message.ItemName}");
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
