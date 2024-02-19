using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.ItemsService.Domain.Entities;

namespace TestTask.ItemsService.Infrastructure.Configs
{
    internal class ItemsConfiguration : IEntityTypeConfiguration<ItemEntity>
    {
        public void Configure(EntityTypeBuilder<ItemEntity> builder)
        {
            builder.ToTable("Items");
            builder.HasOne(x=> x.Category)
                .WithMany()
                .HasForeignKey(x=>x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
