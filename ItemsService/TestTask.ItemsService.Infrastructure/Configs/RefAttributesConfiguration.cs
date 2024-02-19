using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.ItemsService.Domain.Entities;

namespace TestTask.ItemsService.Infrastructure.Configs
{
    internal class RefAttributesConfiguration : IEntityTypeConfiguration<RefAttributes>
    {
        public void Configure(EntityTypeBuilder<RefAttributes> builder)
        {
            builder.ToTable("RefAttributes");
            builder.Property(x => x.DataType)
                .HasConversion<int>();
            builder.HasOne(x => x.Category)
                .WithOne()
                .HasForeignKey<RefAttributes>(x=> x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
