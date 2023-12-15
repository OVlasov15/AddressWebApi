﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCityDistrictData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CityDistricts",
                columns: new string[] { "Id", "SettlementId", "Name" },
                values: new object[,]
                {
                    //Місто Вінниця 3
                    { 1,  1, "Замостянський район" },
                    { 2,  1, "Ленінський район" },
                    { 3,  1, "Староміській район" },

                    //Місто Луцьк - не має районів
                    
                    //Місто Дніпро 8
                    { 4,  30, "Амур-Нижньодніпровський район" },
                    { 5,  30, "Індустріальний район" },
                    { 6,  30, "Новокодацький район" },
                    { 7,  30, "Соборний район" },
                    { 8,  30, "Самарський район" },
                    { 9,  30, "Центральний район" },
                    { 10, 30, "Чечелівський район" },
                    { 11, 30, "Шевченківський район" },

                    //Місто	Донецьк 8
                    { 12, 70, "Будьонівський район" },
                    { 13, 70, "Ворошиловський район" },
                    { 14, 70, "Калінінський район" },
                    { 15, 70, "Київський район" },
                    { 16, 70, "Кіровський район" },
                    { 17, 70, "Куйбишевський район" },
                    { 18, 70, "Ленінський район" },
                    { 19, 70, "Петровський район" },
                    { 20, 70, "Пролетарський район" },

                    //Місто Житомир 2
                    { 21, 104, "Богунський район" },
                    { 22, 104, "Корольовський район" },

                    //Місто Ужгород - не має районів 

                    //Місто	Запоріжжя 7
                    { 23, 132, "Вознесенівський район" },
                    { 24, 132, "Дніпровський район" },
                    { 25, 132, "Заводський район" },
                    { 26, 132, "Комунарський район" },
                    { 27, 132, "Олександрівський район" },
                    { 28, 132, "Хортицький район" },
                    { 29, 132, "Шевченківський район" },

                    //Місто Івано-Франківськ - не має районів

                    //Місто Київ 10
                    { 30, 460, "Голосiївський район" },
                    { 31, 460, "Дарницький район" },
                    { 32, 460, "Деснянський район" },
                    { 33, 460, "Днiпровський район" },
                    { 34, 460, "Оболонський район" },
                    { 35, 460, "Печерський район" },
                    { 36, 460, "Подiльський район" },
                    { 37, 460, "Святошинський район" },
                    { 38, 460, "Солом'янський район" },
                    { 39, 460, "Шевченківський район" },

                    //Місто Луганськм 4
                    { 40, 207, "Артемівський район" },
                    { 41, 207, "Жовтневий район" },
                    { 42, 207, "Кам'янобрідський район" },
                    { 43, 207, "Ленінський район" },

                    //Місто Львів 6
                    { 44, 244, "Галицький район" },
                    { 45, 244, "Залізничний район" },
                    { 46, 244, "Личаківський район" },
                    { 47, 244, "Сихівський район" },
                    { 48, 244, "Франківський район" },
                    { 49, 244, "Шевченківський район" },

                    //Місто Миколаїв 4
                    { 50, 278, "Заводський район" },
                    { 51, 278, "Інгульський район" },
                    { 52, 278, "Корабельний район" },
                    { 53, 278, "Центральний район" },

                    //Місто Одеса 4
                    { 54, 292, "Київський район" },
                    { 55, 292, "Пересипський район" },
                    { 56, 292, "Приморський район" },
                    { 57, 292, "Хаджибейський район" },

                    //Місто Полтава 3
                    { 58, 315, "Київський район" },
                    { 59, 315, "Подільський район" },
                    { 60, 315, "Шевченківський район" },         

                    //Місто Рівне - не має районів

                    //Місто Суми 2
                    { 61, 338, "Зарічний район" },
                    { 62, 338, "Ковпаківський район" },            

                    //Місто Тернопіль - не має районів

                    //Місто Харків 9
                    { 63, 374, "Індустріальний район" },
                    { 64, 374, "Київський район" },
                    { 65, 374, "Немишлянський район" },
                    { 66, 374, "Новобаварський район" },
                    { 67, 374, "Основ'янський район" },
                    { 68, 374, "Салтівський район" },
                    { 69, 374, "Слобідський район" },
                    { 70, 374, "Холодногірський район" },
                    { 71, 374, "Шевченківський район" },

                    //Місто Херсон 3
                    { 72, 386, "Дніпровський район" },
                    { 73, 386, "Корабельний район" },
                    { 74, 386, "Центральний район" },

                    //Місто Хмельницький - не має районів

                    //Місто Черкаси 2
                    { 75, 414, "Придніпровський район" },
                    { 76, 414, "Соснівський район" },

                    //Місто Чернівці 3
                    { 77, 426, "Першотравневий район" },
                    { 78, 426, "Садгірський район" },
                    { 79, 426, "Шевченківський район" },

                    //Місто Чернігів 2
                    { 80, 442, "Деснянський район" },
                    { 81, 442, "Новозаводський район" },

                    //м. Севастополь 4
                    { 82, 461, "Балаклавський район" },
                    { 83, 461, "Гагарінський район" },
                    { 84, 461, "Ленінський район" },
                    { 85, 461, "Нахімовський район" }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}