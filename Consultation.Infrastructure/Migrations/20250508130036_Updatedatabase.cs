using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notify",
                table: "ConsultationRequest");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "SchoolYearID",
                table: "Students",
                newName: "StudentNumber");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "EnrolledCourse",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "DeparmentID",
                table: "Department",
                newName: "DepartmentID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AcademicYear",
                table: "SchoolYear",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EnrolledCourseID1",
                table: "SchoolYear",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SchoolYearStatus",
                table: "SchoolYear",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "SchoolYear",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentID",
                table: "SchoolYear",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "FacultyID",
                table: "Faculty",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FacultyNumber",
                table: "Faculty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CourseCode",
                table: "EnrolledCourse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacultyID",
                table: "EnrolledCourse",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "ConsultationRequest",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FacultyID",
                table: "ConsultationRequest",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndedTime",
                table: "ConsultationRequest",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "NotificationNumber",
                table: "ConsultationRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "StartedTime",
                table: "ConsultationRequest",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.CreateTable(
                name: "FacultySchedule",
                columns: table => new
                {
                    FacultyScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultySchedule", x => x.FacultyScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationNumber);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProgramID",
                table: "Students",
                column: "ProgramID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_EnrolledCourseID1",
                table: "SchoolYear",
                column: "EnrolledCourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_StudentID",
                table: "SchoolYear",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_FacultyScheduleID",
                table: "Faculty",
                column: "FacultyScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_FacultyID",
                table: "EnrolledCourse",
                column: "FacultyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRequest_NotificationNumber",
                table: "ConsultationRequest",
                column: "NotificationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationRequest_Notification_NotificationNumber",
                table: "ConsultationRequest",
                column: "NotificationNumber",
                principalTable: "Notification",
                principalColumn: "NotificationNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnrolledCourse_Faculty_FacultyID",
                table: "EnrolledCourse",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_FacultySchedule_FacultyScheduleID",
                table: "Faculty",
                column: "FacultyScheduleID",
                principalTable: "FacultySchedule",
                principalColumn: "FacultyScheduleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolYear_EnrolledCourse_EnrolledCourseID1",
                table: "SchoolYear",
                column: "EnrolledCourseID1",
                principalTable: "EnrolledCourse",
                principalColumn: "EnrolledCourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolYear_Students_StudentID",
                table: "SchoolYear",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Program_ProgramID",
                table: "Students",
                column: "ProgramID",
                principalTable: "Program",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationRequest_Notification_NotificationNumber",
                table: "ConsultationRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrolledCourse_Faculty_FacultyID",
                table: "EnrolledCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_FacultySchedule_FacultyScheduleID",
                table: "Faculty");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolYear_EnrolledCourse_EnrolledCourseID1",
                table: "SchoolYear");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolYear_Students_StudentID",
                table: "SchoolYear");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Program_ProgramID",
                table: "Students");

            migrationBuilder.DropTable(
                name: "FacultySchedule");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProgramID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_SchoolYear_EnrolledCourseID1",
                table: "SchoolYear");

            migrationBuilder.DropIndex(
                name: "IX_SchoolYear_StudentID",
                table: "SchoolYear");

            migrationBuilder.DropIndex(
                name: "IX_Faculty_FacultyScheduleID",
                table: "Faculty");

            migrationBuilder.DropIndex(
                name: "IX_EnrolledCourse_FacultyID",
                table: "EnrolledCourse");

            migrationBuilder.DropIndex(
                name: "IX_ConsultationRequest_NotificationNumber",
                table: "ConsultationRequest");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AcademicYear",
                table: "SchoolYear");

            migrationBuilder.DropColumn(
                name: "EnrolledCourseID1",
                table: "SchoolYear");

            migrationBuilder.DropColumn(
                name: "SchoolYearStatus",
                table: "SchoolYear");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "SchoolYear");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "SchoolYear");

            migrationBuilder.DropColumn(
                name: "FacultyNumber",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "EnrolledCourse");

            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "EnrolledCourse");

            migrationBuilder.DropColumn(
                name: "EndedTime",
                table: "ConsultationRequest");

            migrationBuilder.DropColumn(
                name: "NotificationNumber",
                table: "ConsultationRequest");

            migrationBuilder.DropColumn(
                name: "StartedTime",
                table: "ConsultationRequest");

            migrationBuilder.RenameColumn(
                name: "StudentNumber",
                table: "Students",
                newName: "SchoolYearID");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "EnrolledCourse",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Department",
                newName: "DeparmentID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "Faculty",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "ConsultationRequest",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "ConsultationRequest",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Notify",
                table: "ConsultationRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
