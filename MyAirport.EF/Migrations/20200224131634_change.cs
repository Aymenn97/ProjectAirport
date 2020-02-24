using Microsoft.EntityFrameworkCore.Migrations;

namespace A.MyAirport.EF.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JEX",
                table: "Vols");

            migrationBuilder.AlterColumn<string>(
                name: "CIE",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CIE",
                table: "Vols",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<short>(
                name: "JEX",
                table: "Vols",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
