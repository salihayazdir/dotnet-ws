using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_ws.Migrations
{
    public partial class CreateInitial_DecimalFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "geocodelongitude",
                table: "Atms",
                type: "decimal(8,6)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "geocodelatitude",
                table: "Atms",
                type: "decimal(8,6)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "geocodelongitude",
                table: "Atms",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "geocodelatitude",
                table: "Atms",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,6)",
                oldNullable: true);
        }
    }
}
