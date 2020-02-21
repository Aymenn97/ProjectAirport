using Microsoft.EntityFrameworkCore.Migrations;

namespace A.MyAirport.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BAGAGEID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VOLID = table.Column<int>(nullable: false),
                    CODE_IATA = table.Column<string>(nullable: false),
                    DATA_CREATION = table.Column<int>(nullable: false),
                    CLASSE = table.Column<string>(nullable: false),
                    PRIORITAIRE = table.Column<bool>(nullable: false),
                    STA = table.Column<string>(nullable: false),
                    SSUR = table.Column<string>(nullable: false),
                    DESTINATION = table.Column<string>(nullable: false),
                    ESCALE = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BAGAGEID);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VOLID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIE = table.Column<int>(nullable: false),
                    LIG = table.Column<string>(nullable: false),
                    JEX = table.Column<int>(nullable: false),
                    DHC = table.Column<int>(nullable: false),
                    PKG = table.Column<string>(nullable: false),
                    IMM = table.Column<string>(nullable: false),
                    PAX = table.Column<int>(nullable: false),
                    DES = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VOLID);
                });
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
