using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRegionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new string[] { "Id", "Name", "AmountRegionDistrict" },
                values: new object[,]
                {
                    { 1,  "Вінницька область", 6 },
                    { 2,  "Волинська область", 4 },
                    { 3,  "Дніпропетровська область", 7 },
                    { 4,  "Донецька область", 8 },
                    { 5,  "Житомирська область", 4 },
                    { 6,  "Закарпатська область", 6 },
                    { 7,  "Запорізька область", 5 },
                    { 8,  "Івано-Франківська область", 6 },
                    { 9,  "Київська область", 7 },
                    { 10, "Кіровоградська область", 4 },
                    { 11, "Луганська область", 8 },
                    { 12, "Львівська область", 7 },
                    { 13, "Миколаївська область", 4 },
                    { 14, "Одеська область", 7 },
                    { 15, "Полтавська область", 4 },
                    { 16, "Рівненська область", 4 },
                    { 17, "Сумська область", 5 },
                    { 18, "Тернопільська область", 3 },
                    { 19, "Харківська область", 7 },
                    { 20, "Херсонська область", 5 },
                    { 21, "Хмельницька область", 3 },
                    { 22, "Черкаська область", 4 },
                    { 23, "Чернівецька область", 3 },
                    { 24, "Чернігівська область", 5 },
                    { 25, "Автономна Республіка Крим", 10 }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
