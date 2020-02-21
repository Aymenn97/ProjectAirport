using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A.MyAirport.EF.Migrations
{
    public partial class VolIdFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VOLID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIE = table.Column<int>(nullable: false),
                    LIG = table.Column<string>(nullable: true),
                    JEX = table.Column<short>(nullable: false),
                    DHC = table.Column<DateTime>(nullable: false),
                    PKG = table.Column<string>(nullable: true),
                    IMM = table.Column<string>(nullable: true),
                    PAX = table.Column<short>(nullable: false),
                    DES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VOLID);
                });

            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BAGAGEID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VOLID = table.Column<int>(nullable: false),
                    CODE_IATA = table.Column<string>(nullable: true),
                    DATA_CREATION = table.Column<DateTime>(nullable: false),
                    CLASSE = table.Column<string>(nullable: true),
                    PRIORITAIRE = table.Column<bool>(nullable: false),
                    STA = table.Column<string>(nullable: true),
                    SSUR = table.Column<string>(nullable: true),
                    DESTINATION = table.Column<string>(nullable: true),
                    ESCALE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BAGAGEID);
                    table.ForeignKey(
                        name: "FK_Bagages_Vols_VOLID",
                        column: x => x.VOLID,
                        principalTable: "Vols",
                        principalColumn: "VOLID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VOLID",
                table: "Bagages",
                column: "VOLID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
