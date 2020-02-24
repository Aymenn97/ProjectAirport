using Microsoft.EntityFrameworkCore.Migrations;

namespace A.MyAirport.EF.Migrations
{
    public partial class changement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VOLID",
                table: "Bagages");

            migrationBuilder.AlterColumn<int>(
                name: "VOLID",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VOLID",
                table: "Bagages",
                column: "VOLID",
                principalTable: "Vols",
                principalColumn: "VOLID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VOLID",
                table: "Bagages");

            migrationBuilder.AlterColumn<int>(
                name: "VOLID",
                table: "Bagages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VOLID",
                table: "Bagages",
                column: "VOLID",
                principalTable: "Vols",
                principalColumn: "VOLID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
