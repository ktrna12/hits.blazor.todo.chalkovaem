using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class update2_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(739));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9968), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 19, 24, 20, 581, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 19, 24, 20, 581, DateTimeKind.Local).AddTicks(224));
        }
    }
}
