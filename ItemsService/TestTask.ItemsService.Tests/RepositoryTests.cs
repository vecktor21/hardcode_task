using TestTask.ItemsService.Domain.Repositories;
using Xunit.Microsoft.DependencyInjection.Abstracts;
using Xunit.Abstractions;

namespace TestTask.ItemsService.Tests
{
    public class RepositoryTests : TestBed<Fixture>
    {
        public RepositoryTests(ITestOutputHelper testOutputHelper, Fixture fixture)
        : base(testOutputHelper, fixture)
        {
        }



        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task TestGetItemById(int id)
        {
            var itemRepo = _fixture.GetScopedService<IItemRepository>(_testOutputHelper);

            var item = await itemRepo.FindItemById(id);

            Assert.NotNull(item);
            Assert.Equal(item.Id, id);
        }


        [Fact]
        public async Task TestGetItemByFilter()
        {
            var itemRepo = _fixture.GetScopedService<IItemRepository>(_testOutputHelper);

            var items = await itemRepo.FindItemByFilter(new Domain.Dtos.ItemCategoryFilter
            {
                CategoryNameFilter = "Футболки",

            });

            Assert.NotNull(items);
            Assert.True(items.Count > 0);
            foreach (var item in items)
            {
                Assert.Equal(4, item.Category.Attributes.Count);
            }
        }
    }
}