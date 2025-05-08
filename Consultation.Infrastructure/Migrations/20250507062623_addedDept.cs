using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Program_DepartmentID",
                table: "Program",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Department_DepartmentID",
                table: "Program",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DeparmentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program_Department_DepartmentID",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_DepartmentID",
                table: "Program");
        }
    }
}
