using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddStreetTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    SettlementId = table.Column<int>(type: "int", nullable: false),
                    CityDistrictId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Streets_CityDistricts_CityDistrictId",
                        column: x => x.CityDistrictId,
                        principalTable: "CityDistricts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Streets_Settlements_SettlementId",
                        column: x => x.SettlementId,
                        principalTable: "Settlements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Streets_CityDistrictId",
                table: "Streets",
                column: "CityDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_SettlementId",
                table: "Streets",
                column: "SettlementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Streets");
        }
    }
}
