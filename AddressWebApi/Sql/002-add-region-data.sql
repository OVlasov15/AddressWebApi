BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'AmountRegionDistrict') AND [object_id] = OBJECT_ID(N'[Regions]'))
    SET IDENTITY_INSERT [Regions] ON;
INSERT INTO [Regions] ([Id], [Name], [AmountRegionDistrict])
VALUES (1, N'Вінницька область', 6),
(2, N'Волинська область', 4),
(3, N'Дніпропетровська область', 7),
(4, N'Донецька область', 8),
(5, N'Житомирська область', 4),
(6, N'Закарпатська область', 6),
(7, N'Запорізька область', 5),
(8, N'Івано-Франківська область', 6),
(9, N'Київська область', 7),
(10, N'Кіровоградська область', 4),
(11, N'Луганська область', 8),
(12, N'Львівська область', 7),
(13, N'Миколаївська область', 4),
(14, N'Одеська область', 7),
(15, N'Полтавська область', 4),
(16, N'Рівненська область', 4),
(17, N'Сумська область', 5),
(18, N'Тернопільська область', 3),
(19, N'Харківська область', 7),
(20, N'Херсонська область', 5),
(21, N'Хмельницька область', 3),
(22, N'Черкаська область', 4),
(23, N'Чернівецька область', 3),
(24, N'Чернігівська область', 5),
(25, N'Автономна Республіка Крим', 10);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'AmountRegionDistrict') AND [object_id] = OBJECT_ID(N'[Regions]'))
    SET IDENTITY_INSERT [Regions] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215084642_AddRegionData', N'8.0.0');
GO

COMMIT;
GO

