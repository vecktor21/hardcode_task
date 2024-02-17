using Grpc.Core;
using TestTask.protos.Category;

namespace TestTask.Api.Grpc.Services
{
    public class CategoryFilterImplementation : TestTask.protos.Category.CategoryService.CategoryServiceBase
    {
        private readonly ILogger<CategoryFilterImplementation> _logger;
        public CategoryFilterImplementation(ILogger<CategoryFilterImplementation> logger)
        {
            _logger = logger;
        }
        public override Task<Category> GetCategoryById(GetCategoryByIdFilter request, ServerCallContext context)
        {
            return base.GetCategoryById(request, context);
        }
        public override Task<Category> GetCategoryByName(GetCategoryByNameFilter request, ServerCallContext context)
        {
            return base.GetCategoryByName(request, context);
        }
    }
}