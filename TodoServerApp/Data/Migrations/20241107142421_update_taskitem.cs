using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class update_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssigneeId",
                table: "TaskItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9968), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssigneeId", "CreatedDate", "FinishedDate" },
                values: new object[] { null, new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 11, 7, 19, 24, 20, 580, DateTimeKind.Local).AddTicks(9973) });

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

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_AssigneeId",
                table: "TaskItems",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_AspNetUsers_AssigneeId",
                table: "TaskItems",
                column: "AssigneeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_AspNetUsers_AssigneeId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_AssigneeId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "TaskItems");

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

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 7, 18, 56, 18, 640, DateTimeKind.Local).AddTicks(6179));
        }
    }
}
