﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestTask.ItemsService.Infrastructure;

#nullable disable

namespace TestTask.ItemsService.Infrastructure.Migrations
{
    [DbContext(typeof(ItemsContext))]
    [Migration("20240219193900_Inject_Data")]
    partial class Inject_Data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.DateAttributeValuesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("RefAttributeId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset?>("Value")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("RefAttributeId");

                    b.ToTable("DateAttributeValues", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 5,
                            RefAttributeId = 6,
                            Value = new DateTimeOffset(new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 6,
                            RefAttributeId = 6,
                            Value = new DateTimeOffset(new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.FloatAttributeValuesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("RefAttributeId")
                        .HasColumnType("integer");

                    b.Property<double?>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("RefAttributeId");

                    b.ToTable("FloatAttributeValues", (string)null);
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.IntegerAttributeValuesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("RefAttributeId")
                        .HasColumnType("integer");

                    b.Property<int?>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("RefAttributeId");

                    b.ToTable("IntegerAttributeValues", (string)null);
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.StringAttributeValuesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("RefAttributeId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("RefAttributeId");

                    b.ToTable("StringAttributeValues", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 1,
                            RefAttributeId = 1,
                            Value = "44-46"
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 2,
                            RefAttributeId = 1,
                            Value = "48-50"
                        },
                        new
                        {
                            Id = 3,
                            ItemId = 3,
                            RefAttributeId = 1,
                            Value = "52-54"
                        },
                        new
                        {
                            Id = 4,
                            ItemId = 4,
                            RefAttributeId = 1,
                            Value = "56-58"
                        },
                        new
                        {
                            Id = 5,
                            ItemId = 1,
                            RefAttributeId = 1,
                            Value = "60-62"
                        },
                        new
                        {
                            Id = 6,
                            ItemId = 1,
                            RefAttributeId = 4,
                            Value = "Белый"
                        },
                        new
                        {
                            Id = 7,
                            ItemId = 2,
                            RefAttributeId = 4,
                            Value = "Черный"
                        },
                        new
                        {
                            Id = 8,
                            ItemId = 3,
                            RefAttributeId = 4,
                            Value = "Серый"
                        },
                        new
                        {
                            Id = 9,
                            ItemId = 4,
                            RefAttributeId = 4,
                            Value = "Белый"
                        },
                        new
                        {
                            Id = 10,
                            ItemId = 1,
                            RefAttributeId = 4,
                            Value = "Зеленый"
                        },
                        new
                        {
                            Id = 11,
                            ItemId = 1,
                            RefAttributeId = 2,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 12,
                            ItemId = 2,
                            RefAttributeId = 2,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 13,
                            ItemId = 3,
                            RefAttributeId = 2,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 14,
                            ItemId = 4,
                            RefAttributeId = 2,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 15,
                            ItemId = 1,
                            RefAttributeId = 2,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 16,
                            ItemId = 1,
                            RefAttributeId = 3,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 17,
                            ItemId = 2,
                            RefAttributeId = 3,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 18,
                            ItemId = 3,
                            RefAttributeId = 3,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 19,
                            ItemId = 4,
                            RefAttributeId = 3,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 20,
                            ItemId = 1,
                            RefAttributeId = 3,
                            Value = "Хлопок"
                        },
                        new
                        {
                            Id = 21,
                            ItemId = 5,
                            RefAttributeId = 7,
                            Value = "Квентин Тарантино"
                        },
                        new
                        {
                            Id = 22,
                            ItemId = 5,
                            RefAttributeId = 8,
                            Value = "Марго Робби - Шарон Тейт"
                        },
                        new
                        {
                            Id = 23,
                            ItemId = 5,
                            RefAttributeId = 8,
                            Value = "Брэд Питт - Клифф Бут"
                        },
                        new
                        {
                            Id = 24,
                            ItemId = 5,
                            RefAttributeId = 8,
                            Value = "Леонардо Ди Каприо - Рик Далтон"
                        },
                        new
                        {
                            Id = 25,
                            ItemId = 6,
                            RefAttributeId = 7,
                            Value = "Дэвид Литч"
                        },
                        new
                        {
                            Id = 26,
                            ItemId = 6,
                            RefAttributeId = 8,
                            Value = "Аарон Тейлор-Джонсон - Танджерин"
                        },
                        new
                        {
                            Id = 27,
                            ItemId = 6,
                            RefAttributeId = 8,
                            Value = "Брэд Питт - Божья коровка"
                        },
                        new
                        {
                            Id = 28,
                            ItemId = 6,
                            RefAttributeId = 8,
                            Value = "Джоуи Кинг - Prince"
                        });
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.TimeAttributeValuesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("RefAttributeId")
                        .HasColumnType("integer");

                    b.Property<TimeSpan?>("Value")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("RefAttributeId");

                    b.ToTable("TimeAttributeValues", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 5,
                            RefAttributeId = 5,
                            Value = new TimeSpan(0, 2, 40, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 6,
                            RefAttributeId = 5,
                            Value = new TimeSpan(0, 2, 6, 0, 0)
                        });
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Футболки"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Фильмы"
                        });
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                            Name = "Футболка мужская Demix",
                            Price = 3990.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                            Name = "Футболка мужская Demix",
                            Price = 3990.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                            Name = "Футболка мужская Demix",
                            Price = 3990.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                            Name = "Футболка мужская Demix",
                            Price = 3990.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Фильм повествует о череде событий, произошедших в Голливуде в 1969 году, на закате его «золотого века». По сюжету, известный ТВ актер Рик Далтон и его дублер Клифф Бут пытаются найти свое место в стремительно меняющемся мире киноиндустрии",
                            Name = "Однажды в… Голливуде BLUE RAY",
                            Price = 2000.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Пятеро наёмных убийц оказываются в одном сверхскоростном экспрессе. Они узнают, что их миссии связаны, и пытаются выяснить, кто и зачем собрал их вместе.\r\n",
                            Name = "Быстрее пули",
                            Price = 3000.0
                        });
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.RefAttributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("DataType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("RefAttributes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttributeName = "Размер",
                            CategoryId = 1,
                            DataType = 0
                        },
                        new
                        {
                            Id = 2,
                            AttributeName = "Материал",
                            CategoryId = 1,
                            DataType = 0
                        },
                        new
                        {
                            Id = 3,
                            AttributeName = "Бренд",
                            CategoryId = 1,
                            DataType = 0
                        },
                        new
                        {
                            Id = 4,
                            AttributeName = "Цвет",
                            CategoryId = 1,
                            DataType = 0
                        },
                        new
                        {
                            Id = 5,
                            AttributeName = "Длительность",
                            CategoryId = 2,
                            DataType = 4
                        },
                        new
                        {
                            Id = 6,
                            AttributeName = "Дата выпуска",
                            CategoryId = 2,
                            DataType = 3
                        },
                        new
                        {
                            Id = 7,
                            AttributeName = "Режисер",
                            CategoryId = 2,
                            DataType = 0
                        },
                        new
                        {
                            Id = 8,
                            AttributeName = "Актер",
                            CategoryId = 2,
                            DataType = 0
                        });
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.DateAttributeValuesEntity", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.ItemEntity", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.ItemsService.Domain.Entities.RefAttributes", "RefAttribute")
                        .WithMany()
                        .HasForeignKey("RefAttributeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("RefAttribute");
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.FloatAttributeValuesEntity", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.ItemEntity", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.ItemsService.Domain.Entities.RefAttributes", "RefAttribute")
                        .WithMany()
                        .HasForeignKey("RefAttributeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("RefAttribute");
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.IntegerAttributeValuesEntity", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.ItemEntity", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.ItemsService.Domain.Entities.RefAttributes", "RefAttribute")
                        .WithMany()
                        .HasForeignKey("RefAttributeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("RefAttribute");
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.StringAttributeValuesEntity", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.ItemEntity", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.ItemsService.Domain.Entities.RefAttributes", "RefAttribute")
                        .WithMany()
                        .HasForeignKey("RefAttributeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("RefAttribute");
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.AttributeValues.TimeAttributeValuesEntity", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.ItemEntity", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.ItemsService.Domain.Entities.RefAttributes", "RefAttribute")
                        .WithMany()
                        .HasForeignKey("RefAttributeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("RefAttribute");
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.ItemEntity", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TestTask.ItemsService.Domain.Entities.RefAttributes", b =>
                {
                    b.HasOne("TestTask.ItemsService.Domain.Entities.CategoryEntity", "Category")
                        .WithOne()
                        .HasForeignKey("TestTask.ItemsService.Domain.Entities.RefAttributes", "CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
