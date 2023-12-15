BEGIN TRANSACTION;
GO

CREATE TABLE [Streets] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Type] int NOT NULL,
    [SettlementId] int NOT NULL,
    [CityDistrictId] int NULL,
    CONSTRAINT [PK_Streets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Streets_CityDistricts_CityDistrictId] FOREIGN KEY ([CityDistrictId]) REFERENCES [CityDistricts] ([Id]),
    CONSTRAINT [FK_Streets_Settlements_SettlementId] FOREIGN KEY ([SettlementId]) REFERENCES [Settlements] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Streets_CityDistrictId] ON [Streets] ([CityDistrictId]);
GO

CREATE INDEX [IX_Streets_SettlementId] ON [Streets] ([SettlementId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215221312_AddStreetTable', N'8.0.0');
GO

COMMIT;
GO

