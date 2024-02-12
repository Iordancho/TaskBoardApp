using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp3.Migrations
{
    public partial class newboard2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2453fdb-8b0a-4473-b5d1-14474936c5b6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "113841e6-be90-400e-9999-ce101da8628d", 0, "f9b1b90d-7889-4a85-8122-10b34e938b8a", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEAhhdaFjyy1AzFTRvgfJ+8RvS9Ocl+tqsUEaAO1l7pVjwYzdiRfAARJMrwWlqYTdqg==", null, false, "b1868ec3-56d0-4cfb-b60b-8b90c132b3a8", false, "test@softuni.bg" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "For Review" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 25, 16, 5, 22, 346, DateTimeKind.Local).AddTicks(4464), "113841e6-be90-400e-9999-ce101da8628d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 5, 22, 346, DateTimeKind.Local).AddTicks(4504), "113841e6-be90-400e-9999-ce101da8628d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 22, 16, 5, 22, 346, DateTimeKind.Local).AddTicks(4507), "113841e6-be90-400e-9999-ce101da8628d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 5, 22, 346, DateTimeKind.Local).AddTicks(4510), "113841e6-be90-400e-9999-ce101da8628d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113841e6-be90-400e-9999-ce101da8628d");

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2453fdb-8b0a-4473-b5d1-14474936c5b6", 0, "72079d25-54d0-4fb7-925d-de95963e3b0a", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEPV5Qshg3ptwePmY5W9YZxac3aAtiIoXFMw53qsDxLdaQs2TSdgFHPA4TsBJ4ALHvg==", null, false, "1a8aade8-f024-4c9f-a300-7aa43491d410", false, "test@softuni.bg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 25, 16, 2, 49, 667, DateTimeKind.Local).AddTicks(7785), "e2453fdb-8b0a-4473-b5d1-14474936c5b6" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 2, 49, 667, DateTimeKind.Local).AddTicks(7844), "e2453fdb-8b0a-4473-b5d1-14474936c5b6" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 22, 16, 2, 49, 667, DateTimeKind.Local).AddTicks(7847), "e2453fdb-8b0a-4473-b5d1-14474936c5b6" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 2, 49, 667, DateTimeKind.Local).AddTicks(7850), "e2453fdb-8b0a-4473-b5d1-14474936c5b6" });
        }
    }
}
