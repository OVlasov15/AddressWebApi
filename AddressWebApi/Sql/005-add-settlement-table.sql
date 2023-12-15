BEGIN TRANSACTION;
GO

CREATE TABLE [Settlements] (
    [Id] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Type] int NOT NULL,
    [RegionDistrictId] int NULL,
    CONSTRAINT [PK_Settlements] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Settlements_RegionDistricts_RegionDistrictId] FOREIGN KEY ([RegionDistrictId]) REFERENCES [RegionDistricts] ([Id])
);
GO

CREATE INDEX [IX_Settlements_RegionDistrictId] ON [Settlements] ([RegionDistrictId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215100846_AddSettlementTable', N'8.0.0');
GO

COMMIT;
GO

