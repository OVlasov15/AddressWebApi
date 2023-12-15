using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSettlementTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settlements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    RegionDistrictId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settlements_RegionDistricts_RegionDistrictId",
                        column: x => x.RegionDistrictId,
                        principalTable: "RegionDistricts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_RegionDistrictId",
                table: "Settlements",
                column: "RegionDistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settlements");
        }
    }
}
