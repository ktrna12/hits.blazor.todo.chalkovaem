using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5216), "Описание 1", new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5230), "Название 1" },
                    { 2, new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5232), "Описание 2", new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5232), "Название 2" },
                    { 3, new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5234), "Описание 3", new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5235), "Название 3" },
                    { 4, new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5236), "Описание 4", new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5237), "Название 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
