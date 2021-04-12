using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class Student_Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StudentModel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SubjectModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SubjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    TeacherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectModel");

            migrationBuilder.DropTable(
                name: "TeacherModel");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StudentModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
