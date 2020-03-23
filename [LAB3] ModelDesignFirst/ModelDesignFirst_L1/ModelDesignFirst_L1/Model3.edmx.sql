
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/11/2020 15:10:00
-- Generated from EDMX file: D:\dev\TSP.NET\ModelDesignFirst_L1\ModelDesignFirst_L1\ModelDesignFirst_L1\Model3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestPerson];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AlbumSet'
CREATE TABLE [dbo].[AlbumSet] (
    [AlbumId] int IDENTITY(1,1) NOT NULL,
    [AlbumName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ArtistSet'
CREATE TABLE [dbo].[ArtistSet] (
    [ArtistId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AlbumArtist'
CREATE TABLE [dbo].[AlbumArtist] (
    [Album_AlbumId] int  NOT NULL,
    [Artist_ArtistId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AlbumId] in table 'AlbumSet'
ALTER TABLE [dbo].[AlbumSet]
ADD CONSTRAINT [PK_AlbumSet]
    PRIMARY KEY CLUSTERED ([AlbumId] ASC);
GO

-- Creating primary key on [ArtistId] in table 'ArtistSet'
ALTER TABLE [dbo].[ArtistSet]
ADD CONSTRAINT [PK_ArtistSet]
    PRIMARY KEY CLUSTERED ([ArtistId] ASC);
GO

-- Creating primary key on [Album_AlbumId], [Artist_ArtistId] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [PK_AlbumArtist]
    PRIMARY KEY CLUSTERED ([Album_AlbumId], [Artist_ArtistId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Album_AlbumId] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [FK_AlbumArtist_Album]
    FOREIGN KEY ([Album_AlbumId])
    REFERENCES [dbo].[AlbumSet]
        ([AlbumId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Artist_ArtistId] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [FK_AlbumArtist_Artist]
    FOREIGN KEY ([Artist_ArtistId])
    REFERENCES [dbo].[ArtistSet]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumArtist_Artist'
CREATE INDEX [IX_FK_AlbumArtist_Artist]
ON [dbo].[AlbumArtist]
    ([Artist_ArtistId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------