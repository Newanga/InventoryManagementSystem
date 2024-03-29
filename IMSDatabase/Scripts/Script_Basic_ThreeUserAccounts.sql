USE [master]
GO
/****** Object:  Database [IMSDatabase]    Script Date: 8/1/2020 12:29:16 PM ******/
CREATE DATABASE [IMSDatabase]
CONTAINMENT = NONE
ALTER DATABASE [IMSDatabase] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IMSDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IMSDatabase] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [IMSDatabase] SET ANSI_NULLS ON 
GO
ALTER DATABASE [IMSDatabase] SET ANSI_PADDING ON 
GO
ALTER DATABASE [IMSDatabase] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [IMSDatabase] SET ARITHABORT ON 
GO
ALTER DATABASE [IMSDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IMSDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IMSDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IMSDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IMSDatabase] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [IMSDatabase] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [IMSDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IMSDatabase] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [IMSDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IMSDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IMSDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IMSDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IMSDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IMSDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IMSDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IMSDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IMSDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IMSDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IMSDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [IMSDatabase] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [IMSDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IMSDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IMSDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [IMSDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IMSDatabase] SET QUERY_STORE = OFF
GO
USE [IMSDatabase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [IMSDatabase]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/1/2020 12:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailAddress] [nvarchar](300) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[AccountStateId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountState]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountState](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](2000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[LeaveDate] [datetime] NULL,
	[AccountId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderItemId] [int] NOT NULL,
	[DateAdded] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceDate] [date] NOT NULL,
	[DeliveryDate] [date] NULL,
	[SpecialNotes] [nvarchar](2000) NULL,
	[OrderStateId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderState]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderState](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](2000) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Warrenty] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductStateId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductState]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductState](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](2000) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[SupplierStateId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierState]    Script Date: 8/1/2020 12:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierState](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Id], [EmailAddress], [Username], [Password], [AccountStateId], [RoleId]) VALUES (1, N'Admin@gmail.com', N'Admin1234', N'Pass1234', 2, 1)
INSERT [dbo].[Account] ([Id], [EmailAddress], [Username], [Password], [AccountStateId], [RoleId]) VALUES (2, N'StockManager@gmail.com', N'SManager1234', N'Pass1234', 2, 2)
INSERT [dbo].[Account] ([Id], [EmailAddress], [Username], [Password], [AccountStateId], [RoleId]) VALUES (3, N'StockKeeper@gmail.com', N'SKeeper1234', N'Pass1234', 2, 3)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[AccountState] ON 

INSERT [dbo].[AccountState] ([Id], [State]) VALUES (1, N'Online    ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (2, N'Offline   ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (3, N'Disable   ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (4, N'Enable    ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (5, N'Block     ')
SET IDENTITY_INSERT [dbo].[AccountState] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Address], [StartDate], [LeaveDate], [AccountId]) VALUES (1, N'Jeffrey ', N'Stanley', CAST(N'1980-12-12T00:00:00.000' AS DateTime), N'4840 Mount Tabor
White Plains, NY 10601', CAST(N'2020-05-05T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Address], [StartDate], [LeaveDate], [AccountId]) VALUES (2, N'Larry', N'Chappell', CAST(N'1995-11-12T00:00:00.000' AS DateTime), N'1728 Corpening Drive
Southfield, MI 48075', CAST(N'2020-05-10T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Address], [StartDate], [LeaveDate], [AccountId]) VALUES (3, N'Edward', N'Johnson', CAST(N'2000-07-02T00:00:00.000' AS DateTime), N'2403 Sunny Glen Lane
Warrensville Heights, OH 44128', CAST(N'2020-05-11T00:00:00.000' AS DateTime), NULL, 3)
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[OrderState] ON 

INSERT [dbo].[OrderState] ([Id], [State]) VALUES (1, N'Draft')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (2, N'Confirmed')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (3, N'Paid')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (4, N'Shipped')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (5, N'Delivered')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (6, N'Returned')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (7, N'Canceled')
SET IDENTITY_INSERT [dbo].[OrderState] OFF
SET IDENTITY_INSERT [dbo].[ProductState] ON 

INSERT [dbo].[ProductState] ([Id], [State]) VALUES (1, N'Available')
INSERT [dbo].[ProductState] ([Id], [State]) VALUES (2, N'OutOfStock')
INSERT [dbo].[ProductState] ([Id], [State]) VALUES (3, N'Discontinued')
SET IDENTITY_INSERT [dbo].[ProductState] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'StockManager')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'StockKeeper')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[SupplierState] ON 

INSERT [dbo].[SupplierState] ([Id], [State]) VALUES (1, N'Active    ')
INSERT [dbo].[SupplierState] ([Id], [State]) VALUES (2, N'Deactive  ')
SET IDENTITY_INSERT [dbo].[SupplierState] OFF
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (NULL) FOR [DeliveryDate]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (NULL) FOR [SpecialNotes]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_AccountState] FOREIGN KEY([AccountStateId])
REFERENCES [dbo].[AccountState] ([Id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_AccountState]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Account]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Order]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Order_OrderState] FOREIGN KEY([OrderStateId])
REFERENCES [dbo].[OrderState] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Order_OrderState]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Supplier]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductStateId] FOREIGN KEY([ProductStateId])
REFERENCES [dbo].[ProductState] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductStateId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_SupplierState] FOREIGN KEY([SupplierStateId])
REFERENCES [dbo].[SupplierState] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_SupplierState]
GO
USE [master]
GO
ALTER DATABASE [IMSDatabase] SET  READ_WRITE 
GO
