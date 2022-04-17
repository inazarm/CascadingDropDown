using Microsoft.EntityFrameworkCore.Migrations;

namespace CascadingDropdown.Migrations
{
    public partial class cascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblState_tblCountry_countryId",
                        column: x => x.countryId,
                        principalTable: "tblCountry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCity_tblState_stateId",
                        column: x => x.stateId,
                        principalTable: "tblState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCity_stateId",
                table: "tblCity",
                column: "stateId");

            migrationBuilder.CreateIndex(
                name: "IX_tblState_countryId",
                table: "tblState",
                column: "countryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCity");

            migrationBuilder.DropTable(
                name: "tblState");

            migrationBuilder.DropTable(
                name: "tblCountry");
        }
    }
}
