
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2015 12:46:24
-- Generated from EDMX file: C:\Users\Sagi\documents\visual studio 2013\Projects\Coupon\Coupon\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [basic];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserName] varchar(500)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhoneKidomet] int  NULL,
    [PhoneNum] int  NULL
);
GO

-- Creating table 'Users_Owner'
CREATE TABLE [dbo].[Users_Owner] (
    [UserName] varchar(500)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserName] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserName] ASC);
GO

-- Creating primary key on [UserName] in table 'Users_Owner'
ALTER TABLE [dbo].[Users_Owner]
ADD CONSTRAINT [PK_Users_Owner]
    PRIMARY KEY CLUSTERED ([UserName] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserName] in table 'Users_Owner'
ALTER TABLE [dbo].[Users_Owner]
ADD CONSTRAINT [FK_Owner_inherits_User]
    FOREIGN KEY ([UserName])
    REFERENCES [dbo].[Users]
        ([UserName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------