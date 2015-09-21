
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/16/2015 21:43:11
-- Generated from EDMX file: C:\MVC6Recipes\MVC6Recipes\Recipe05\Recipe05.Dal\TalentAgency.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
IF  NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Chapter05Recipe05')

CREATE DATABASE [Chapter05Recipe05]

GO
USE [Chapter05Recipe05];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO


-- Creating table 'Artists'
CREATE TABLE [dbo].[Artists] (
    [ArtistId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [Country] nvarchar(50)  NULL,
    [Provence] nvarchar(50)  NULL,
    [City] nvarchar(50)  NULL,
    [CreateDate] datetime  NOT NULL
);
GO

-- Creating table 'ArtistSkills'
CREATE TABLE [dbo].[ArtistSkills] (
    [ArtistSkillId] int IDENTITY(1,1) NOT NULL,
    [TalentName] nvarchar(50)  NOT NULL,
    [SkillLevel] int  NOT NULL,
    [Details] nvarchar(500)  NULL,
    [Styles] nvarchar(500)  NOT NULL,
    [Artist_ArtistId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ArtistId] in table 'Artists'
ALTER TABLE [dbo].[Artists]
ADD CONSTRAINT [PK_Artists]
    PRIMARY KEY CLUSTERED ([ArtistId] ASC);
GO

-- Creating primary key on [ArtistSkillId] in table 'ArtistSkills'
ALTER TABLE [dbo].[ArtistSkills]
ADD CONSTRAINT [PK_ArtistSkills]
    PRIMARY KEY CLUSTERED ([ArtistSkillId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Artist_ArtistId] in table 'ArtistSkills'
ALTER TABLE [dbo].[ArtistSkills]
ADD CONSTRAINT [FK_ArtistArtistSkill]
    FOREIGN KEY ([Artist_ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistArtistSkill'
CREATE INDEX [IX_FK_ArtistArtistSkill]
ON [dbo].[ArtistSkills]
    ([Artist_ArtistId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------