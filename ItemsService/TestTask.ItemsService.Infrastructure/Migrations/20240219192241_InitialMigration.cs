using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestTask.ItemsService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AttributeName = table.Column<string>(type: "text", nullable: false),
                    DataType = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefAttributes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DateAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    RefAttributeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateAttributeValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DateAttributeValues_RefAttributes_RefAttributeId",
                        column: x => x.RefAttributeId,
                        principalTable: "RefAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FloatAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<double>(type: "double precision", nullable: true),
                    RefAttributeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloatAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FloatAttributeValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FloatAttributeValues_RefAttributes_RefAttributeId",
                        column: x => x.RefAttributeId,
                        principalTable: "RefAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IntegerAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: true),
                    RefAttributeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegerAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntegerAttributeValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IntegerAttributeValues_RefAttributes_RefAttributeId",
                        column: x => x.RefAttributeId,
                        principalTable: "RefAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StringAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true),
                    RefAttributeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StringAttributeValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StringAttributeValues_RefAttributes_RefAttributeId",
                        column: x => x.RefAttributeId,
                        principalTable: "RefAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TimeAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<TimeSpan>(type: "interval", nullable: true),
                    RefAttributeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeAttributeValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeAttributeValues_RefAttributes_RefAttributeId",
                        column: x => x.RefAttributeId,
                        principalTable: "RefAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateAttributeValues_ItemId",
                table: "DateAttributeValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DateAttributeValues_RefAttributeId",
                table: "DateAttributeValues",
                column: "RefAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatAttributeValues_ItemId",
                table: "FloatAttributeValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatAttributeValues_RefAttributeId",
                table: "FloatAttributeValues",
                column: "RefAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegerAttributeValues_ItemId",
                table: "IntegerAttributeValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegerAttributeValues_RefAttributeId",
                table: "IntegerAttributeValues",
                column: "RefAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RefAttributes_CategoryId",
                table: "RefAttributes",
                column: "CategoryId",
                unique: false);

            migrationBuilder.CreateIndex(
                name: "IX_StringAttributeValues_ItemId",
                table: "StringAttributeValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StringAttributeValues_RefAttributeId",
                table: "StringAttributeValues",
                column: "RefAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeAttributeValues_ItemId",
                table: "TimeAttributeValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeAttributeValues_RefAttributeId",
                table: "TimeAttributeValues",
                column: "RefAttributeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateAttributeValues");

            migrationBuilder.DropTable(
                name: "FloatAttributeValues");

            migrationBuilder.DropTable(
                name: "IntegerAttributeValues");

            migrationBuilder.DropTable(
                name: "StringAttributeValues");

            migrationBuilder.DropTable(
                name: "TimeAttributeValues");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "RefAttributes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
