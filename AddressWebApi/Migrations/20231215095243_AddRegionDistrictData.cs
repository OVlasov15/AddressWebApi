﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRegionDistrictData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegionDistricts",
                columns: new string[] { "Id", "RegionId", "Name" },
                values: new object[,]
                {
                    //Вінницька область 6
                    { 1,  1, "Вінницький район" },
                    { 2,  1, "Гайсинський район" },
                    { 3,  1, "Жмеринський район"},
                    { 4,  1, "Могилів-Подільський район" },
                    { 5,  1, "Тульчинський район" },
                    { 6,  1, "Хмільницький район" },

                    //Волинська область 4
                    { 7,  2, "Володимирський район" },
                    { 8,  2, "Камінь-Каширський район" },
                    { 9,  2, "Ковельський район" },
                    { 10, 2, "Луцький район" },

                    //Дніпропетровська область 7
                    { 11, 3, "Дніпровський район" },
                    { 12, 3, "Кам'янський район" },
                    { 13, 3, "Криворізький район" },
                    { 14, 3, "Нікопольський район" },
                    { 15, 3, "Новомосковський район" },
                    { 16, 3, "Павлоградський район" },
                    { 17, 3, "Синельниківський район" },

                    //Донецька область 8
                    { 18, 4, "Бахмутський район" },
                    { 19, 4, "Волноваський район" },
                    { 20, 4, "Горлівський район" },
                    { 21, 4, "Донецький район" },
                    { 22, 4, "Кальміуський район" },
                    { 23, 4, "Краматорський район" },
                    { 24, 4, "Маріупольський район" },
                    { 25, 4, "Покровський райо" },

                    //Житомирська область 4
                    { 26, 5, "Бердичівський район" },
                    { 27, 5, "Житомирський район" },
                    { 28, 5, "Звягельський район" },
                    { 29, 5, "Коростенський район" },

                    //Закарпатська область 6
                    { 30, 6, "Берегівський район" },
                    { 31, 6, "Мукачівський район" },
                    { 32, 6, "Рахівський район" },
                    { 33, 6, "Тячівський район" },
                    { 34, 6, "Ужгородський район" },
                    { 35, 6, "Хустський район" },

                    //Запорізька область 5
                    { 36, 7, "Бердянський район" },
                    { 37, 7, "Василівський район" },
                    { 38, 7, "Запорізький район" },
                    { 39, 7, "Мелітопольський район" },
                    { 40, 7, "Пологівський район" },

                    //Івано-Франківська область 6
                    { 41, 8, "Верховинський район" },
                    { 42, 8, "Івано-Франківський район" },
                    { 43, 8, "Калуський район" },
                    { 44, 8, "Коломийський район" },
                    { 45, 8, "Косівський район" },
                    { 46, 8, "Надвірнянський район" },

                    //Київська область 7
                    { 47, 9, "Білоцерківський район" },
                    { 48, 9, "Бориспільський район" },
                    { 49, 9, "Броварський район" },
                    { 50, 9, "Бучанський район" },
                    { 51, 9, "Вишгородський район" },
                    { 52, 9, "Обухівський район" },
                    { 53, 9, "Фастівський район" },

                    //Кіровоградська область 4
                    { 54, 10, "Голованівський район" },
                    { 55, 10, "Кропивницький район" },
                    { 56, 10, "Новоукраїнський район" },
                    { 57, 10, "Олександрійський район" },

                    //Луганська область 8
                    { 58, 11, "Алчевський район" },
                    { 59, 11, "Довжанський район" },
                    { 60, 11, "Луганський район" },
                    { 61, 11, "Ровеньківський район" },
                    { 62, 11, "Сватівський район" },
                    { 63, 11, "Сєвєродонецький район" },
                    { 64, 11, "Старобільський район" },
                    { 65, 11, "Щастинський район" },

                    //Львівська область 7
                    { 66, 12, "Дрогобицький район" },
                    { 67, 12, "Золочівський район" },
                    { 68, 12, "Львівський район" },
                    { 69, 12, "Самбірський район" },
                    { 70, 12, "Стрийський район" },
                    { 71, 12, "Червоноградський" },
                    { 72, 12, "Яворівський район" },

                    //Миколаївська область 4
                    { 73, 13, "Баштанський район" },
                    { 74, 13, "Вознесенський район" },
                    { 75, 13, "Миколаївський район" },
                    { 76, 13, "Первомайський район" },

                    //Одеська область 7
                    { 77, 14, "Березівський район" },
                    { 78, 14, "Білгород-Дністровський район" },
                    { 79, 14, "Болградський район" },
                    { 80, 14, "Ізмаїльський район" },
                    { 81, 14, "Одеський район" },
                    { 82, 14, "Подільський район" },
                    { 83, 14, "Роздільнянський район" },

                    //Полтавська область 4
                    { 84, 15, "Кременчуцький район" },
                    { 85, 15, "Лубенський район" },
                    { 86, 15, "Миргородський район" },
                    { 87, 15, "Полтавський район" },

                    //Рівненська область 4
                    { 88, 16, "Вараський район" },
                    { 89, 16, "Дубенський район" },
                    { 90, 16, "Рівненський район" },
                    { 91, 16, "Сарненський район" },

                    //Сумська область 5
                    { 92, 17, "Конотопський район" },
                    { 93, 17, "Охтирський район" },
                    { 94, 17, "Роменський район" },
                    { 95, 17, "Сумський район" },
                    { 96, 17, "Шосткинський район" },

                    //Тернопільська область 3
                    { 97, 18, "Кременецький район" },
                    { 98, 18, "Тернопільський район" },
                    { 99, 18, "Чортківський район" },

                    //Харківська область 7
                    { 100, 19, "Богодухівський район" },
                    { 101, 19, "Ізюмський район" },
                    { 102, 19, "Красноградський район" },
                    { 103, 19, "Куп'янський район" },
                    { 104, 19, "Лозівський район" },
                    { 105, 19, "Харківський район" },
                    { 106, 19, "Чугуївський район" },

                    //Херсонська область 5
                    { 107, 20, "Бериславський район" },
                    { 108, 20, "Генічеський район" },
                    { 109, 20, "Каховський район" },
                    { 110, 20, "Скадовський район" },
                    { 111, 20, "Херсонський район" },

                    //Хмельницька область 3
                    { 112, 21, "Кам'янець-Подільський район" },
                    { 113, 21, "Хмельницький район" },
                    { 114, 21, "Шепетівський район" },

                    //Черкаська область 4
                    { 115, 22, "Звенигородський район" },
                    { 116, 22, "Золотоніський район" },
                    { 117, 22, "Уманський район" },
                    { 118, 22, "Черкаський район" },

                    //Чернівецька область 3
                    { 119, 23, "Вижницький район" },
                    { 120, 23, "Дністровський район" },
                    { 121, 23, "Чернівецький район" },

                    //Чернігівська область 5
                    { 122, 24, "Корюківський район" },
                    { 123, 24, "Ніжинський район" },
                    { 124, 24, "Новгород-Сіверський район" },
                    { 125, 24, "Прилуцький район" },
                    { 126, 24, "Чернігівський район" },

                    //АР Автономна Республіка Крим 10
                    { 127, 25, "Бахчисарайський район" },
                    { 128, 25, "Білогірський район" },
                    { 129, 25, "Джанкойський район" },
                    { 130, 25, "Євпаторійський район" },
                    { 131, 25, "Керченський район" },
                    { 132, 25, "Курманський район" },
                    { 133, 25, "Перекопський район" },
                    { 134, 25, "Сімферопольський район" },
                    { 135, 25, "Феодосійський район" },
                    { 136, 25, "Ялтинський район" }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}