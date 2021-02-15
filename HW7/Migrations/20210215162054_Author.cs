using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW7.Migrations
{
    public partial class Author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Stories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Birthday", "Description", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1920, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Isaak", "Azimov" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Birthday", "Description", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "John R. R.", "Tolkien" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Birthday", "Description", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(1944, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Американский кинопродюсер", "George", "Lucas" });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AuthorID",
                table: "Stories",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Authors_AuthorID",
                table: "Stories",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Authors_AuthorID",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Stories_AuthorID",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Stories");
        }
    }
}
