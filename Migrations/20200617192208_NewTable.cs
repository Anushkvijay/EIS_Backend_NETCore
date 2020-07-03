using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eisApi.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    EmplID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DeptID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    Project = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    EmrgncyContact = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    WorkHours = table.Column<int>(type: "int", nullable: false),
                    Pancard = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PTO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmplID);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Departments_DeptID",
                        column: x => x.DeptID,
                        principalTable: "Departments",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_DeptID",
                table: "EmployeeDetails",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_UserID",
                table: "EmployeeDetails",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
