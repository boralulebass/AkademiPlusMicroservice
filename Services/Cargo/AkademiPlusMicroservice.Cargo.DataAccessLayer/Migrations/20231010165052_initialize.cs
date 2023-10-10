using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkademiPlusMicroservice.Cargo.DataAccessLayer.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoStates",
                columns: table => new
                {
                    CargoStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoStates", x => x.CargoStateId);
                });

            migrationBuilder.CreateTable(
                name: "CargoDetails",
                columns: table => new
                {
                    CargoDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderingId = table.Column<int>(type: "int", nullable: false),
                    CargoStateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDetails", x => x.CargoDetailId);
                    table.ForeignKey(
                        name: "FK_CargoDetails_CargoStates_CargoStateId",
                        column: x => x.CargoStateId,
                        principalTable: "CargoStates",
                        principalColumn: "CargoStateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetails_CargoStateId",
                table: "CargoDetails",
                column: "CargoStateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoDetails");

            migrationBuilder.DropTable(
                name: "CargoStates");
        }
    }
}
