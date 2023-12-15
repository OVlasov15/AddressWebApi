﻿BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RegionId', N'Name') AND [object_id] = OBJECT_ID(N'[RegionDistricts]'))
    SET IDENTITY_INSERT [RegionDistricts] ON;
INSERT INTO [RegionDistricts] ([Id], [RegionId], [Name])
VALUES (1, 1, N'Вінницький район'),
(2, 1, N'Гайсинський район'),
(3, 1, N'Жмеринський район'),
(4, 1, N'Могилів-Подільський район'),
(5, 1, N'Тульчинський район'),
(6, 1, N'Хмільницький район'),
(7, 2, N'Володимирський район'),
(8, 2, N'Камінь-Каширський район'),
(9, 2, N'Ковельський район'),
(10, 2, N'Луцький район'),
(11, 3, N'Дніпровський район'),
(12, 3, N'Кам''янський район'),
(13, 3, N'Криворізький район'),
(14, 3, N'Нікопольський район'),
(15, 3, N'Новомосковський район'),
(16, 3, N'Павлоградський район'),
(17, 3, N'Синельниківський район'),
(18, 4, N'Бахмутський район'),
(19, 4, N'Волноваський район'),
(20, 4, N'Горлівський район'),
(21, 4, N'Донецький район'),
(22, 4, N'Кальміуський район'),
(23, 4, N'Краматорський район'),
(24, 4, N'Маріупольський район'),
(25, 4, N'Покровський райо'),
(26, 5, N'Бердичівський район'),
(27, 5, N'Житомирський район'),
(28, 5, N'Звягельський район'),
(29, 5, N'Коростенський район'),
(30, 6, N'Берегівський район'),
(31, 6, N'Мукачівський район'),
(32, 6, N'Рахівський район'),
(33, 6, N'Тячівський район'),
(34, 6, N'Ужгородський район'),
(35, 6, N'Хустський район'),
(36, 7, N'Бердянський район'),
(37, 7, N'Василівський район'),
(38, 7, N'Запорізький район'),
(39, 7, N'Мелітопольський район'),
(40, 7, N'Пологівський район'),
(41, 8, N'Верховинський район'),
(42, 8, N'Івано-Франківський район');
INSERT INTO [RegionDistricts] ([Id], [RegionId], [Name])
VALUES (43, 8, N'Калуський район'),
(44, 8, N'Коломийський район'),
(45, 8, N'Косівський район'),
(46, 8, N'Надвірнянський район'),
(47, 9, N'Білоцерківський район'),
(48, 9, N'Бориспільський район'),
(49, 9, N'Броварський район'),
(50, 9, N'Бучанський район'),
(51, 9, N'Вишгородський район'),
(52, 9, N'Обухівський район'),
(53, 9, N'Фастівський район'),
(54, 10, N'Голованівський район'),
(55, 10, N'Кропивницький район'),
(56, 10, N'Новоукраїнський район'),
(57, 10, N'Олександрійський район'),
(58, 11, N'Алчевський район'),
(59, 11, N'Довжанський район'),
(60, 11, N'Луганський район'),
(61, 11, N'Ровеньківський район'),
(62, 11, N'Сватівський район'),
(63, 11, N'Сєвєродонецький район'),
(64, 11, N'Старобільський район'),
(65, 11, N'Щастинський район'),
(66, 12, N'Дрогобицький район'),
(67, 12, N'Золочівський район'),
(68, 12, N'Львівський район'),
(69, 12, N'Самбірський район'),
(70, 12, N'Стрийський район'),
(71, 12, N'Червоноградський'),
(72, 12, N'Яворівський район'),
(73, 13, N'Баштанський район'),
(74, 13, N'Вознесенський район'),
(75, 13, N'Миколаївський район'),
(76, 13, N'Первомайський район'),
(77, 14, N'Березівський район'),
(78, 14, N'Білгород-Дністровський район'),
(79, 14, N'Болградський район'),
(80, 14, N'Ізмаїльський район'),
(81, 14, N'Одеський район'),
(82, 14, N'Подільський район'),
(83, 14, N'Роздільнянський район'),
(84, 15, N'Кременчуцький район');
INSERT INTO [RegionDistricts] ([Id], [RegionId], [Name])
VALUES (85, 15, N'Лубенський район'),
(86, 15, N'Миргородський район'),
(87, 15, N'Полтавський район'),
(88, 16, N'Вараський район'),
(89, 16, N'Дубенський район'),
(90, 16, N'Рівненський район'),
(91, 16, N'Сарненський район'),
(92, 17, N'Конотопський район'),
(93, 17, N'Охтирський район'),
(94, 17, N'Роменський район'),
(95, 17, N'Сумський район'),
(96, 17, N'Шосткинський район'),
(97, 18, N'Кременецький район'),
(98, 18, N'Тернопільський район'),
(99, 18, N'Чортківський район'),
(100, 19, N'Богодухівський район'),
(101, 19, N'Ізюмський район'),
(102, 19, N'Красноградський район'),
(103, 19, N'Куп''янський район'),
(104, 19, N'Лозівський район'),
(105, 19, N'Харківський район'),
(106, 19, N'Чугуївський район'),
(107, 20, N'Бериславський район'),
(108, 20, N'Генічеський район'),
(109, 20, N'Каховський район'),
(110, 20, N'Скадовський район'),
(111, 20, N'Херсонський район'),
(112, 21, N'Кам''янець-Подільський район'),
(113, 21, N'Хмельницький район'),
(114, 21, N'Шепетівський район'),
(115, 22, N'Звенигородський район'),
(116, 22, N'Золотоніський район'),
(117, 22, N'Уманський район'),
(118, 22, N'Черкаський район'),
(119, 23, N'Вижницький район'),
(120, 23, N'Дністровський район'),
(121, 23, N'Чернівецький район'),
(122, 24, N'Корюківський район'),
(123, 24, N'Ніжинський район'),
(124, 24, N'Новгород-Сіверський район'),
(125, 24, N'Прилуцький район'),
(126, 24, N'Чернігівський район');
INSERT INTO [RegionDistricts] ([Id], [RegionId], [Name])
VALUES (127, 25, N'Бахчисарайський район'),
(128, 25, N'Білогірський район'),
(129, 25, N'Джанкойський район'),
(130, 25, N'Євпаторійський район'),
(131, 25, N'Керченський район'),
(132, 25, N'Курманський район'),
(133, 25, N'Перекопський район'),
(134, 25, N'Сімферопольський район'),
(135, 25, N'Феодосійський район'),
(136, 25, N'Ялтинський район');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RegionId', N'Name') AND [object_id] = OBJECT_ID(N'[RegionDistricts]'))
    SET IDENTITY_INSERT [RegionDistricts] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215095243_AddRegionDistrictData', N'8.0.0');
GO

COMMIT;
GO

