
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/08/2015 16:15:56
-- Generated from EDMX file: C:\Users\User\Documents\GitHub\Coupon\Coupon\Model.edmx
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
IF OBJECT_ID(N'[dbo].[FK_CustomerOrderedCoupon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedCoupons] DROP CONSTRAINT [FK_CustomerOrderedCoupon];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_LocationVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_CustomerVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_BusinessLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Businesses] DROP CONSTRAINT [FK_BusinessLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerRecommendation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recommendations] DROP CONSTRAINT [FK_CustomerRecommendation];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerCustomer_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerCustomer] DROP CONSTRAINT [FK_CustomerCustomer_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerCustomer_Customer1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerCustomer] DROP CONSTRAINT [FK_CustomerCustomer_Customer1];
GO
IF OBJECT_ID(N'[dbo].[FK_Admin_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Admin] DROP CONSTRAINT [FK_Admin_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Owner_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Owner] DROP CONSTRAINT [FK_Owner_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Customer] DROP CONSTRAINT [FK_Customer_inherits_User];
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
IF OBJECT_ID(N'[dbo].[Visits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visits];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Recommendations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recommendations];
GO
IF OBJECT_ID(N'[dbo].[CustomerIntrests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerIntrests];
GO
IF OBJECT_ID(N'[dbo].[CouponInterests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CouponInterests];
GO
IF OBJECT_ID(N'[dbo].[Users_Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Admin];
GO
IF OBJECT_ID(N'[dbo].[Users_Owner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Owner];
GO
IF OBJECT_ID(N'[dbo].[Users_Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Customer];
GO
IF OBJECT_ID(N'[dbo].[CustomerCustomer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerCustomer];
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
    [Owner_UserName] varchar(500)  NOT NULL,
    [Location_Id] int  NULL
);
GO

-- Creating table 'Coupons'
CREATE TABLE [dbo].[Coupons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [OriginalPrice] nvarchar(max)  NOT NULL,
    [DiscountPrice] nvarchar(max)  NOT NULL,
    [ExperationDate] nvarchar(max)  NOT NULL,
    [AvarageRanking] nvarchar(max)  NULL,
    [MaxNum] int  NOT NULL,
    [RankCount] int  NOT NULL,
    [Business_BusinessID] varchar(500)  NOT NULL
);
GO

-- Creating table 'OrderedCoupons'
CREATE TABLE [dbo].[OrderedCoupons] (
    [SerialNum] int IDENTITY(1,1) NOT NULL,
    [Status] int  NOT NULL,
    [PurchaseDate] nvarchar(max)  NOT NULL,
    [UseDate] nvarchar(max)  NOT NULL,
    [Opinion] nvarchar(max)  NULL,
    [Rank] nvarchar(max)  NULL,
    [Coupon_Id] int  NOT NULL,
    [Customer_UserName] varchar(500)  NOT NULL
);
GO

-- Creating table 'Visits'
CREATE TABLE [dbo].[Visits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Location_Id] int  NOT NULL,
    [CustomerVisit_Visit_UserName] varchar(500)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Latitude] float  NOT NULL,
    [Longitude] float  NOT NULL
);
GO

-- Creating table 'Recommendations'
CREATE TABLE [dbo].[Recommendations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Source] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Link] nvarchar(max)  NOT NULL,
    [Customer_UserName] varchar(500)  NOT NULL
);
GO

-- Creating table 'CustomerIntrests'
CREATE TABLE [dbo].[CustomerIntrests] (
    [CustomerUserName] varchar(500)  NOT NULL,
    [InterestID] int  NOT NULL
);
GO

-- Creating table 'CouponInterests'
CREATE TABLE [dbo].[CouponInterests] (
    [CouponId] int  NOT NULL,
    [InterestID] int  NOT NULL
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

-- Creating table 'Users_Customer'
CREATE TABLE [dbo].[Users_Customer] (
    [UserName] varchar(500)  NOT NULL
);
GO

-- Creating table 'CustomerCustomer'
CREATE TABLE [dbo].[CustomerCustomer] (
    [Customers1_UserName] varchar(500)  NOT NULL,
    [Customers_UserName] varchar(500)  NOT NULL
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

-- Creating primary key on [SerialNum] in table 'OrderedCoupons'
ALTER TABLE [dbo].[OrderedCoupons]
ADD CONSTRAINT [PK_OrderedCoupons]
    PRIMARY KEY CLUSTERED ([SerialNum] ASC);
GO

-- Creating primary key on [Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [PK_Visits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recommendations'
ALTER TABLE [dbo].[Recommendations]
ADD CONSTRAINT [PK_Recommendations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CustomerUserName], [InterestID] in table 'CustomerIntrests'
ALTER TABLE [dbo].[CustomerIntrests]
ADD CONSTRAINT [PK_CustomerIntrests]
    PRIMARY KEY CLUSTERED ([CustomerUserName], [InterestID] ASC);
GO

-- Creating primary key on [InterestID], [CouponId] in table 'CouponInterests'
ALTER TABLE [dbo].[CouponInterests]
ADD CONSTRAINT [PK_CouponInterests]
    PRIMARY KEY CLUSTERED ([InterestID], [CouponId] ASC);
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

-- Creating primary key on [UserName] in table 'Users_Customer'
ALTER TABLE [dbo].[Users_Customer]
ADD CONSTRAINT [PK_Users_Customer]
    PRIMARY KEY CLUSTERED ([UserName] ASC);
GO

-- Creating primary key on [Customers1_UserName], [Customers_UserName] in table 'CustomerCustomer'
ALTER TABLE [dbo].[CustomerCustomer]
ADD CONSTRAINT [PK_CustomerCustomer]
    PRIMARY KEY CLUSTERED ([Customers1_UserName], [Customers_UserName] ASC);
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

-- Creating non-clustered index for FOREIGN KEY 'FK_CouponOrderedCoupon'
CREATE INDEX [IX_FK_CouponOrderedCoupon]
ON [dbo].[OrderedCoupons]
    ([Coupon_Id]);
GO

-- Creating foreign key on [Customer_UserName] in table 'OrderedCoupons'
ALTER TABLE [dbo].[OrderedCoupons]
ADD CONSTRAINT [FK_CustomerOrderedCoupon]
    FOREIGN KEY ([Customer_UserName])
    REFERENCES [dbo].[Users_Customer]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrderedCoupon'
CREATE INDEX [IX_FK_CustomerOrderedCoupon]
ON [dbo].[OrderedCoupons]
    ([Customer_UserName]);
GO

-- Creating foreign key on [Location_Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_LocationVisit]
    FOREIGN KEY ([Location_Id])
    REFERENCES [dbo].[Locations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationVisit'
CREATE INDEX [IX_FK_LocationVisit]
ON [dbo].[Visits]
    ([Location_Id]);
GO

-- Creating foreign key on [CustomerVisit_Visit_UserName] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_CustomerVisit]
    FOREIGN KEY ([CustomerVisit_Visit_UserName])
    REFERENCES [dbo].[Users_Customer]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerVisit'
CREATE INDEX [IX_FK_CustomerVisit]
ON [dbo].[Visits]
    ([CustomerVisit_Visit_UserName]);
GO

-- Creating foreign key on [Location_Id] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [FK_BusinessLocation]
    FOREIGN KEY ([Location_Id])
    REFERENCES [dbo].[Locations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BusinessLocation'
CREATE INDEX [IX_FK_BusinessLocation]
ON [dbo].[Businesses]
    ([Location_Id]);
GO

-- Creating foreign key on [Customer_UserName] in table 'Recommendations'
ALTER TABLE [dbo].[Recommendations]
ADD CONSTRAINT [FK_CustomerRecommendation]
    FOREIGN KEY ([Customer_UserName])
    REFERENCES [dbo].[Users_Customer]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerRecommendation'
CREATE INDEX [IX_FK_CustomerRecommendation]
ON [dbo].[Recommendations]
    ([Customer_UserName]);
GO

-- Creating foreign key on [Customers1_UserName] in table 'CustomerCustomer'
ALTER TABLE [dbo].[CustomerCustomer]
ADD CONSTRAINT [FK_CustomerCustomer_Customer]
    FOREIGN KEY ([Customers1_UserName])
    REFERENCES [dbo].[Users_Customer]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Customers_UserName] in table 'CustomerCustomer'
ALTER TABLE [dbo].[CustomerCustomer]
ADD CONSTRAINT [FK_CustomerCustomer_Customer1]
    FOREIGN KEY ([Customers_UserName])
    REFERENCES [dbo].[Users_Customer]
        ([UserName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerCustomer_Customer1'
CREATE INDEX [IX_FK_CustomerCustomer_Customer1]
ON [dbo].[CustomerCustomer]
    ([Customers_UserName]);
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

-- Creating foreign key on [UserName] in table 'Users_Customer'
ALTER TABLE [dbo].[Users_Customer]
ADD CONSTRAINT [FK_Customer_inherits_User]
    FOREIGN KEY ([UserName])
    REFERENCES [dbo].[Users]
        ([UserName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------