using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Studentportal.Data.Migrations
{
    public partial class SchoolClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchoolClassId",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Year = table.Column<DateTime>(type: "date", nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolClasses_AspNetUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SchoolClassId",
                table: "AspNetUsers",
                column: "SchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClasses_ManagerId",
                table: "SchoolClasses",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SchoolClasses_SchoolClassId",
                table: "AspNetUsers",
                column: "SchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SchoolClasses_SchoolClassId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SchoolClasses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SchoolClassId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SchoolClassId",
                table: "AspNetUsers");
        }
    }
}
