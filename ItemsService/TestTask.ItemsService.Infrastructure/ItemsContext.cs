using Microsoft.EntityFrameworkCore;
using TestTask.ItemsService.Domain.Entities;
using TestTask.ItemsService.Domain.Entities.AttributeValues;
using TestTask.ItemsService.Infrastructure.Configs;

namespace TestTask.ItemsService.Infrastructure
{
    public class ItemsContext : DbContext
    {
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<RefAttributes> RefAttributes { get; set; }
        public DbSet<DateAttributeValuesEntity> DateAttributeValues { get; set; }
        public DbSet<FloatAttributeValuesEntity> FloatAttributeValues { get; set; }
        public DbSet<IntegerAttributeValuesEntity> IntegerAttributeValues { get; set; }
        public DbSet<StringAttributeValuesEntity> StringAttributeValues { get; set; }
        public DbSet<TimeAttributeValuesEntity> TimeAttributeValues { get; set; }


        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RefAttributesConfiguration());

            modelBuilder.ApplyConfiguration(new DateAttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new FloatAttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new IntegerAttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new StringAttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new TimeAttributeValueConfiguration());

            InjectData(modelBuilder);
        }

        private void InjectData(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<RefAttributes>().HasData(InjectedData.RefAttributes);
            modelBuilder.Entity<CategoryEntity>().HasData(InjectedData.Categories);
            modelBuilder.Entity<ItemEntity>().HasData(InjectedData.Items);
            modelBuilder.Entity<StringAttributeValuesEntity>().HasData(InjectedData.StringAttributes);
            modelBuilder.Entity<DateAttributeValuesEntity>().HasData(InjectedData.DateAttributeValues);
            modelBuilder.Entity<TimeAttributeValuesEntity>().HasData(InjectedData.TimeAttributeValuesEntity);*/
        }
    }
}
