using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_useritem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.InsertData(
                table: "UserItems",
                columns: new[] { "Id", "Email", "FullName", "RegisteredDate" },
                values: new object[,]
                {
                    { 1, "user1@example.com", "Пользователь 1", new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(6175) },
                    { 2, "user2@example.com", "Пользователь 2", new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(6179) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserItems");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4241), new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 10, 10, 20, 16, 6, 102, DateTimeKind.Local).AddTicks(4264) });
        }
    }
}
