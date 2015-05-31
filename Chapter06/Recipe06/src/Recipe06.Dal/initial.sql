IF NOT EXISTS(SELECT * FROM [INFORMATION_SCHEMA].[TABLES] WHERE[TABLE_SCHEMA] = N'dbo' AND[TABLE_NAME] = '__MigrationHistory' AND[TABLE_TYPE] = 'BASE TABLE')
    CREATE TABLE [dbo].[__MigrationHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ContextKey] nvarchar(300) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK_MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
    );
GO

CREATE SEQUENCE [DefaultSequence] AS bigint START WITH 1 INCREMENT BY 10 NO MINVALUE NO MAXVALUE NO CYCLE;
CREATE TABLE [Artist] (
    [ArtistId] int NOT NULL,
    [City] nvarchar(50),
    [Country] nvarchar(50),
    [CreateDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NOT NULL,
    [Provence] nvarchar(50),
    [UserName] nvarchar(50) NOT NULL,
    [WebSite] nvarchar(255),
    CONSTRAINT [PK_Artist] PRIMARY KEY ([ArtistId])
);
CREATE TABLE [ArtistSkill] (
    [ArtistArtistId] int,
    [ArtistSkillId] int NOT NULL,
    [Details] nvarchar(255),
    [SkillLevel] int NOT NULL,
    [Styles] nvarchar(50) NOT NULL,
    [TalentName] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArtistSkill] PRIMARY KEY ([ArtistSkillId]),
    CONSTRAINT [FK_ArtistSkill_Artist_ArtistArtistId] FOREIGN KEY ([ArtistArtistId]) REFERENCES [Artist] ([ArtistId])
);
INSERT INTO [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [ProductVersion])
VALUES ('20150520020057_initial', 'Recipe06.Dal.Context.ArtistContext', '7.0.0-beta4-12943');
;
GO

