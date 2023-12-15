using AddressWebApi.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSettlementCityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settlements",
                columns: new string[] { "Id", "RegionDistrictId", "Name", "Type" },
                values: new object[,]
                {
                    //Вінницька область - 18 міст

                    //Вінницький район 6
                    { 1,  1, "м. Вінниця", (int)SettlementType.City },
                    { 2,  1, "м. Іллінці", (int)SettlementType.City },
                    { 3,  1, "м. Немирів", (int)SettlementType.City },
                    { 4,  1, "м. Погребище", (int)SettlementType.City },
                    { 5,  1, "м. Липовець", (int)SettlementType.City },
                    { 6,  1, "м. Гнівань", (int)SettlementType.City },
                    //Гайсинський район 3
                    { 7,  2, "м. Гайсин", (int)SettlementType.City },
                    { 8,  2, "м. Бершадь", (int)SettlementType.City },
                    { 9,  2, "м. Ладижин", (int)SettlementType.City },
                    //Жмеринський район 3
                    { 10, 3, "м. Бар", (int)SettlementType.City },
                    { 11, 3, "м. Жмеринка", (int)SettlementType.City },
                    { 12, 3, "м. Шаргород", (int)SettlementType.City },
                    //Могилів-Подільський район 2
                    { 13, 4, "м. Могилів-Подільський", (int)SettlementType.City },
                    { 14, 4, "м. Ямпіль", (int)SettlementType.City },
                    //Тульчинський район 1
                    { 15, 5, "м. Тульчин", (int)SettlementType.City },
                    //Хмільницький район 3
                    { 16, 6, "м. Хмільник", (int)SettlementType.City },
                    { 17, 6, "м. Козятин", (int)SettlementType.City },
                    { 18, 6, "м. Калинівка", (int)SettlementType.City },

                    //Волинська область - 11 міст

                    //Володимирський район 3
                    { 19,  7, "м. Володимир", (int)SettlementType.City },
                    { 20,  7, "м. Нововолинськ", (int)SettlementType.City },
                    { 21,  7, "м. Устилуг", (int)SettlementType.City },
                    //Камінь-Каширський район 1
                    { 22,  8, "м. Камінь-Каширський", (int)SettlementType.City },
                    //Ковельський район 2
                    { 23,  9, "м. Ковель", (int)SettlementType.City },
                    { 24,  9, "м. Любомль", (int)SettlementType.City },
                    //Луцький район 5
                    { 25,  10, "м. Берестечко", (int)SettlementType.City },
                    { 26,  10, "м. Горохів", (int)SettlementType.City },
                    { 27,  10, "м. Ківерці", (int)SettlementType.City },
                    { 28,  10, "м. Луцьк", (int)SettlementType.City },
                    { 29,  10, "м. Рожище", (int)SettlementType.City },

                    //Дніпропетровська область - 20 міст

                    //Дніпровський район 2
                    { 30,  11, "м. Дніпро", (int)SettlementType.City },
                    { 31,  11, "м. Підгородне", (int)SettlementType.City },
                    //Кам'янський район 6
                    { 32,  12, "м. Верхівцеве", (int)SettlementType.City },
                    { 33,  12, "м. Верхньодніпровськ", (int)SettlementType.City },
                    { 34,  12, "м. Вільногірськ", (int)SettlementType.City },
                    { 35,  12, "м. Жовті Води", (int)SettlementType.City },
                    { 36,  12, "м. Кам'янське", (int)SettlementType.City },
                    { 37,  12, "м. П'ятихатки", (int)SettlementType.City },
                    //Криворізький район 3 
                    { 38,  13, "м. Апостолове", (int)SettlementType.City },
                    { 39,  13, "м. Зеленодольськ", (int)SettlementType.City },
                    { 40,  13, "м. Кривий Ріг", (int)SettlementType.City },
                    //Нікопольський район 3
                    { 41,  14, "м. Марганець", (int)SettlementType.City },
                    { 42,  14, "м. Нікополь", (int)SettlementType.City },
                    { 43,  14, "м. Покров", (int)SettlementType.City },
                    //Новомосковський район 2
                    { 44,  15, "м. Новомосковськ", (int)SettlementType.City },
                    { 45,  15, "м. Перещепине", (int)SettlementType.City },
                    //Павлоградський район 2
                    { 46,  16, "м. Павлоград", (int)SettlementType.City },
                    { 47,  16, "м. Тернівка", (int)SettlementType.City },
                    //Синельниківський район 2
                    { 48,  17, "м. Першотравенськ", (int)SettlementType.City },
                    { 49,  17, "м. Синельникове", (int)SettlementType.City },

                    //Донецька область - 52 міста

                    //Бахмутський район 7
                    { 50,  18, "м. Бахмут", (int)SettlementType.City },
                    { 51,  18, "м. Залізне", (int)SettlementType.City },
                    { 52,  18, "м. Світлодарськ", (int)SettlementType.City },
                    { 53,  18, "м. Сіверськ", (int)SettlementType.City },
                    { 54,  18, "м. Соледар", (int)SettlementType.City },
                    { 55,  18, "м. Торецьк", (int)SettlementType.City },
                    { 56,  18, "м. Часів Яр", (int)SettlementType.City },
                    //Волноваський район 2 
                    { 57,  19, "м. Волноваха", (int)SettlementType.City },
                    { 58,  19, "м. Вугледар", (int)SettlementType.City },
                    //Горлівський район 10 
                    { 59,  20, "м. Бунге", (int)SettlementType.City },
                    { 60,  20, "м. Вуглегірськ", (int)SettlementType.City },
                    { 61,  20, "м. Горлівка", (int)SettlementType.City },
                    { 62,  20, "м. Дебальцеве", (int)SettlementType.City },
                    { 63,  20, "м. Єнакієве", (int)SettlementType.City },
                    { 64,  20, "м. Жданівка", (int)SettlementType.City },
                    { 65,  20, "м. Сніжне", (int)SettlementType.City },
                    { 66,  20, "м. Хрестівка", (int)SettlementType.City },
                    { 67,  20, "м. Чистякове", (int)SettlementType.City },
                    { 68,  20, "м. Шахтарськ", (int)SettlementType.City },
                    //Донецький район 8 
                    { 69,  21, "м. Амвросіївка", (int)SettlementType.City },
                    { 70,  21, "м. Донецьк", (int)SettlementType.City },
                    { 71,  21, "м. Зугрес", (int)SettlementType.City },
                    { 72,  21, "м. Іловайськ", (int)SettlementType.City },
                    { 73,  21, "м. Макіївка", (int)SettlementType.City },
                    { 74,  21, "м. Моспине", (int)SettlementType.City },
                    { 75,  21, "м. Харцизьк", (int)SettlementType.City },
                    { 76,  21, "м. Ясинувата", (int)SettlementType.City },
                    //Кальміуський район 3 
                    { 77,  22, "м. Докучаєвськ", (int)SettlementType.City },
                    { 78,  22, "м. Кальміуське", (int)SettlementType.City },
                    { 79,  22, "м. Новоазовськ", (int)SettlementType.City },
                    //Краматорський район 7 
                    { 80,  23, "м. Дружківка", (int)SettlementType.City },
                    { 81,  23, "м. Костянтинівка", (int)SettlementType.City },
                    { 82,  23, "м. Краматорськ", (int)SettlementType.City },
                    { 83,  23, "м. Лиман", (int)SettlementType.City },
                    { 84,  23, "м. Миколаївка", (int)SettlementType.City },
                    { 85,  23, "м. Святогірськ", (int)SettlementType.City },
                    { 86,  23, "м. Слов'янськ", (int)SettlementType.City },
                    //Маріупольський район 1
                    { 87,  24, "м. Маріуполь", (int)SettlementType.City },
                    //Покровський район 14
                    { 88,  25, "м. Авдіївка", (int)SettlementType.City },
                    { 89,  25, "м. Білицьке", (int)SettlementType.City },
                    { 90,  25, "м. Білозерське", (int)SettlementType.City },
                    { 91,  25, "м. Гірник", (int)SettlementType.City },
                    { 92,  25, "м. Добропілля", (int)SettlementType.City },
                    { 93,  25, "м. Красногорівка", (int)SettlementType.City },
                    { 94,  25, "м. Курахове", (int)SettlementType.City },
                    { 95,  25, "м. Мар’їнка", (int)SettlementType.City },
                    { 96,  25, "м. Мирноград", (int)SettlementType.City },
                    { 97,  25, "м. Новогродівка", (int)SettlementType.City },
                    { 98,  25, "м. Покровськ", (int)SettlementType.City },
                    { 99,  25, "м. Родинське", (int)SettlementType.City },
                    { 100, 25, "м. Селидове", (int)SettlementType.City },
                    { 101, 25, "м. Українськ", (int)SettlementType.City },

                    //Житомирська область - 12 міст

                    //Бердичівський район 2
                    { 102, 26, "м. Андрушівка", (int)SettlementType.City },
                    { 103, 26, "м. Бердичів", (int)SettlementType.City },
                    //Житомирський район 4
                    { 104, 27, "м. Житомир", (int)SettlementType.City },
                    { 105, 27, "м. Коростишів", (int)SettlementType.City },
                    { 106, 27, "м. Радомишль", (int)SettlementType.City },
                    { 107, 27, "м. Чуднів", (int)SettlementType.City },
                    //Звягельський район 2
                    { 108,  28, "м. Баранівка", (int)SettlementType.City },
                    { 109,  28, "м. Звягель", (int)SettlementType.City },
                    //Коростенський район 4
                    { 110,  29, "м. Коростень", (int)SettlementType.City },
                    { 111,  29, "м. Малин", (int)SettlementType.City },
                    { 112,  29, "м. Овруч", (int)SettlementType.City },
                    { 113,  29, "м. Олевськ", (int)SettlementType.City },

                    //Закарпатська область область - 11 міст

                    //Берегівський район 2
                    { 114, 30, "м. Берегове", (int)SettlementType.City },
                    { 115, 30, "м. Виноградів", (int)SettlementType.City },
                    //Мукачівський район 2
                    { 116, 31, "м. Мукачево", (int)SettlementType.City },
                    { 117, 31, "м. Свалява", (int)SettlementType.City },
                    //Рахівський район 1
                    { 118, 32, "м. Рахів", (int)SettlementType.City },
                    //Тячівський район 2
                    { 119, 33, "м. Тячів", (int)SettlementType.City },
                    //Ужгородський район 2
                    { 120, 34, "м. Перечин", (int)SettlementType.City },
                    { 121, 34, "м. Ужгород", (int)SettlementType.City },
                    { 122, 34, "м. Чоп", (int)SettlementType.City },
                    //Хустський район район 2
                    { 123, 35, "м. Іршава", (int)SettlementType.City },
                    { 124, 35, "м. Хуст", (int)SettlementType.City },

                    //Запорізька область область - 14 міст

                    //Бердянський район 2
                    { 125, 36, "м. Бердянськ", (int)SettlementType.City },
                    { 126, 36, "м. Приморськ", (int)SettlementType.City },
                    //Василівський район 4
                    { 127, 37, "м. Василівка", (int)SettlementType.City },
                    { 128, 37, "м. Дніпрорудне", (int)SettlementType.City },
                    { 129, 37, "м. Енергодар", (int)SettlementType.City },
                    { 130, 37, "м. Кам’янка-Дніпровська", (int)SettlementType.City },
                    //Запорізький район 2
                    { 131, 38, "м. Вільнянськ", (int)SettlementType.City },
                    { 132, 38, "м. Запоріжжя", (int)SettlementType.City },
                    //Мелітопольський район 1
                    { 133, 39, "м. Мелітополь", (int)SettlementType.City },
                    //Пологівський район 5
                    { 134, 40, "м. Гуляйполе", (int)SettlementType.City },
                    { 135, 40, "м. Молочанськ", (int)SettlementType.City },
                    { 136, 40, "м. Оріхів", (int)SettlementType.City },
                    { 137, 40, "м. Пологи", (int)SettlementType.City },
                    { 138, 40, "м. Токмак", (int)SettlementType.City },

                    //Івано-Франківська область - 15 міст

                    //Верховинський район 0
                    //Івано-Франківський район 6
                    { 139, 42, "м. Бурштин", (int)SettlementType.City },
                    { 140, 42, "м. Галич", (int)SettlementType.City },
                    { 141, 42, "м. Івано-Франківськ", (int)SettlementType.City },
                    { 142, 42, "м. Рогатин", (int)SettlementType.City },
                    { 143, 42, "м. Тисмениця", (int)SettlementType.City },
                    { 144, 42, "м. Тлумач", (int)SettlementType.City },
                    //Калуський район 3
                    { 145, 43, "м. Болехів", (int)SettlementType.City },
                    { 146, 43, "м. Долина", (int)SettlementType.City },
                    { 147, 43, "м. Калуш", (int)SettlementType.City },
                    //Коломийський район 3
                    { 148, 44, "м. Городенка", (int)SettlementType.City },
                    { 149, 44, "м. Коломия", (int)SettlementType.City },
                    { 150, 44, "м. Снятин", (int)SettlementType.City },
                    //Косівський район 1
                    { 151, 45, "м. Косів", (int)SettlementType.City },
                    //Надвірнянський район 2
                    { 152, 46, "м. Надвірна", (int)SettlementType.City },
                    { 153, 46, "м. Яремче", (int)SettlementType.City },

                    //Київська область - 26 міст

                    //Білоцерківський район 5
                    { 154, 47, "м. Біла Церква", (int)SettlementType.City },
                    { 155, 47, "м. Сквира", (int)SettlementType.City },
                    { 156, 47, "м. Тараща", (int)SettlementType.City },
                    { 157, 47, "м. Тетіїв", (int)SettlementType.City },
                    { 158, 47, "м. Узин", (int)SettlementType.City },
                    //Бориспільський район 3
                    { 159, 48, "м. Бориспіль", (int)SettlementType.City },
                    { 160, 48, "м. Переяслав", (int)SettlementType.City },
                    { 161, 48, "м. Яготин", (int)SettlementType.City },
                    //Броварський район 2
                    { 162, 49, "м. Березань", (int)SettlementType.City },
                    { 163, 49, "м. Бровари", (int)SettlementType.City },
                    //Бучанський район 3
                    { 164, 50, "м. Буча", (int)SettlementType.City },
                    { 165, 50, "м. Вишневе", (int)SettlementType.City },
                    { 166, 50, "м. Ірпінь", (int)SettlementType.City },
                    //Вишгородський район 4
                    { 167, 51, "м. Вишгород", (int)SettlementType.City },
                    { 168, 51, "м. Прип'ять", (int)SettlementType.City },
                    { 169, 51, "м. Славутич", (int)SettlementType.City },
                    { 170, 51, "м. Чорнобиль", (int)SettlementType.City },
                    //Обухівський район 7
                    { 171, 52, "м. Богуслав", (int)SettlementType.City },
                    { 172, 52, "м. Васильків", (int)SettlementType.City },
                    { 173, 52, "м. Кагарлик", (int)SettlementType.City },
                    { 174, 52, "м. Миронівка", (int)SettlementType.City },
                    { 175, 52, "м. Обухів", (int)SettlementType.City },
                    { 176, 52, "м. Ржищів", (int)SettlementType.City },
                    { 177, 52, "м. Українка", (int)SettlementType.City },
                    //Фастівський район 2
                    { 178, 53, "м. Боярка", (int)SettlementType.City },
                    { 179, 53, "м. Фастів", (int)SettlementType.City },

                    //Кіровоградська область - 12 міст

                    //Голованівський район 2
                    { 180, 54, "м. Благовіщенське", (int)SettlementType.City },
                    { 181, 54, "м. Гайворон", (int)SettlementType.City },
                    //Кропивницький район 4
                    { 182, 55, "м. Бобринець", (int)SettlementType.City },
                    { 183, 55, "м. Долинська", (int)SettlementType.City },
                    { 184, 55, "м. Знам'янка", (int)SettlementType.City },
                    { 185, 55, "м. Кропивницький", (int)SettlementType.City },
                    //Новоукраїнський район 4
                    { 186, 56, "м. Мала Виска", (int)SettlementType.City },
                    { 187, 56, "м. Новомиргород", (int)SettlementType.City },
                    { 188, 56, "м. Новоукраїнка", (int)SettlementType.City },
                    { 189, 56, "м. Помічна", (int)SettlementType.City },
                    //Олександрійський район 2
                    { 190, 57, "м. Олександрія", (int)SettlementType.City },
                    { 191, 57, "м. Світловодськ", (int)SettlementType.City },

                    //Луганська область - 37 міст

                    //Алчевський район 11
                    { 192, 58, "м. Алмазна", (int)SettlementType.City },
                    { 193, 58, "м. Алчевськ", (int)SettlementType.City },
                    { 194, 58, "м. Брянка", (int)SettlementType.City },
                    { 195, 58, "м. Голубівка", (int)SettlementType.City },
                    { 196, 58, "м. Зимогір'я", (int)SettlementType.City },
                    { 197, 58, "м. Зоринськ", (int)SettlementType.City },
                    { 198, 58, "м. Ірміно", (int)SettlementType.City },
                    { 199, 58, "м. Кадіївка", (int)SettlementType.City },
                    { 200, 58, "м. Кипуче", (int)SettlementType.City },
                    { 201, 58, "м. Первомайськ", (int)SettlementType.City },
                    { 202, 58, "м. Перевальськ", (int)SettlementType.City },
                    //Довжанський район 4
                    { 203, 59, "м. Вознесенівка", (int)SettlementType.City },
                    { 204, 59, "м. Довжанськ", (int)SettlementType.City },
                    { 205, 59, "м. Сорокине", (int)SettlementType.City },
                    { 206, 59, "м. Суходільськ", (int)SettlementType.City },
                    //Луганський район 4
                    { 207, 60, "м. Луганськ", (int)SettlementType.City },
                    { 208, 60, "м. Лутугине", (int)SettlementType.City },
                    { 209, 60, "м. Молодогвардійськ", (int)SettlementType.City },
                    { 210, 60, "м. Олександрівськ", (int)SettlementType.City },
                    //Ровеньківський район 6
                    { 211, 61, "м. Антрацит", (int)SettlementType.City },
                    { 212, 61, "м. Боково-Хрустальне", (int)SettlementType.City },
                    { 213, 61, "м. Міусинськ", (int)SettlementType.City },
                    { 214, 61, "м. Петрово-Красносілля", (int)SettlementType.City },
                    { 215, 61, "м. Ровеньки", (int)SettlementType.City },
                    { 216, 61, "м. Хрустальний", (int)SettlementType.City },
                    //Сватівський район 1
                    { 217, 62, "м. Сватове", (int)SettlementType.City },
                    //Сєвєродонецький район 9
                    { 218, 63, "м. Гірське", (int)SettlementType.City },
                    { 219, 63, "м. Золоте", (int)SettlementType.City },
                    { 220, 63, "м. Кремінна", (int)SettlementType.City },
                    { 221, 63, "м. Лисичанськ", (int)SettlementType.City },
                    { 222, 63, "м. Новодружеськ", (int)SettlementType.City },
                    { 223, 63, "м. Попасна", (int)SettlementType.City },
                    { 224, 63, "м. Привілля", (int)SettlementType.City },
                    { 225, 63, "м. Рубіжне", (int)SettlementType.City },
                    { 226, 63, "м. Сєвєродонецьк", (int)SettlementType.City },
                    //Старобільський район 1
                    { 227, 64, "м. Старобільськ", (int)SettlementType.City },
                    //Щастинський район 1
                    { 228, 65, "м. Щастя", (int)SettlementType.City },

                    //Львівська область - 44 міста

                    //Дрогобицький район 4
                    { 229, 66, "м. Борислав", (int)SettlementType.City },
                    { 230, 66, "м. Дрогобич", (int)SettlementType.City },
                    { 231, 66, "м. Стебник", (int)SettlementType.City },
                    { 232, 66, "м. Трускавець", (int)SettlementType.City },
                    //Золочівський район 3
                    { 233, 67, "м. Броди", (int)SettlementType.City },
                    { 234, 67, "м. Буськ", (int)SettlementType.City },
                    { 235, 67, "м. Золочів", (int)SettlementType.City },
                    //Львівський район 12
                    { 236, 68, "м. Бібрка", (int)SettlementType.City },
                    { 237, 68, "м. Винники", (int)SettlementType.City },
                    { 238, 68, "м. Глиняни", (int)SettlementType.City },
                    { 239, 68, "м. Городок", (int)SettlementType.City },
                    { 240, 68, "м. Дубляни", (int)SettlementType.City },
                    { 241, 68, "м. Жовква", (int)SettlementType.City },
                    { 242, 68, "м. Кам'янка-Бузька", (int)SettlementType.City },
                    { 243, 68, "м. Комарно", (int)SettlementType.City },
                    { 244, 68, "м. Львів", (int)SettlementType.City },
                    { 245, 68, "м. Перемишляни", (int)SettlementType.City },
                    { 246, 68, "м. Пустомити", (int)SettlementType.City },
                    { 247, 68, "м. Рава-Руська", (int)SettlementType.City },
                    //Самбірський район 7
                    { 248, 69, "м. Добромиль", (int)SettlementType.City },
                    { 249, 69, "м. Новий Калинів", (int)SettlementType.City },
                    { 250, 69, "м. Рудки", (int)SettlementType.City },
                    { 251, 69, "м. Самбір", (int)SettlementType.City },
                    { 252, 69, "м. Старий Самбір", (int)SettlementType.City },
                    { 253, 69, "м. Турка", (int)SettlementType.City },
                    { 254, 69, "м. Хирів", (int)SettlementType.City },
                    //Стрийський район 7
                    { 255, 70, "м. Жидачів", (int)SettlementType.City },
                    { 256, 70, "м. Миколаїв", (int)SettlementType.City },
                    { 257, 70, "м. Моршин", (int)SettlementType.City },
                    { 258, 70, "м. Новий Розділ", (int)SettlementType.City },
                    { 259, 70, "м. Сколе", (int)SettlementType.City },
                    { 260, 70, "м. Стрий", (int)SettlementType.City },
                    { 261, 70, "м. Ходорів", (int)SettlementType.City },
                    //Червоноградський 7
                    { 262, 71, "м. Белз", (int)SettlementType.City },
                    { 263, 71, "м. Великі Мости", (int)SettlementType.City },
                    { 264, 71, "м. Радехів", (int)SettlementType.City },
                    { 265, 71, "м. Сокаль", (int)SettlementType.City },
                    { 266, 71, "м. Соснівка", (int)SettlementType.City },
                    { 267, 71, "м. Угнів", (int)SettlementType.City },
                    { 268, 71, "м. Червоноград", (int)SettlementType.City },
                    //Яворівський район 4
                    { 269, 72, "м. Мостиська", (int)SettlementType.City },
                    { 270, 72, "м. Новояворівськ", (int)SettlementType.City },
                    { 271, 72, "м. Судова Вишня", (int)SettlementType.City },
                    { 272, 72, "м. Яворів", (int)SettlementType.City },

                    //Миколаївська область - 9 міст

                    //Баштанський район 3
                    { 273, 73, "м. Баштанка", (int)SettlementType.City },
                    { 274, 73, "м. Новий Буг", (int)SettlementType.City },
                    { 275, 73, "м. Снігурівка", (int)SettlementType.City },
                    //Вознесенський район 2
                    { 276, 74, "м. Вознесенськ", (int)SettlementType.City },
                    { 277, 74, "м. Южноукраїнськ", (int)SettlementType.City },
                    //Миколаївський район 3
                    { 278, 75, "м. Миколаїв", (int)SettlementType.City },
                    { 279, 75, "м. Нова Одеса", (int)SettlementType.City },
                    { 280, 75, "м. Очаків", (int)SettlementType.City },
                    //Первомайський район 1
                    { 281, 76, "м. Первомайськ", (int)SettlementType.City },


                    //Одеська область - 19 міст

                    //Березівський район 1
                    { 282, 77, "м. Березівка", (int)SettlementType.City },
                    //Білгород-Дністровський район 2
                    { 283, 78, "м. Білгород-Дністровський", (int)SettlementType.City },
                    { 284, 78, "м. Татарбунари", (int)SettlementType.City },
                    //Болградський район 2
                    { 285, 79, "м. Арциз", (int)SettlementType.City },
                    { 286, 79, "м. Болград", (int)SettlementType.City },
                    //Ізмаїльський район 4
                    { 287, 80, "м. Вилкове", (int)SettlementType.City },
                    { 288, 80, "м. Ізмаїл", (int)SettlementType.City },
                    { 289, 80, "м. Кілія", (int)SettlementType.City },
                    { 290, 80, "м. Рені", (int)SettlementType.City },
                    //Одеський район 5
                    { 291, 81, "м. Біляївка", (int)SettlementType.City },
                    { 292, 81, "м. Одеса", (int)SettlementType.City },
                    { 293, 81, "м. Теплодар", (int)SettlementType.City },
                    { 294, 81, "м. Чорноморськ", (int)SettlementType.City },
                    { 295, 81, "м. Южне", (int)SettlementType.City },
                    //Подільський район 4
                    { 296, 82, "м. Ананьїв", (int)SettlementType.City },
                    { 297, 82, "м. Балта", (int)SettlementType.City },
                    { 298, 82, "м. Кодима", (int)SettlementType.City },
                    { 299, 82, "м. Подільськ", (int)SettlementType.City },
                    //Роздільнянський район 1
                    { 300, 83, "м. Роздільна", (int)SettlementType.City },

                    //Полтавська область - 16 міст

                    //Кременчуцький район 3
                    { 301, 84, "м. Глобине", (int)SettlementType.City },
                    { 302, 84, "м. Горішні Плавні", (int)SettlementType.City },
                    { 303, 84, "м. Кременчук", (int)SettlementType.City },
                    //Лубенський район 4
                    { 304, 85, "м. Гребінка", (int)SettlementType.City },
                    { 305, 85, "м. Лубни", (int)SettlementType.City },
                    { 306, 85, "м. Пирятин", (int)SettlementType.City },
                    { 307, 85, "м. Хорол", (int)SettlementType.City },
                    //Миргородський район 4
                    { 308, 86, "м. Гадяч", (int)SettlementType.City },
                    { 309, 86, "м. Заводське", (int)SettlementType.City },
                    { 310, 86, "м. Лохвиця", (int)SettlementType.City },
                    { 311, 86, "м. Миргород", (int)SettlementType.City },
                    //Полтавський район 5
                    { 312, 87, "м. Зіньків", (int)SettlementType.City },
                    { 313, 87, "м. Карлівка", (int)SettlementType.City },
                    { 314, 87, "м. Кобеляки", (int)SettlementType.City },
                    { 315, 87, "м. Полтава", (int)SettlementType.City },
                    { 316, 87, "м. Решетилівка", (int)SettlementType.City },

                    //Рівненська область - 11 міст

                    //Вараський район 1
                    { 317, 88, "м. Вараш", (int)SettlementType.City },
                    //Дубенський район 2
                    { 318, 89, "м. Дубно", (int)SettlementType.City },
                    { 319, 89, "м. Радивилів", (int)SettlementType.City },
                    //Рівненський район 6
                    { 320, 90, "м. Березне", (int)SettlementType.City },
                    { 321, 90, "м. Здолбунів", (int)SettlementType.City },
                    { 322, 90, "м. Корець", (int)SettlementType.City },
                    { 323, 90, "м. Костопіль", (int)SettlementType.City },
                    { 324, 90, "м. Острог", (int)SettlementType.City },
                    { 325, 90, "м. Рівне", (int)SettlementType.City },
                    //Сарненський район 2
                    { 326, 91, "м. Дубровиця", (int)SettlementType.City },
                    { 327, 91, "м. Сарни", (int)SettlementType.City },

                    //Сумська область - 15 міст

                    //Конотопський район 4
                    { 328, 92, "м. Буринь", (int)SettlementType.City },
                    { 329, 92, "м. Конотоп", (int)SettlementType.City },
                    { 330, 92, "м. Кролевець", (int)SettlementType.City },
                    { 331, 92, "м. Путивль", (int)SettlementType.City },
                    //Охтирський район 2
                    { 332, 93, "м. Охтирка", (int)SettlementType.City },
                    { 333, 93, "м. Тростянець", (int)SettlementType.City },
                    //Роменський район 1
                    { 334, 94, "м. Ромни", (int)SettlementType.City },
                    //Сумський район 4
                    { 335, 95, "м. Білопілля", (int)SettlementType.City },
                    { 336, 95, "м. Ворожба", (int)SettlementType.City },
                    { 337, 95, "м. Лебедин", (int)SettlementType.City },
                    { 338, 95, "м. Суми", (int)SettlementType.City },
                    //Шосткинський район 4
                    { 339, 96, "м. Глухів", (int)SettlementType.City },
                    { 340, 96, "м. Дружба", (int)SettlementType.City },
                    { 341, 96, "м. Середина-Буда", (int)SettlementType.City },
                    { 342, 96, "м. Шостка", (int)SettlementType.City },

                    //Тернопільська область - 18 міст

                    //Кременецький район 4
                    { 343, 97, "м. Кременець", (int)SettlementType.City },
                    { 344, 97, "м. Ланівці", (int)SettlementType.City },
                    { 345, 97, "м. Почаїв", (int)SettlementType.City },
                    { 346, 97, "м. Шумськ", (int)SettlementType.City },
                    //Тернопільський район 7
                    { 347, 98, "м. Бережани", (int)SettlementType.City },
                    { 348, 98, "м. Збараж", (int)SettlementType.City },
                    { 349, 98, "м. Зборів", (int)SettlementType.City },
                    { 350, 98, "м. Підгайці", (int)SettlementType.City },
                    { 351, 98, "м. Скалат", (int)SettlementType.City },
                    { 352, 98, "м. Теребовля", (int)SettlementType.City },
                    { 353, 98, "м. Тернопіль", (int)SettlementType.City },
                    //Чортківський район 7
                    { 354, 99, "м. Борщів", (int)SettlementType.City },
                    { 355, 99, "м. Бучач", (int)SettlementType.City },
                    { 356, 99, "м. Заліщики", (int)SettlementType.City },
                    { 357, 99, "м. Копичинці", (int)SettlementType.City },
                    { 358, 99, "м. Монастириська", (int)SettlementType.City },
                    { 359, 99, "м. Хоростків", (int)SettlementType.City },
                    { 360, 99, "м. Чортків", (int)SettlementType.City },

                    //Харківська область - 17 міст

                    //Богодухівський район 2
                    { 361, 100, "м. Богодухів", (int)SettlementType.City },
                    { 362, 100, "м. Валки", (int)SettlementType.City },
                    //Ізюмський район 3
                    { 363, 101, "м. Балаклія", (int)SettlementType.City },
                    { 364, 101, "м. Барвінкове", (int)SettlementType.City },
                    { 365, 101, "м. Ізюм", (int)SettlementType.City },
                    //Красноградський район 1
                    { 366, 102, "м. Красноград", (int)SettlementType.City },
                    //Куп'янський район 1
                    { 367, 103, "м. Куп'янськ", (int)SettlementType.City },
                    //Лозівський район 2
                    { 368, 104, "м. Лозова", (int)SettlementType.City },
                    { 369, 104, "м. Первомайський", (int)SettlementType.City },
                    //Харківський район 5
                    { 370, 105, "м. Дергачі", (int)SettlementType.City },
                    { 371, 105, "м. Люботин", (int)SettlementType.City },
                    { 372, 105, "м. Мерефа", (int)SettlementType.City },
                    { 373, 105, "м. Південне", (int)SettlementType.City },
                    { 374, 105, "м. Харків", (int)SettlementType.City },
                    //Чугуївський район 3
                    { 375, 106, "м. Вовчанськ", (int)SettlementType.City },
                    { 376, 106, "м. Зміїв", (int)SettlementType.City },
                    { 377, 106, "м. Чугуїв", (int)SettlementType.City },

                    //Херсонська область - 9 міст

                    //Бериславський район 1
                    { 378, 107, "м. Берислав", (int)SettlementType.City },
                    //Генічеський район 1
                    { 379, 108, "м. Генічеськ", (int)SettlementType.City },
                    //Каховський район 3
                    { 380, 109, "м. Каховка", (int)SettlementType.City },
                    { 381, 109, "м. Нова Каховка", (int)SettlementType.City },
                    { 382, 109, "м. Таврійськ", (int)SettlementType.City },
                    //Скадовський район 2
                    { 383, 110, "м. Гола Пристань", (int)SettlementType.City },
                    { 384, 110, "м. Скадовськ", (int)SettlementType.City },
                    //Херсонський район 2
                    { 385, 111, "м. Олешки", (int)SettlementType.City },
                    { 386, 111, "м. Херсон", (int)SettlementType.City },

                    //Хмельницька область - 13 міст

                    //Кам'янець-Подільський район 2
                    { 387, 112, "м. Дунаївці", (int)SettlementType.City },
                    { 388, 112, "м. Кам'янець-Подільський", (int)SettlementType.City },
                    //Хмельницький район 6
                    { 389, 113, "м. Волочиськ", (int)SettlementType.City },
                    { 390, 113, "м. Городок", (int)SettlementType.City },
                    { 391, 113, "м. Деражня", (int)SettlementType.City },
                    { 392, 113, "м. Красилів", (int)SettlementType.City },
                    { 393, 113, "м. Старокостянтинів", (int)SettlementType.City },
                    { 394, 113, "м. Хмельницький", (int)SettlementType.City },
                    //Шепетівський район 5
                    { 395, 114, "м. Ізяслав", (int)SettlementType.City },
                    { 396, 114, "м. Нетішин", (int)SettlementType.City },
                    { 397, 114, "м. Полонне", (int)SettlementType.City },
                    { 398, 114, "м. Славута", (int)SettlementType.City },
                    { 399, 114, "м. Шепетівка", (int)SettlementType.City },

                    //Черкаська область - 16 міст

                    //Звенигородський район 4
                    { 400, 115, "м. Ватутіне", (int)SettlementType.City },
                    { 401, 115, "м. Звенигородка", (int)SettlementType.City },
                    { 402, 115, "м. Тальне", (int)SettlementType.City },
                    { 403, 115, "м. Шпола", (int)SettlementType.City },
                    //Золотоніський район 1
                    { 404, 116, "м. Золотоноша", (int)SettlementType.City },
                    //Уманський район 4
                    { 405, 117, "м. Жашків", (int)SettlementType.City },
                    { 406, 117, "м. Монастирище", (int)SettlementType.City },
                    { 407, 117, "м. Умань", (int)SettlementType.City },
                    { 408, 117, "м. Христинівка", (int)SettlementType.City },
                    //Черкаський район 7
                    { 409, 118, "м. Городище", (int)SettlementType.City },
                    { 410, 118, "м. Кам'янка", (int)SettlementType.City },
                    { 411, 118, "м. Канів", (int)SettlementType.City },
                    { 412, 118, "м. Корсунь-Шевченківський", (int)SettlementType.City },
                    { 413, 118, "м. Сміла", (int)SettlementType.City },
                    { 414, 118, "м. Черкаси", (int)SettlementType.City },
                    { 415, 118, "м. Чигирин", (int)SettlementType.City },

                    //Чернівецька область - 11 міст

                    //Вижницький район 2
                    { 416, 119, "м. Вашківці", (int)SettlementType.City },
                    { 417, 119, "м. Вижниця", (int)SettlementType.City },
                    //Дністровський район 3
                    { 418, 120, "м. Новодністровськ", (int)SettlementType.City },
                    { 419, 120, "м. Сокиряни", (int)SettlementType.City },
                    { 420, 120, "м. Хотин", (int)SettlementType.City },
                    //Чернівецький район 6
                    { 421, 121, "м. Герца", (int)SettlementType.City },
                    { 422, 121, "м. Заставна", (int)SettlementType.City },
                    { 423, 121, "м. Кіцмань", (int)SettlementType.City },
                    { 424, 121, "м. Новоселиця", (int)SettlementType.City },
                    { 425, 121, "м. Сторожинець", (int)SettlementType.City },
                    { 426, 121, "м. Чернівці", (int)SettlementType.City },

                    //Чернігівська область - 16 міст

                    //Корюківський район 3
                    { 427, 122, "м. Корюківка", (int)SettlementType.City },
                    { 428, 122, "м. Мена", (int)SettlementType.City },
                    { 429, 122, "м. Сновськ", (int)SettlementType.City },
                    //Ніжинський район 6
                    { 430, 123, "м. Батурин", (int)SettlementType.City },
                    { 431, 123, "м. Бахмач", (int)SettlementType.City },
                    { 432, 123, "м. Бобровиця", (int)SettlementType.City },
                    { 433, 123, "м. Борзна", (int)SettlementType.City },
                    { 434, 123, "м. Ніжин", (int)SettlementType.City },
                    { 435, 123, "м. Носівка", (int)SettlementType.City },
                    //Новгород-Сіверський район 2
                    { 436, 124, "м. Новгород-Сіверський", (int)SettlementType.City },
                    { 437, 124, "м. Семенівка", (int)SettlementType.City },
                    //Прилуцький район 2
                    { 438, 125, "м. Ічня", (int)SettlementType.City },
                    { 439, 125, "м. Прилуки", (int)SettlementType.City },
                    //Чернігівський район 3
                    { 440, 126, "м. Городня", (int)SettlementType.City },
                    { 441, 126, "м. Остер", (int)SettlementType.City },
                    { 442, 126, "м. Чернігів", (int)SettlementType.City },

                    //АР Крим - 16 міст

                    //Бахчисарайський район 2
                    { 443, 127, "м. Бахчисарай", (int)SettlementType.City },
                    { 444, 127, "м. Научний", (int)SettlementType.City },
                    //Білогірський район 1
                    { 445, 128, "м. Білогірськ", (int)SettlementType.City },
                    //Джанкойський район 1
                    { 446, 129, "м. Джанкой", (int)SettlementType.City },
                    //Євпаторійський район 2
                    { 447, 130, "м. Євпаторія", (int)SettlementType.City },
                    { 448, 130, "м. Саки", (int)SettlementType.City },
                    //Керченський район 2
                    { 449, 131, "м. Керч", (int)SettlementType.City },
                    { 450, 131, "м. Щолкіне", (int)SettlementType.City },
                    //Курманський район 0
                    //Перекопський район 2
                    { 451, 133, "м. Армянськ", (int)SettlementType.City },
                    { 452, 133, "м. Яни Капу", (int)SettlementType.City },
                    //Сімферопольський район 1
                    { 453, 134, "м. Сімферополь", (int)SettlementType.City },
                    //Феодосійський район 3 
                    { 454, 135, "м. Старий Крим", (int)SettlementType.City },
                    { 455, 135, "м. Судак", (int)SettlementType.City },
                    { 456, 135, "м. Феодосія", (int)SettlementType.City },
                    //Ялтинський район 3 
                    { 457, 136, "м. Алупка", (int)SettlementType.City },
                    { 458, 136, "м. Алушта", (int)SettlementType.City },
                    { 459, 136, "м. Ялта", (int)SettlementType.City },

                    //Міста з особливим статусом
                    { 460, null, "м. Київ", (int)SettlementType.City },
                    { 461, null, "м. Севастополь", (int)SettlementType.City },
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
