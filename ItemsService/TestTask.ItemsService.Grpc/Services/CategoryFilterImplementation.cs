using Grpc.Core;
using TestTask.ItemsService.Domain.Repositories;
using TestTask.protos.Category;

namespace TestTask.Api.Grpc.Services
{
    public class CategoryFilterImplementation : TestTask.protos.Category.CategoryService.CategoryServiceBase
    {
        private readonly ILogger<CategoryFilterImplementation> _logger;
        private readonly ICategoryRepository categoryRepository;

        public CategoryFilterImplementation(ILogger<CategoryFilterImplementation> logger, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.categoryRepository = categoryRepository;
        }
        public override async Task<Category> GetCategoryById(GetCategoryByIdFilter request, ServerCallContext context)
        {
            var foundCategory = await categoryRepository.GetCategoryById(request.Id);

            if (foundCategory == null)
            {
                return new Category { Id = 0 };
            }

            var categoryResponse = new Category 
            { 
                Id = foundCategory.Id,
                CategoryName = foundCategory.CategoryName,
                AttributesInfo = { foundCategory.AttributesInfo.Select(s=> new CategoryAttribute
                {
                    Id = s.Id,
                    AttributeName = s.AttributeName,
                    AttributeDataTypeId = s.AttributeDataTypeId,
                    AttributeDataTypeName = s.AttributeDataTypeName,
                })}
            };
            return categoryResponse;
        }
        public override async Task<Category> GetCategoryByName(GetCategoryByNameFilter request, ServerCallContext context)
        {
            var foundCategory = await categoryRepository.GetCategoryByName(request.Name);

            if (foundCategory == null)
            {
                return new Category { Id = 0 };
            }

            var categoryResponse = new Category
            {
                Id = foundCategory.Id,
                CategoryName = foundCategory.CategoryName,
                AttributesInfo = { foundCategory.AttributesInfo.Select(s=> new CategoryAttribute
                {
                    Id = s.Id,
                    AttributeName = s.AttributeName,
                    AttributeDataTypeId = s.AttributeDataTypeId,
                    AttributeDataTypeName = s.AttributeDataTypeName,
                })}
            };
            return categoryResponse;
        }
    }
}