using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnumSubject = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Level = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => new { x.EnumSubject, x.Level, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectUser",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    SubjectsEnumSubject = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectsLevel = table.Column<short>(type: "smallint", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectUser", x => new { x.UsersId, x.SubjectsEnumSubject, x.SubjectsLevel, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_SubjectUser_Subject_SubjectsEnumSubject_SubjectsLevel_SubjectsId",
                        columns: x => new { x.SubjectsEnumSubject, x.SubjectsLevel, x.SubjectsId },
                        principalTable: "Subject",
                        principalColumns: new[] { "EnumSubject", "Level", "Id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "EnumSubject", "Id", "Level", "CreatedDate", "LastUpdateDate" },
                values: new object[,]
                {
                    { "ART", 37, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3698), null },
                    { "ART", 38, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3712), null },
                    { "ART", 39, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3754), null },
                    { "ART", 40, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3771), null },
                    { "BIOLOGY", 29, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3581), null },
                    { "BIOLOGY", 30, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3595), null },
                    { "BIOLOGY", 31, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3609), null },
                    { "BIOLOGY", 32, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3623), null },
                    { "CHEMISTRY", 25, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3523), null },
                    { "CHEMISTRY", 26, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3537), null },
                    { "CHEMISTRY", 27, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3551), null },
                    { "CHEMISTRY", 28, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3565), null },
                    { "COMPUTER_SCIENCE", 49, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3943), null },
                    { "COMPUTER_SCIENCE", 50, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3957), null },
                    { "COMPUTER_SCIENCE", 51, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3971), null },
                    { "COMPUTER_SCIENCE", 52, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3985), null },
                    { "ENGLISH", 1, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3060), null },
                    { "ENGLISH", 2, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3131), null },
                    { "ENGLISH", 3, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3147), null },
                    { "ENGLISH", 4, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3161), null },
                    { "FRENCH", 53, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4000), null },
                    { "FRENCH", 54, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4014), null },
                    { "FRENCH", 55, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4028), null },
                    { "FRENCH", 56, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4041), null },
                    { "GEOGRAPHY", 13, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3300), null },
                    { "GEOGRAPHY", 14, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3314), null },
                    { "GEOGRAPHY", 15, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3329), null },
                    { "GEOGRAPHY", 16, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3343), null },
                    { "HISTORY", 9, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3240), null },
                    { "HISTORY", 10, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3256), null },
                    { "HISTORY", 11, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3270), null },
                    { "HISTORY", 12, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3284), null },
                    { "MATH", 5, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3177), null },
                    { "MATH", 6, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3195), null },
                    { "MATH", 7, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3209), null },
                    { "MATH", 8, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3224), null },
                    { "MUSIC", 41, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3787), null },
                    { "MUSIC", 42, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3801), null },
                    { "MUSIC", 43, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3815), null },
                    { "MUSIC", 44, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3867), null },
                    { "PHILOSOPHY", 33, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3639), null },
                    { "PHILOSOPHY", 34, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3654), null },
                    { "PHILOSOPHY", 35, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3668), null },
                    { "PHILOSOPHY", 36, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3682), null },
                    { "PHYSICS", 21, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3465), null },
                    { "PHYSICS", 22, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3480), null },
                    { "PHYSICS", 23, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3494), null },
                    { "PHYSICS", 24, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3508), null },
                    { "SCIENCE", 17, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3359), null },
                    { "SCIENCE", 18, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3419), null },
                    { "SCIENCE", 19, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3435), null },
                    { "SCIENCE", 20, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3449), null },
                    { "SPANISH", 57, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4057), null },
                    { "SPANISH", 58, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4071), null },
                    { "SPANISH", 59, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4085), null },
                    { "SPANISH", 60, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(4099), null },
                    { "SPORT", 45, (short)3, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3886), null },
                    { "SPORT", 46, (short)4, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3900), null },
                    { "SPORT", 47, (short)5, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3914), null },
                    { "SPORT", 48, (short)6, new DateTime(2023, 12, 4, 18, 49, 37, 265, DateTimeKind.Local).AddTicks(3927), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUser_SubjectsEnumSubject_SubjectsLevel_SubjectsId",
                table: "SubjectUser",
                columns: new[] { "SubjectsEnumSubject", "SubjectsLevel", "SubjectsId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectUser");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
