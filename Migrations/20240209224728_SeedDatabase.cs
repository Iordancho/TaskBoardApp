using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp3.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Task Title"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Task Description"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d", 0, "041f333b-54c0-4516-a5bc-739d1281f077", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAECGXE8b1+JQwK2oeXhXfUSFWAerEnt/aPuWm/JfGRSqUh8dE9xeYclHJ7lR2JtoKFw==", null, false, "66549915-9258-44bf-aa80-ddf9e7a0fdd5", false, "test@softuni.bg" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progress" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 25, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(7966), "Implement better styling", "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d", "Impove CSS styles" },
                    { 2, 1, new DateTime(2023, 11, 2, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(8048), "Create Android Client App", "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d", "Android Client App" },
                    { 3, 3, new DateTime(2023, 12, 22, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(8054), "Create Desktop client App", "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d", "Desktop client App" },
                    { 4, 2, new DateTime(2023, 12, 12, 0, 47, 27, 777, DateTimeKind.Local).AddTicks(8057), "Implement [Create tasks] page for adding tasks", "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d", "Create Tasks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d53b8fc-ac17-4af1-a42a-9bea2b15d59d");
        }
    }
}
