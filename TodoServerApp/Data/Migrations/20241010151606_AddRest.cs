using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5216), new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5232), new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 10, 10, 17, 11, 13, 845, DateTimeKind.Local).AddTicks(5237) });
        }
    }
}
