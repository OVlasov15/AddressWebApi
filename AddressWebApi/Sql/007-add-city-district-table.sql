BEGIN TRANSACTION;
GO

CREATE TABLE [CityDistricts] (
    [Id] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [SettlementId] int NOT NULL,
    CONSTRAINT [PK_CityDistricts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CityDistricts_Settlements_SettlementId] FOREIGN KEY ([SettlementId]) REFERENCES [Settlements] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_CityDistricts_SettlementId] ON [CityDistricts] ([SettlementId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215120131_AddCityDistrictTable', N'8.0.0');
GO

COMMIT;
GO

