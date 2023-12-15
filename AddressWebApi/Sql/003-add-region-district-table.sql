BEGIN TRANSACTION;
GO

CREATE TABLE [RegionDistricts] (
    [Id] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [RegionId] int NOT NULL,
    CONSTRAINT [PK_RegionDistricts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RegionDistricts_Regions_RegionId] FOREIGN KEY ([RegionId]) REFERENCES [Regions] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_RegionDistricts_RegionId] ON [RegionDistricts] ([RegionId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215091452_AddRegionDistrictTable', N'8.0.0');
GO

COMMIT;
GO

