﻿BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RegionDistrictId', N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[Settlements]'))
    SET IDENTITY_INSERT [Settlements] ON;
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (1, 1, N'м. Вінниця', 1),
(2, 1, N'м. Іллінці', 1),
(3, 1, N'м. Немирів', 1),
(4, 1, N'м. Погребище', 1),
(5, 1, N'м. Липовець', 1),
(6, 1, N'м. Гнівань', 1),
(7, 2, N'м. Гайсин', 1),
(8, 2, N'м. Бершадь', 1),
(9, 2, N'м. Ладижин', 1),
(10, 3, N'м. Бар', 1),
(11, 3, N'м. Жмеринка', 1),
(12, 3, N'м. Шаргород', 1),
(13, 4, N'м. Могилів-Подільський', 1),
(14, 4, N'м. Ямпіль', 1),
(15, 5, N'м. Тульчин', 1),
(16, 6, N'м. Хмільник', 1),
(17, 6, N'м. Козятин', 1),
(18, 6, N'м. Калинівка', 1),
(19, 7, N'м. Володимир', 1),
(20, 7, N'м. Нововолинськ', 1),
(21, 7, N'м. Устилуг', 1),
(22, 8, N'м. Камінь-Каширський', 1),
(23, 9, N'м. Ковель', 1),
(24, 9, N'м. Любомль', 1),
(25, 10, N'м. Берестечко', 1),
(26, 10, N'м. Горохів', 1),
(27, 10, N'м. Ківерці', 1),
(28, 10, N'м. Луцьк', 1),
(29, 10, N'м. Рожище', 1),
(30, 11, N'м. Дніпро', 1),
(31, 11, N'м. Підгородне', 1),
(32, 12, N'м. Верхівцеве', 1),
(33, 12, N'м. Верхньодніпровськ', 1),
(34, 12, N'м. Вільногірськ', 1),
(35, 12, N'м. Жовті Води', 1),
(36, 12, N'м. Кам''янське', 1),
(37, 12, N'м. П''ятихатки', 1),
(38, 13, N'м. Апостолове', 1),
(39, 13, N'м. Зеленодольськ', 1),
(40, 13, N'м. Кривий Ріг', 1),
(41, 14, N'м. Марганець', 1),
(42, 14, N'м. Нікополь', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (43, 14, N'м. Покров', 1),
(44, 15, N'м. Новомосковськ', 1),
(45, 15, N'м. Перещепине', 1),
(46, 16, N'м. Павлоград', 1),
(47, 16, N'м. Тернівка', 1),
(48, 17, N'м. Першотравенськ', 1),
(49, 17, N'м. Синельникове', 1),
(50, 18, N'м. Бахмут', 1),
(51, 18, N'м. Залізне', 1),
(52, 18, N'м. Світлодарськ', 1),
(53, 18, N'м. Сіверськ', 1),
(54, 18, N'м. Соледар', 1),
(55, 18, N'м. Торецьк', 1),
(56, 18, N'м. Часів Яр', 1),
(57, 19, N'м. Волноваха', 1),
(58, 19, N'м. Вугледар', 1),
(59, 20, N'м. Бунге', 1),
(60, 20, N'м. Вуглегірськ', 1),
(61, 20, N'м. Горлівка', 1),
(62, 20, N'м. Дебальцеве', 1),
(63, 20, N'м. Єнакієве', 1),
(64, 20, N'м. Жданівка', 1),
(65, 20, N'м. Сніжне', 1),
(66, 20, N'м. Хрестівка', 1),
(67, 20, N'м. Чистякове', 1),
(68, 20, N'м. Шахтарськ', 1),
(69, 21, N'м. Амвросіївка', 1),
(70, 21, N'м. Донецьк', 1),
(71, 21, N'м. Зугрес', 1),
(72, 21, N'м. Іловайськ', 1),
(73, 21, N'м. Макіївка', 1),
(74, 21, N'м. Моспине', 1),
(75, 21, N'м. Харцизьк', 1),
(76, 21, N'м. Ясинувата', 1),
(77, 22, N'м. Докучаєвськ', 1),
(78, 22, N'м. Кальміуське', 1),
(79, 22, N'м. Новоазовськ', 1),
(80, 23, N'м. Дружківка', 1),
(81, 23, N'м. Костянтинівка', 1),
(82, 23, N'м. Краматорськ', 1),
(83, 23, N'м. Лиман', 1),
(84, 23, N'м. Миколаївка', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (85, 23, N'м. Святогірськ', 1),
(86, 23, N'м. Слов''янськ', 1),
(87, 24, N'м. Маріуполь', 1),
(88, 25, N'м. Авдіївка', 1),
(89, 25, N'м. Білицьке', 1),
(90, 25, N'м. Білозерське', 1),
(91, 25, N'м. Гірник', 1),
(92, 25, N'м. Добропілля', 1),
(93, 25, N'м. Красногорівка', 1),
(94, 25, N'м. Курахове', 1),
(95, 25, N'м. Мар’їнка', 1),
(96, 25, N'м. Мирноград', 1),
(97, 25, N'м. Новогродівка', 1),
(98, 25, N'м. Покровськ', 1),
(99, 25, N'м. Родинське', 1),
(100, 25, N'м. Селидове', 1),
(101, 25, N'м. Українськ', 1),
(102, 26, N'м. Андрушівка', 1),
(103, 26, N'м. Бердичів', 1),
(104, 27, N'м. Житомир', 1),
(105, 27, N'м. Коростишів', 1),
(106, 27, N'м. Радомишль', 1),
(107, 27, N'м. Чуднів', 1),
(108, 28, N'м. Баранівка', 1),
(109, 28, N'м. Звягель', 1),
(110, 29, N'м. Коростень', 1),
(111, 29, N'м. Малин', 1),
(112, 29, N'м. Овруч', 1),
(113, 29, N'м. Олевськ', 1),
(114, 30, N'м. Берегове', 1),
(115, 30, N'м. Виноградів', 1),
(116, 31, N'м. Мукачево', 1),
(117, 31, N'м. Свалява', 1),
(118, 32, N'м. Рахів', 1),
(119, 33, N'м. Тячів', 1),
(120, 34, N'м. Перечин', 1),
(121, 34, N'м. Ужгород', 1),
(122, 34, N'м. Чоп', 1),
(123, 35, N'м. Іршава', 1),
(124, 35, N'м. Хуст', 1),
(125, 36, N'м. Бердянськ', 1),
(126, 36, N'м. Приморськ', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (127, 37, N'м. Василівка', 1),
(128, 37, N'м. Дніпрорудне', 1),
(129, 37, N'м. Енергодар', 1),
(130, 37, N'м. Кам’янка-Дніпровська', 1),
(131, 38, N'м. Вільнянськ', 1),
(132, 38, N'м. Запоріжжя', 1),
(133, 39, N'м. Мелітополь', 1),
(134, 40, N'м. Гуляйполе', 1),
(135, 40, N'м. Молочанськ', 1),
(136, 40, N'м. Оріхів', 1),
(137, 40, N'м. Пологи', 1),
(138, 40, N'м. Токмак', 1),
(139, 42, N'м. Бурштин', 1),
(140, 42, N'м. Галич', 1),
(141, 42, N'м. Івано-Франківськ', 1),
(142, 42, N'м. Рогатин', 1),
(143, 42, N'м. Тисмениця', 1),
(144, 42, N'м. Тлумач', 1),
(145, 43, N'м. Болехів', 1),
(146, 43, N'м. Долина', 1),
(147, 43, N'м. Калуш', 1),
(148, 44, N'м. Городенка', 1),
(149, 44, N'м. Коломия', 1),
(150, 44, N'м. Снятин', 1),
(151, 45, N'м. Косів', 1),
(152, 46, N'м. Надвірна', 1),
(153, 46, N'м. Яремче', 1),
(154, 47, N'м. Біла Церква', 1),
(155, 47, N'м. Сквира', 1),
(156, 47, N'м. Тараща', 1),
(157, 47, N'м. Тетіїв', 1),
(158, 47, N'м. Узин', 1),
(159, 48, N'м. Бориспіль', 1),
(160, 48, N'м. Переяслав', 1),
(161, 48, N'м. Яготин', 1),
(162, 49, N'м. Березань', 1),
(163, 49, N'м. Бровари', 1),
(164, 50, N'м. Буча', 1),
(165, 50, N'м. Вишневе', 1),
(166, 50, N'м. Ірпінь', 1),
(167, 51, N'м. Вишгород', 1),
(168, 51, N'м. Прип''ять', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (169, 51, N'м. Славутич', 1),
(170, 51, N'м. Чорнобиль', 1),
(171, 52, N'м. Богуслав', 1),
(172, 52, N'м. Васильків', 1),
(173, 52, N'м. Кагарлик', 1),
(174, 52, N'м. Миронівка', 1),
(175, 52, N'м. Обухів', 1),
(176, 52, N'м. Ржищів', 1),
(177, 52, N'м. Українка', 1),
(178, 53, N'м. Боярка', 1),
(179, 53, N'м. Фастів', 1),
(180, 54, N'м. Благовіщенське', 1),
(181, 54, N'м. Гайворон', 1),
(182, 55, N'м. Бобринець', 1),
(183, 55, N'м. Долинська', 1),
(184, 55, N'м. Знам''янка', 1),
(185, 55, N'м. Кропивницький', 1),
(186, 56, N'м. Мала Виска', 1),
(187, 56, N'м. Новомиргород', 1),
(188, 56, N'м. Новоукраїнка', 1),
(189, 56, N'м. Помічна', 1),
(190, 57, N'м. Олександрія', 1),
(191, 57, N'м. Світловодськ', 1),
(192, 58, N'м. Алмазна', 1),
(193, 58, N'м. Алчевськ', 1),
(194, 58, N'м. Брянка', 1),
(195, 58, N'м. Голубівка', 1),
(196, 58, N'м. Зимогір''я', 1),
(197, 58, N'м. Зоринськ', 1),
(198, 58, N'м. Ірміно', 1),
(199, 58, N'м. Кадіївка', 1),
(200, 58, N'м. Кипуче', 1),
(201, 58, N'м. Первомайськ', 1),
(202, 58, N'м. Перевальськ', 1),
(203, 59, N'м. Вознесенівка', 1),
(204, 59, N'м. Довжанськ', 1),
(205, 59, N'м. Сорокине', 1),
(206, 59, N'м. Суходільськ', 1),
(207, 60, N'м. Луганськ', 1),
(208, 60, N'м. Лутугине', 1),
(209, 60, N'м. Молодогвардійськ', 1),
(210, 60, N'м. Олександрівськ', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (211, 61, N'м. Антрацит', 1),
(212, 61, N'м. Боково-Хрустальне', 1),
(213, 61, N'м. Міусинськ', 1),
(214, 61, N'м. Петрово-Красносілля', 1),
(215, 61, N'м. Ровеньки', 1),
(216, 61, N'м. Хрустальний', 1),
(217, 62, N'м. Сватове', 1),
(218, 63, N'м. Гірське', 1),
(219, 63, N'м. Золоте', 1),
(220, 63, N'м. Кремінна', 1),
(221, 63, N'м. Лисичанськ', 1),
(222, 63, N'м. Новодружеськ', 1),
(223, 63, N'м. Попасна', 1),
(224, 63, N'м. Привілля', 1),
(225, 63, N'м. Рубіжне', 1),
(226, 63, N'м. Сєвєродонецьк', 1),
(227, 64, N'м. Старобільськ', 1),
(228, 65, N'м. Щастя', 1),
(229, 66, N'м. Борислав', 1),
(230, 66, N'м. Дрогобич', 1),
(231, 66, N'м. Стебник', 1),
(232, 66, N'м. Трускавець', 1),
(233, 67, N'м. Броди', 1),
(234, 67, N'м. Буськ', 1),
(235, 67, N'м. Золочів', 1),
(236, 68, N'м. Бібрка', 1),
(237, 68, N'м. Винники', 1),
(238, 68, N'м. Глиняни', 1),
(239, 68, N'м. Городок', 1),
(240, 68, N'м. Дубляни', 1),
(241, 68, N'м. Жовква', 1),
(242, 68, N'м. Кам''янка-Бузька', 1),
(243, 68, N'м. Комарно', 1),
(244, 68, N'м. Львів', 1),
(245, 68, N'м. Перемишляни', 1),
(246, 68, N'м. Пустомити', 1),
(247, 68, N'м. Рава-Руська', 1),
(248, 69, N'м. Добромиль', 1),
(249, 69, N'м. Новий Калинів', 1),
(250, 69, N'м. Рудки', 1),
(251, 69, N'м. Самбір', 1),
(252, 69, N'м. Старий Самбір', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (253, 69, N'м. Турка', 1),
(254, 69, N'м. Хирів', 1),
(255, 70, N'м. Жидачів', 1),
(256, 70, N'м. Миколаїв', 1),
(257, 70, N'м. Моршин', 1),
(258, 70, N'м. Новий Розділ', 1),
(259, 70, N'м. Сколе', 1),
(260, 70, N'м. Стрий', 1),
(261, 70, N'м. Ходорів', 1),
(262, 71, N'м. Белз', 1),
(263, 71, N'м. Великі Мости', 1),
(264, 71, N'м. Радехів', 1),
(265, 71, N'м. Сокаль', 1),
(266, 71, N'м. Соснівка', 1),
(267, 71, N'м. Угнів', 1),
(268, 71, N'м. Червоноград', 1),
(269, 72, N'м. Мостиська', 1),
(270, 72, N'м. Новояворівськ', 1),
(271, 72, N'м. Судова Вишня', 1),
(272, 72, N'м. Яворів', 1),
(273, 73, N'м. Баштанка', 1),
(274, 73, N'м. Новий Буг', 1),
(275, 73, N'м. Снігурівка', 1),
(276, 74, N'м. Вознесенськ', 1),
(277, 74, N'м. Южноукраїнськ', 1),
(278, 75, N'м. Миколаїв', 1),
(279, 75, N'м. Нова Одеса', 1),
(280, 75, N'м. Очаків', 1),
(281, 76, N'м. Первомайськ', 1),
(282, 77, N'м. Березівка', 1),
(283, 78, N'м. Білгород-Дністровський', 1),
(284, 78, N'м. Татарбунари', 1),
(285, 79, N'м. Арциз', 1),
(286, 79, N'м. Болград', 1),
(287, 80, N'м. Вилкове', 1),
(288, 80, N'м. Ізмаїл', 1),
(289, 80, N'м. Кілія', 1),
(290, 80, N'м. Рені', 1),
(291, 81, N'м. Біляївка', 1),
(292, 81, N'м. Одеса', 1),
(293, 81, N'м. Теплодар', 1),
(294, 81, N'м. Чорноморськ', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (295, 81, N'м. Южне', 1),
(296, 82, N'м. Ананьїв', 1),
(297, 82, N'м. Балта', 1),
(298, 82, N'м. Кодима', 1),
(299, 82, N'м. Подільськ', 1),
(300, 83, N'м. Роздільна', 1),
(301, 84, N'м. Глобине', 1),
(302, 84, N'м. Горішні Плавні', 1),
(303, 84, N'м. Кременчук', 1),
(304, 85, N'м. Гребінка', 1),
(305, 85, N'м. Лубни', 1),
(306, 85, N'м. Пирятин', 1),
(307, 85, N'м. Хорол', 1),
(308, 86, N'м. Гадяч', 1),
(309, 86, N'м. Заводське', 1),
(310, 86, N'м. Лохвиця', 1),
(311, 86, N'м. Миргород', 1),
(312, 87, N'м. Зіньків', 1),
(313, 87, N'м. Карлівка', 1),
(314, 87, N'м. Кобеляки', 1),
(315, 87, N'м. Полтава', 1),
(316, 87, N'м. Решетилівка', 1),
(317, 88, N'м. Вараш', 1),
(318, 89, N'м. Дубно', 1),
(319, 89, N'м. Радивилів', 1),
(320, 90, N'м. Березне', 1),
(321, 90, N'м. Здолбунів', 1),
(322, 90, N'м. Корець', 1),
(323, 90, N'м. Костопіль', 1),
(324, 90, N'м. Острог', 1),
(325, 90, N'м. Рівне', 1),
(326, 91, N'м. Дубровиця', 1),
(327, 91, N'м. Сарни', 1),
(328, 92, N'м. Буринь', 1),
(329, 92, N'м. Конотоп', 1),
(330, 92, N'м. Кролевець', 1),
(331, 92, N'м. Путивль', 1),
(332, 93, N'м. Охтирка', 1),
(333, 93, N'м. Тростянець', 1),
(334, 94, N'м. Ромни', 1),
(335, 95, N'м. Білопілля', 1),
(336, 95, N'м. Ворожба', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (337, 95, N'м. Лебедин', 1),
(338, 95, N'м. Суми', 1),
(339, 96, N'м. Глухів', 1),
(340, 96, N'м. Дружба', 1),
(341, 96, N'м. Середина-Буда', 1),
(342, 96, N'м. Шостка', 1),
(343, 97, N'м. Кременець', 1),
(344, 97, N'м. Ланівці', 1),
(345, 97, N'м. Почаїв', 1),
(346, 97, N'м. Шумськ', 1),
(347, 98, N'м. Бережани', 1),
(348, 98, N'м. Збараж', 1),
(349, 98, N'м. Зборів', 1),
(350, 98, N'м. Підгайці', 1),
(351, 98, N'м. Скалат', 1),
(352, 98, N'м. Теребовля', 1),
(353, 98, N'м. Тернопіль', 1),
(354, 99, N'м. Борщів', 1),
(355, 99, N'м. Бучач', 1),
(356, 99, N'м. Заліщики', 1),
(357, 99, N'м. Копичинці', 1),
(358, 99, N'м. Монастириська', 1),
(359, 99, N'м. Хоростків', 1),
(360, 99, N'м. Чортків', 1),
(361, 100, N'м. Богодухів', 1),
(362, 100, N'м. Валки', 1),
(363, 101, N'м. Балаклія', 1),
(364, 101, N'м. Барвінкове', 1),
(365, 101, N'м. Ізюм', 1),
(366, 102, N'м. Красноград', 1),
(367, 103, N'м. Куп''янськ', 1),
(368, 104, N'м. Лозова', 1),
(369, 104, N'м. Первомайський', 1),
(370, 105, N'м. Дергачі', 1),
(371, 105, N'м. Люботин', 1),
(372, 105, N'м. Мерефа', 1),
(373, 105, N'м. Південне', 1),
(374, 105, N'м. Харків', 1),
(375, 106, N'м. Вовчанськ', 1),
(376, 106, N'м. Зміїв', 1),
(377, 106, N'м. Чугуїв', 1),
(378, 107, N'м. Берислав', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (379, 108, N'м. Генічеськ', 1),
(380, 109, N'м. Каховка', 1),
(381, 109, N'м. Нова Каховка', 1),
(382, 109, N'м. Таврійськ', 1),
(383, 110, N'м. Гола Пристань', 1),
(384, 110, N'м. Скадовськ', 1),
(385, 111, N'м. Олешки', 1),
(386, 111, N'м. Херсон', 1),
(387, 112, N'м. Дунаївці', 1),
(388, 112, N'м. Кам''янець-Подільський', 1),
(389, 113, N'м. Волочиськ', 1),
(390, 113, N'м. Городок', 1),
(391, 113, N'м. Деражня', 1),
(392, 113, N'м. Красилів', 1),
(393, 113, N'м. Старокостянтинів', 1),
(394, 113, N'м. Хмельницький', 1),
(395, 114, N'м. Ізяслав', 1),
(396, 114, N'м. Нетішин', 1),
(397, 114, N'м. Полонне', 1),
(398, 114, N'м. Славута', 1),
(399, 114, N'м. Шепетівка', 1),
(400, 115, N'м. Ватутіне', 1),
(401, 115, N'м. Звенигородка', 1),
(402, 115, N'м. Тальне', 1),
(403, 115, N'м. Шпола', 1),
(404, 116, N'м. Золотоноша', 1),
(405, 117, N'м. Жашків', 1),
(406, 117, N'м. Монастирище', 1),
(407, 117, N'м. Умань', 1),
(408, 117, N'м. Христинівка', 1),
(409, 118, N'м. Городище', 1),
(410, 118, N'м. Кам''янка', 1),
(411, 118, N'м. Канів', 1),
(412, 118, N'м. Корсунь-Шевченківський', 1),
(413, 118, N'м. Сміла', 1),
(414, 118, N'м. Черкаси', 1),
(415, 118, N'м. Чигирин', 1),
(416, 119, N'м. Вашківці', 1),
(417, 119, N'м. Вижниця', 1),
(418, 120, N'м. Новодністровськ', 1),
(419, 120, N'м. Сокиряни', 1),
(420, 120, N'м. Хотин', 1);
INSERT INTO [Settlements] ([Id], [RegionDistrictId], [Name], [Type])
VALUES (421, 121, N'м. Герца', 1),
(422, 121, N'м. Заставна', 1),
(423, 121, N'м. Кіцмань', 1),
(424, 121, N'м. Новоселиця', 1),
(425, 121, N'м. Сторожинець', 1),
(426, 121, N'м. Чернівці', 1),
(427, 122, N'м. Корюківка', 1),
(428, 122, N'м. Мена', 1),
(429, 122, N'м. Сновськ', 1),
(430, 123, N'м. Батурин', 1),
(431, 123, N'м. Бахмач', 1),
(432, 123, N'м. Бобровиця', 1),
(433, 123, N'м. Борзна', 1),
(434, 123, N'м. Ніжин', 1),
(435, 123, N'м. Носівка', 1),
(436, 124, N'м. Новгород-Сіверський', 1),
(437, 124, N'м. Семенівка', 1),
(438, 125, N'м. Ічня', 1),
(439, 125, N'м. Прилуки', 1),
(440, 126, N'м. Городня', 1),
(441, 126, N'м. Остер', 1),
(442, 126, N'м. Чернігів', 1),
(443, 127, N'м. Бахчисарай', 1),
(444, 127, N'м. Научний', 1),
(445, 128, N'м. Білогірськ', 1),
(446, 129, N'м. Джанкой', 1),
(447, 130, N'м. Євпаторія', 1),
(448, 130, N'м. Саки', 1),
(449, 131, N'м. Керч', 1),
(450, 131, N'м. Щолкіне', 1),
(451, 133, N'м. Армянськ', 1),
(452, 133, N'м. Яни Капу', 1),
(453, 134, N'м. Сімферополь', 1),
(454, 135, N'м. Старий Крим', 1),
(455, 135, N'м. Судак', 1),
(456, 135, N'м. Феодосія', 1),
(457, 136, N'м. Алупка', 1),
(458, 136, N'м. Алушта', 1),
(459, 136, N'м. Ялта', 1),
(460, NULL, N'м. Київ', 1),
(461, NULL, N'м. Севастополь', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RegionDistrictId', N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[Settlements]'))
    SET IDENTITY_INSERT [Settlements] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215110359_AddSettlementCityData', N'8.0.0');
GO

COMMIT;
GO
