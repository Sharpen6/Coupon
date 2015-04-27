
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2015 16:38:12
-- Generated from EDMX file: C:\Users\Sagi\Documents\GitHub\Coupon\Coupon\Model.edmx
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

IF OBJECT_ID(N'[dbo].[FK_AdminBusiness]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Businesses] DROP CONSTRAINT [FK_AdminBusiness];
GO
IF OBJECT_ID(N'[dbo].[FK_BusinessCoupon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Coupons] DROP CONSTRAINT [FK_BusinessCoupon];
GO
IF OBJECT_ID(N'[dbo].[FK_OwnerBusiness]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Businesses] DROP CONSTRAINT [FK_OwnerBusiness];
GO
IF OBJECT_ID(N'[dbo].[FK_CouponOrderedCoupon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedCoupons] DROP CONSTRAINT [FK_CouponOrderedCoupon];
GO
IF OBJECT_ID(N'[dbo].[FK_Admin_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Admin] DROP CONSTRAINT [FK_Admin_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Owner_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Owner] DROP CONSTRAINT [FK_Owner_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Businesses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Businesses];
GO
IF OBJECT_ID(N'[dbo].[Coupons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Coupons];
GO
IF OBJECT_ID(N'[dbo].[OrderedCoupons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderedCoupons];
GO
IF OBJECT_ID(N'[dbo].[Users_Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Admin];
GO
IF OBJECT_ID(N'[dbo].[Users_Owner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Owner];
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

-- Creating table 'Businesses'
CREATE TABLE [dbo].[Businesses] (
    [BusinessID] varchar(500)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Category] int  NOT NULL,
    [Admin_UserName] varchar(500)  NOT NULL,
    [Owner_UserName] varchar(500)  NOT NULL
);
GO

-- Creating table 'Coupons'
CREATE TABLE [dbo].[Coupons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [OriginalPrice] nvarchar(max)  NOT NULL,
    [DiscountPrice] nvarchar(max)  NOT NULL,
    [ExperationDate] nvarchar(max)  NOT NULL,
    [AvarageRanking] nvarchar(max)  NOT NULL,
    [Business_BusinessID] varchar(500)  NOT NULL
);
GO

-- Creating table 'OrderedCoupons'
CREATE TABLE [dbo].[OrderedCoupons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] int  NOT NULL,
    [PurchaseDate] nvarchar(max)  NOT NULL,
    [UseDate] nvarchar(max)  NOT NULL,
    [Opinion] nvarchar(max)  NOT NULL,
    [Rank] nvarchar(max)  NOT NULL,
    [Coupon_Id] int  NOT NULL
);
GO

-- Creating table 'Users_Admin'
CREATE TABLE [dbo].[Users_Admin] (
    [UserName] varchar(500)  NOT NULL
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

-- Creating primary key on [BusinessID] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [PK_Businesses]
    PRIMARY KEY CLUSTERED ([BusinessID] ASC);
GO

-- Creating primary key on [Id] in table 'Coupons'
ALTER TABLE [dbo].[Coupons]
ADD CONSTRAINT [PK_Coupons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderedCoupons'
ALTER TABLE [dbo].[OrderedCoupons]
ADD CONSTRAINT [PK_OrderedCoupons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserName] in table 'Users_Admin'
ALTER TABLE [dbo].[Users_Admin]
ADD CONSTRAINT [PK_Users_Admin]
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

-- Creating foreign key on [Admin_UserName] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [FK_AdminBusiness]
    FOREIGN KEY ([Admin_UserName])
    REFERENCES [dbo].[Users_Admin]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdminBusiness'
CREATE INDEX [IX_FK_AdminBusiness]
ON [dbo].[Businesses]
    ([Admin_UserName]);
GO

-- Creating foreign key on [Business_BusinessID] in table 'Coupons'
ALTER TABLE [dbo].[Coupons]
ADD CONSTRAINT [FK_BusinessCoupon]
    FOREIGN KEY ([Business_BusinessID])
    REFERENCES [dbo].[Businesses]
        ([BusinessID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BusinessCoupon'
CREATE INDEX [IX_FK_BusinessCoupon]
ON [dbo].[Coupons]
    ([Business_BusinessID]);
GO

-- Creating foreign key on [Owner_UserName] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [FK_OwnerBusiness]
    FOREIGN KEY ([Owner_UserName])
    REFERENCES [dbo].[Users_Owner]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OwnerBusiness'
CREATE INDEX [IX_FK_OwnerBusiness]
ON [dbo].[Businesses]
    ([Owner_UserName]);
GO

-- Creating foreign key on [Coupon_Id] in table 'OrderedCoupons'
ALTER TABLE [dbo].[OrderedCoupons]
ADD CONSTRAINT [FK_CouponOrderedCoupon]
    FOREIGN KEY ([Coupon_Id])
    REFERENCES [dbo].[Coupons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CouponOrderedCoupon'
CREATE INDEX [IX_FK_CouponOrderedCoupon]
ON [dbo].[OrderedCoupons]
    ([Coupon_Id]);
GO

-- Creating foreign key on [UserName] in table 'Users_Admin'
ALTER TABLE [dbo].[Users_Admin]
ADD CONSTRAINT [FK_Admin_inherits_User]
    FOREIGN KEY ([UserName])
    REFERENCES [dbo].[Users]
        ([UserName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

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