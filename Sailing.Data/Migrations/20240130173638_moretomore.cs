using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sailing.Data.Migrations
{
    public partial class moretomore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoatBoatDriver",
                columns: table => new
                {
                    DriversId = table.Column<int>(type: "int", nullable: false),
                    boatsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatBoatDriver", x => new { x.DriversId, x.boatsId });
                    table.ForeignKey(
                        name: "FK_BoatBoatDriver_boatDrivers_DriversId",
                        column: x => x.DriversId,
                        principalTable: "boatDrivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoatBoatDriver_boats_boatsId",
                        column: x => x.boatsId,
                        principalTable: "boats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoatBoatDriver_boatsId",
                table: "BoatBoatDriver",
                column: "boatsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoatBoatDriver");
        }
    }
}
