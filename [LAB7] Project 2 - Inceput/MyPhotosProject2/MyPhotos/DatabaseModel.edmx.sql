
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 09:46:13
-- Generated from EDMX file: D:\dev\ProiecteTSPNET\MyPhotos\MyPhotos\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PicTablePerson_PicTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PicTablePerson] DROP CONSTRAINT [FK_PicTablePerson_PicTable];
GO
IF OBJECT_ID(N'[dbo].[FK_PicTablePerson_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PicTablePerson] DROP CONSTRAINT [FK_PicTablePerson_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PicTableCategories_PicTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PicTableCategories] DROP CONSTRAINT [FK_PicTableCategories_PicTable];
GO
IF OBJECT_ID(N'[dbo].[FK_PicTableCategories_Categories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PicTableCategories] DROP CONSTRAINT [FK_PicTableCategories_Categories];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PicTableSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PicTableSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[CategoriesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriesSet];
GO
IF OBJECT_ID(N'[dbo].[PicTablePerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PicTablePerson];
GO
IF OBJECT_ID(N'[dbo].[PicTableCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PicTableCategories];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PicTableSet'
CREATE TABLE [dbo].[PicTableSet] (
    [ID_IMG] int IDENTITY(1,1) NOT NULL,
    [Name_img] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Data_create] datetime  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [ID_Person] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CategoriesSet'
CREATE TABLE [dbo].[CategoriesSet] (
    [ID_Category] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PicTablePerson'
CREATE TABLE [dbo].[PicTablePerson] (
    [PicTable_ID_IMG] int  NOT NULL,
    [Person_ID_Person] int  NOT NULL
);
GO

-- Creating table 'PicTableCategories'
CREATE TABLE [dbo].[PicTableCategories] (
    [PicTable_ID_IMG] int  NOT NULL,
    [Categories_ID_Category] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_IMG] in table 'PicTableSet'
ALTER TABLE [dbo].[PicTableSet]
ADD CONSTRAINT [PK_PicTableSet]
    PRIMARY KEY CLUSTERED ([ID_IMG] ASC);
GO

-- Creating primary key on [ID_Person] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([ID_Person] ASC);
GO

-- Creating primary key on [ID_Category] in table 'CategoriesSet'
ALTER TABLE [dbo].[CategoriesSet]
ADD CONSTRAINT [PK_CategoriesSet]
    PRIMARY KEY CLUSTERED ([ID_Category] ASC);
GO

-- Creating primary key on [PicTable_ID_IMG], [Person_ID_Person] in table 'PicTablePerson'
ALTER TABLE [dbo].[PicTablePerson]
ADD CONSTRAINT [PK_PicTablePerson]
    PRIMARY KEY CLUSTERED ([PicTable_ID_IMG], [Person_ID_Person] ASC);
GO

-- Creating primary key on [PicTable_ID_IMG], [Categories_ID_Category] in table 'PicTableCategories'
ALTER TABLE [dbo].[PicTableCategories]
ADD CONSTRAINT [PK_PicTableCategories]
    PRIMARY KEY CLUSTERED ([PicTable_ID_IMG], [Categories_ID_Category] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PicTable_ID_IMG] in table 'PicTablePerson'
ALTER TABLE [dbo].[PicTablePerson]
ADD CONSTRAINT [FK_PicTablePerson_PicTable]
    FOREIGN KEY ([PicTable_ID_IMG])
    REFERENCES [dbo].[PicTableSet]
        ([ID_IMG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Person_ID_Person] in table 'PicTablePerson'
ALTER TABLE [dbo].[PicTablePerson]
ADD CONSTRAINT [FK_PicTablePerson_Person]
    FOREIGN KEY ([Person_ID_Person])
    REFERENCES [dbo].[PersonSet]
        ([ID_Person])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PicTablePerson_Person'
CREATE INDEX [IX_FK_PicTablePerson_Person]
ON [dbo].[PicTablePerson]
    ([Person_ID_Person]);
GO

-- Creating foreign key on [PicTable_ID_IMG] in table 'PicTableCategories'
ALTER TABLE [dbo].[PicTableCategories]
ADD CONSTRAINT [FK_PicTableCategories_PicTable]
    FOREIGN KEY ([PicTable_ID_IMG])
    REFERENCES [dbo].[PicTableSet]
        ([ID_IMG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Categories_ID_Category] in table 'PicTableCategories'
ALTER TABLE [dbo].[PicTableCategories]
ADD CONSTRAINT [FK_PicTableCategories_Categories]
    FOREIGN KEY ([Categories_ID_Category])
    REFERENCES [dbo].[CategoriesSet]
        ([ID_Category])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PicTableCategories_Categories'
CREATE INDEX [IX_FK_PicTableCategories_Categories]
ON [dbo].[PicTableCategories]
    ([Categories_ID_Category]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------