using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.ItemsService.Domain.Entities.AttributeValues;

namespace TestTask.ItemsService.Infrastructure.Configs
{
    internal class DateAttributeValueConfiguration : IEntityTypeConfiguration<DateAttributeValuesEntity>
    {
        public void Configure(EntityTypeBuilder<DateAttributeValuesEntity> builder)
        {
            builder.ToTable("DateAttributeValues");
            builder.HasKey(x => x.Id);
            builder.HasOne(x=> x.RefAttribute)
                .WithMany()
                .HasForeignKey(x => x.RefAttributeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    internal class FloatAttributeValueConfiguration : IEntityTypeConfiguration<FloatAttributeValuesEntity>
    {
        public void Configure(EntityTypeBuilder<FloatAttributeValuesEntity> builder)
        {
            builder.ToTable("FloatAttributeValues");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.RefAttribute)
                .WithMany()
                .HasForeignKey(x => x.RefAttributeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    internal class IntegerAttributeValueConfiguration : IEntityTypeConfiguration<IntegerAttributeValuesEntity>
    {
        public void Configure(EntityTypeBuilder<IntegerAttributeValuesEntity> builder)
        {
            builder.ToTable("IntegerAttributeValues");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.RefAttribute)
                .WithMany()
                .HasForeignKey(x => x.RefAttributeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    internal class StringAttributeValueConfiguration : IEntityTypeConfiguration<StringAttributeValuesEntity>
    {
        public void Configure(EntityTypeBuilder<StringAttributeValuesEntity> builder)
        {
            builder.ToTable("StringAttributeValues");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.RefAttribute)
                .WithMany()
                .HasForeignKey(x => x.RefAttributeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    internal class TimeAttributeValueConfiguration : IEntityTypeConfiguration<TimeAttributeValuesEntity>
    {
        public void Configure(EntityTypeBuilder<TimeAttributeValuesEntity> builder)
        {
            builder.ToTable("TimeAttributeValues");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.RefAttribute)
                .WithMany()
                .HasForeignKey(x => x.RefAttributeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Item)
                .WithMany()
                .HasForeignKey(x => x.ItemId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
