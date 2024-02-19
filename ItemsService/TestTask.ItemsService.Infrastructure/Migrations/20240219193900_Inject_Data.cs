using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestTask.ItemsService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Inject_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Футболки" },
                    { 2, "Фильмы" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.", "Футболка мужская Demix", 3990.0 },
                    { 2, 1, "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.", "Футболка мужская Demix", 3990.0 },
                    { 3, 1, "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.", "Футболка мужская Demix", 3990.0 },
                    { 4, 1, "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.", "Футболка мужская Demix", 3990.0 },
                    { 5, 2, "Фильм повествует о череде событий, произошедших в Голливуде в 1969 году, на закате его «золотого века». По сюжету, известный ТВ актер Рик Далтон и его дублер Клифф Бут пытаются найти свое место в стремительно меняющемся мире киноиндустрии", "Однажды в… Голливуде BLUE RAY", 2000.0 },
                    { 6, 2, "Пятеро наёмных убийц оказываются в одном сверхскоростном экспрессе. Они узнают, что их миссии связаны, и пытаются выяснить, кто и зачем собрал их вместе.\r\n", "Быстрее пули", 3000.0 }
                });

            migrationBuilder.InsertData(
                table: "RefAttributes",
                columns: new[] { "Id", "AttributeName", "CategoryId", "DataType" },
                values: new object[,]
                {
                    { 1, "Размер", 1, 0 },
                    { 2, "Материал", 1, 0 },
                    { 3, "Бренд", 1, 0 },
                    { 4, "Цвет", 1, 0 },
                    { 5, "Длительность", 2, 4 },
                    { 6, "Дата выпуска", 2, 3 },
                    { 7, "Режисер", 2, 0 },
                    { 8, "Актер", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "DateAttributeValues",
                columns: new[] { "Id", "ItemId", "RefAttributeId", "Value" },
                values: new object[,]
                {
                    { 1, 5, 6, new DateTimeOffset(new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)) },
                    { 2, 6, 6, new DateTimeOffset(new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "StringAttributeValues",
                columns: new[] { "Id", "ItemId", "RefAttributeId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "44-46" },
                    { 2, 2, 1, "48-50" },
                    { 3, 3, 1, "52-54" },
                    { 4, 4, 1, "56-58" },
                    { 5, 1, 1, "60-62" },
                    { 6, 1, 4, "Белый" },
                    { 7, 2, 4, "Черный" },
                    { 8, 3, 4, "Серый" },
                    { 9, 4, 4, "Белый" },
                    { 10, 1, 4, "Зеленый" },
                    { 11, 1, 2, "Хлопок" },
                    { 12, 2, 2, "Хлопок" },
                    { 13, 3, 2, "Хлопок" },
                    { 14, 4, 2, "Хлопок" },
                    { 15, 1, 2, "Хлопок" },
                    { 16, 1, 3, "Хлопок" },
                    { 17, 2, 3, "Хлопок" },
                    { 18, 3, 3, "Хлопок" },
                    { 19, 4, 3, "Хлопок" },
                    { 20, 1, 3, "Хлопок" },
                    { 21, 5, 7, "Квентин Тарантино" },
                    { 22, 5, 8, "Марго Робби - Шарон Тейт" },
                    { 23, 5, 8, "Брэд Питт - Клифф Бут" },
                    { 24, 5, 8, "Леонардо Ди Каприо - Рик Далтон" },
                    { 25, 6, 7, "Дэвид Литч" },
                    { 26, 6, 8, "Аарон Тейлор-Джонсон - Танджерин" },
                    { 27, 6, 8, "Брэд Питт - Божья коровка" },
                    { 28, 6, 8, "Джоуи Кинг - Prince" }
                });

            migrationBuilder.InsertData(
                table: "TimeAttributeValues",
                columns: new[] { "Id", "ItemId", "RefAttributeId", "Value" },
                values: new object[,]
                {
                    { 1, 5, 5, new TimeSpan(0, 2, 40, 0, 0) },
                    { 2, 6, 5, new TimeSpan(0, 2, 6, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DateAttributeValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DateAttributeValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StringAttributeValues",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TimeAttributeValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeAttributeValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RefAttributes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
