using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Data.Migrations
{
    public partial class addedpackagenamemodulecol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PackageName",
                table: "tb_module",
                newName: "package_name");

            migrationBuilder.AlterColumn<string>(
                name: "package_name",
                table: "tb_module",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "package_name",
                table: "tb_module",
                newName: "PackageName");

            migrationBuilder.AlterColumn<string>(
                name: "PackageName",
                table: "tb_module",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
