using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_ws.Migrations
{
    public partial class AddedUniqueField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Atms_globalatmid",
                table: "Atms",
                column: "globalatmid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Atms_globalatmid",
                table: "Atms");
        }
    }
}
