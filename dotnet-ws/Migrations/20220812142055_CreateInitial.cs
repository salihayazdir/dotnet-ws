using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_ws.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    globalatmid = table.Column<int>(type: "int", nullable: false),
                    memberno = table.Column<int>(type: "int", nullable: false),
                    atmreferencecode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atmname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    licensetag = table.Column<int>(type: "int", nullable: true),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    servicedependency = table.Column<bool>(type: "bit", nullable: true),
                    restrictedatm = table.Column<bool>(type: "bit", nullable: true),
                    airportlocated = table.Column<bool>(type: "bit", nullable: true),
                    malllocated = table.Column<bool>(type: "bit", nullable: true),
                    universitylocated = table.Column<bool>(type: "bit", nullable: true),
                    depositflag = table.Column<bool>(type: "bit", nullable: true),
                    withdrawflag = table.Column<bool>(type: "bit", nullable: true),
                    terminalcoinoperator = table.Column<bool>(type: "bit", nullable: true),
                    nfcflag = table.Column<bool>(type: "bit", nullable: true),
                    biometryflag = table.Column<bool>(type: "bit", nullable: true),
                    visuallyimpairedflag = table.Column<bool>(type: "bit", nullable: true),
                    orthopedicdisabledflag = table.Column<bool>(type: "bit", nullable: true),
                    atmage = table.Column<bool>(type: "bit", nullable: true),
                    geocodelatitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    geocodelongitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atms", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atms");
        }
    }
}
