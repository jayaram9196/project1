using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lastdemo.Migrations
{
    /// <inheritdoc />
    public partial class IntialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminModel",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UserRole = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AdminMod__719FE488B1AEBB0F", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "InstituteModel",
                columns: table => new
                {
                    InstituteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstituteName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    InstituteDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstituteAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Institut__09EC0DBB8F738F99", x => x.InstituteId);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserMode",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UserRole = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserMode__1788CC4CFC31DC40", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CourseModel",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CourseDescription = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CourseDuration = table.Column<int>(type: "int", nullable: true),
                    CourseTiming = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NumberofStudents = table.Column<int>(type: "int", nullable: true),
                    InstituteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CourseMo__C92D71A76569F47A", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK__CourseMod__Insti__3D5E1FD2",
                        column: x => x.InstituteId,
                        principalTable: "InstituteModel",
                        principalColumn: "InstituteId");
                });

            migrationBuilder.CreateTable(
                name: "RatingsModel",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Comments = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstituteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RatingsM__FCCDF87C5B359E5B", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK__RatingsMo__Insti__4316F928",
                        column: x => x.InstituteId,
                        principalTable: "InstituteModel",
                        principalColumn: "InstituteId");
                });

            migrationBuilder.CreateTable(
                name: "ProgressModels",
                columns: table => new
                {
                    ProgressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    progress = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CourseModelCourseId = table.Column<int>(type: "int", nullable: true),
                    UserModeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressModels", x => x.ProgressId);
                    table.ForeignKey(
                        name: "FK_ProgressModels_CourseModel_CourseModelCourseId",
                        column: x => x.CourseModelCourseId,
                        principalTable: "CourseModel",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_ProgressModels_UserMode_UserModeUserId",
                        column: x => x.UserModeUserId,
                        principalTable: "UserMode",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "StudentModel",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    StudentDOB = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mobile = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    FatherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MotherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AlternateMobile = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentM__32C52B99A72A76DB", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK__StudentMo__Cours__403A8C7D",
                        column: x => x.CourseId,
                        principalTable: "CourseModel",
                        principalColumn: "CourseId");
                });

            migrationBuilder.CreateTable(
                name: "AdmissionTable",
                columns: table => new
                {
                    AdmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    InstituteId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DateOfJoining = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admissio__C97EEC427D98A701", x => x.AdmissionId);
                    table.ForeignKey(
                        name: "FK__Admission__Cours__47DBAE45",
                        column: x => x.CourseId,
                        principalTable: "CourseModel",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK__Admission__Insti__48CFD27E",
                        column: x => x.InstituteId,
                        principalTable: "InstituteModel",
                        principalColumn: "InstituteId");
                    table.ForeignKey(
                        name: "FK__Admission__Stude__46E78A0C",
                        column: x => x.StudentId,
                        principalTable: "StudentModel",
                        principalColumn: "StudentId");
                    table.ForeignKey(
                        name: "FK__Admission__UserI__49C3F6B7",
                        column: x => x.UserId,
                        principalTable: "UserMode",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTable_CourseId",
                table: "AdmissionTable",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTable_InstituteId",
                table: "AdmissionTable",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTable_StudentId",
                table: "AdmissionTable",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTable_UserId",
                table: "AdmissionTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseModel_InstituteId",
                table: "CourseModel",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressModels_CourseModelCourseId",
                table: "ProgressModels",
                column: "CourseModelCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressModels_UserModeUserId",
                table: "ProgressModels",
                column: "UserModeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingsModel_InstituteId",
                table: "RatingsModel",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentModel_CourseId",
                table: "StudentModel",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminModel");

            migrationBuilder.DropTable(
                name: "AdmissionTable");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "ProgressModels");

            migrationBuilder.DropTable(
                name: "RatingsModel");

            migrationBuilder.DropTable(
                name: "StudentModel");

            migrationBuilder.DropTable(
                name: "UserMode");

            migrationBuilder.DropTable(
                name: "CourseModel");

            migrationBuilder.DropTable(
                name: "InstituteModel");
        }
    }
}
