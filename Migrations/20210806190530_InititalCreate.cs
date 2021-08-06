using Microsoft.EntityFrameworkCore.Migrations;

namespace EXAMPLEEFCF.Migrations
{
    public partial class InititalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VersionOfMe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionOfMe", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CarGranTrofeo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelCar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionOfMeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarGranTrofeo", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarGranTrofeo_VersionOfMe_VersionOfMeid",
                        column: x => x.VersionOfMeid,
                        principalTable: "VersionOfMe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarGranTrofeo_VersionOfMeid",
                table: "CarGranTrofeo",
                column: "VersionOfMeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarGranTrofeo");

            migrationBuilder.DropTable(
                name: "VersionOfMe");
        }
    }
}
