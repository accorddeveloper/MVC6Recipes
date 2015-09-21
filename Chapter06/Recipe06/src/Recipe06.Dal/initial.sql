IF OBJECT_ID(N'__MigrationHistory') IS NULL
    CREATE TABLE [__MigrationHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK_HistoryRow] PRIMARY KEY ([MigrationId])
    );

GO

CREATE TABLE [Artist] (
    [ArtistId] int NOT NULL IDENTITY,
    [City] nvarchar(50),
    [Country] nvarchar(50),
    [CreateDate] datetime2 NOT NULL,
    [Provence] nvarchar(50),
    [UserName] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Artist] PRIMARY KEY ([ArtistId])
);
CREATE TABLE [ArtistSkill] (
    [ArtistSkillId] int NOT NULL IDENTITY,
    [ArtistArtistId] int,
    [Details] nvarchar(255),
    [SkillLevel] int NOT NULL,
    [Styles] nvarchar(255) NOT NULL,
    [TalentName] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_ArtistSkill] PRIMARY KEY ([ArtistSkillId]),
    CONSTRAINT [FK_ArtistSkill_Artist_ArtistArtistId] FOREIGN KEY ([ArtistArtistId]) REFERENCES [Artist] ([ArtistId])
);
INSERT INTO [__MigrationHistory] ([MigrationId], [ProductVersion])
VALUES (N'20150920211300_Initial', N'7.0.0-beta7-15540');;
GO

