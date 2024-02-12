using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp3.Migrations
{
    public partial class NewBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2453fdb-8b0a-4473-b5d1-14474936c5b6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d", 0, "041f333b-54c0-4516-a5bc-739d1281f077", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAECGXE8b1+JQwK2oeXhXfUSFWAerEnt/aPuWm/JfGRSqUh8dE9xeYclHJ7lR2JtoKFw==", null, false, "66549915-9258-44bf-aa80-ddf9e7a0fdd5", false, "test@softuni.bg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(7966), "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(8048), "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(8054), "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(8057), "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d" });
        }
    }
}
