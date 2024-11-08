using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaskItemAssigneeForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_AspNetUsers_AssigneeId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "TaskItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8097), new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8101), new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 19, 59, 38, 357, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_UserItems_AssigneeId",
                table: "TaskItems",
                column: "AssigneeId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_UserItems_AssigneeId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "TaskItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 11, 7, 19, 28, 41, 125, DateTimeKind.Local).AddTicks(448) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_AspNetUsers_AssigneeId",
                table: "TaskItems",
                column: "AssigneeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
