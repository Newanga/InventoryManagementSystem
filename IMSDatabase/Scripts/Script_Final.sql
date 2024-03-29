USE [master]
GO
/****** Object:  Database [IMSDatabase]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Account]    Script Date: 8/5/2020 12:37:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailAddress] [nvarchar](300) COLLATE Latin1_General_100_CS_AI_SC NOT NULL,
	[Username] [nvarchar](50)  COLLATE Latin1_General_100_CS_AI_SC NOT NULL ,
	[Password] [nvarchar](50) COLLATE Latin1_General_100_CS_AI_SC NOT NULL ,
	[AccountStateId] [int]  NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountState]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Inventory]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[OrderItem]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[OrderState]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[ProductState]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Roles]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[Supplier]    Script Date: 8/5/2020 12:37:14 PM ******/
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
/****** Object:  Table [dbo].[SupplierState]    Script Date: 8/5/2020 12:37:14 PM ******/
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
GO
SET IDENTITY_INSERT [dbo].[AccountState] ON 

INSERT [dbo].[AccountState] ([Id], [State]) VALUES (1, N'Online    ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (2, N'Offline   ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (3, N'Disable   ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (4, N'Enable    ')
INSERT [dbo].[AccountState] ([Id], [State]) VALUES (5, N'Block     ')
SET IDENTITY_INSERT [dbo].[AccountState] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (1, N'Video Game Consoles', N'A video game console is an electronic or computer device that outputs a video signal or visual image to display a video game that one or more people can play through some type of game controller.')
INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (2, N'Laptops', N'Laptops combine all the input/output components and capabilities of a desktop computer, including the display screen, speakers, a keyboard, data storage device, sometimes an optical disc drive, pointing devices (such as a touchpad or trackpad), with an operating system, a processor and memory into a single unit.')
INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (3, N'Cell Phones & Accessories', N'A mobile phone, cellular phone, cell phone, cellphone or hand phone, sometimes shortened to simply mobile, cell or just phone, is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area.')
INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (4, N'Televisions', N'Television (TV), sometimes shortened to tele, is a telecommunication medium used for transmitting moving images in color, and in two or three dimensions and sound. The term can refer to a television set, a television show, or the medium of television transmission. Television is a mass medium for advertising, entertainment, news, and sports. ')
INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (5, N'Washing Machines', N'A washing machine (laundry machine, clothes washer, or washer) is a home appliance used to wash laundry. The term is mostly applied to machines that use water as opposed to dry cleaning.')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Address], [StartDate], [LeaveDate], [AccountId]) VALUES (1, N'Jeffrey ', N'Stanley', CAST(N'1980-12-12T00:00:00.000' AS DateTime), N'4840 Mount Tabor
White Plains, NY 10601', CAST(N'2020-05-05T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Address], [StartDate], [LeaveDate], [AccountId]) VALUES (2, N'Larry', N'Chappell', CAST(N'1995-11-12T00:00:00.000' AS DateTime), N'1728 Corpening Drive
Southfield, MI 48075', CAST(N'2020-05-10T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Address], [StartDate], [LeaveDate], [AccountId]) VALUES (3, N'Edward', N'Johnson', CAST(N'2000-07-02T00:00:00.000' AS DateTime), N'2403 Sunny Glen Lane
Warrensville Heights, OH 44128', CAST(N'2020-05-11T00:00:00.000' AS DateTime), NULL, 3)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO

SET IDENTITY_INSERT [dbo].[OrderState] ON 

INSERT [dbo].[OrderState] ([Id], [State]) VALUES (1, N'Draft')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (2, N'Confirmed')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (3, N'Paid')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (4, N'Shipped')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (5, N'Delivered')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (6, N'Returned')
INSERT [dbo].[OrderState] ([Id], [State]) VALUES (7, N'Canceled')
SET IDENTITY_INSERT [dbo].[OrderState] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (1, N'PlayStation 2', N'Launched in 2000, PS2 marked an evolution in home console gaming, set a new standard for players and developers alike and introduced some of the features that still define the PlayStation experience today.', CAST(30000.00 AS Decimal(18, 2)), 12, 2, 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (2, N'PlayStation 3', N'Breathtaking games, incredible High Definition Blu-ray Disc movies, your favourite catch-up TV shows and chart-topping music – we’re just scratching the surface of what PS3 has to offer.', CAST(40000.00 AS Decimal(18, 2)), 12, 2, 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (3, N'PlayStation 4 Slim', N'The PlayStation 4 (PS4) is an eighth-generation home video game console developed by Sony Computer Entertainment. Announced as the successor to the PlayStation 3 in February 2013, it was launched on November 15 in North America, November 29 in Europe, South America and Australia, and on February 22, 2014 in Japan. It competes with Microsoft''s Xbox One and Nintendo''s Wii U and Switch. ', CAST(55000.00 AS Decimal(18, 2)), 12, 2, 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (4, N'PSP', N'The PlayStation, one of a new generation of 32-bit consoles, signaled Sony''s rise to power in the video game world. Also known as the PS One, the PlayStation used compact discs (CDs), heralding the video game industry''s move away from cartridges.', CAST(20000.00 AS Decimal(18, 2)), 12, 2, 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (5, N'PlayStation 5', N'The PlayStation 5  is an upcoming home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, it is scheduled to launch in late 2020. The platform is anticipated to launch in two varieties, as a base PlayStation 5 system incorporating an Ultra HD Blu-ray compatible optical disc drive for retail game support alongside digital distribution via the PlayStation Store, and a lower-cost Digital variant lacking the disc drive while retaining digital download support. ', CAST(80000.00 AS Decimal(18, 2)), 12, 2, 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (6, N'Zephyrus', N'Zephyrus is the world’s most powerful 14-inch Windows 10 Pro gaming laptop. Outclass the competition with up to an 8-core AMD Ryzen™ 9 4900HS CPU and potent GeForce RTX™ 2060 GPU that speed through everyday multitasking and gaming. Customize your fit with either a 120Hz gaming display or high-resolution WQHD panel, both Pantone® Validated for superb color accuracy. Quad speakers pump out incredible Dolby Atmos sound for immersive movies, games, music, and more. Live life at Zephyrus speed with a light and portable gaming laptop, and be active anywhere', CAST(250000.00 AS Decimal(18, 2)), 36, 1, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (7, N'Mothership', N'Samsung Mothership is a portable Windows 10 Pro powerhouse with an innovative standing design that enhances cooling for its factory overclocked GeForce RTX™ 2080 GPU and 9th Gen Intel® Core™ i9 eight-core CPU. Choose between G-SYNC™ displays with a detailed 4K resolution or blazing 144Hz refresh rate, and use the detachable keyboard to adapt to how you play. SSD RAID storage and 2.5G Ethernet bring ultra-fast performance to every part of this revolutionary gaming machine.', CAST(85000.00 AS Decimal(18, 2)), 36, 1, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (8, N'VAIO', N'The VAIO SX14 is the newest laptop from VAIO. This laptop has a BIGGER 14-inch display, available in 4K Ultra HD. This laptop is LIGHTER by utilizing a new UD carbon, eliminating 30% of weight from the top cover. This laptop is FASTER with the latest Intel 8th generation quad-core processor enhanced by VAIO TruePerformance. Plus the convenience of every port you could ever need, including USB Type-C, while only weighing in at 2.32 lbs and approximately 0.59-inch thin.', CAST(260000.00 AS Decimal(18, 2)), 36, 2, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (9, N'Mate 3', N'HUAWEI MateBook 13 delivers more than an impressive screen, it brings to life a fully immersive visual experience. The 88% screen-to-body ratio and 100% sRGB (typical) colour gamut, let you see more in a vivid way. And the 3:2 aspect ratio is perfect for reading and writing.', CAST(200000.00 AS Decimal(18, 2)), 36, 5, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (10, N'RoG', N'The ROG Strix G embodies streamlined design, offering a formidable core experience for serious gaming and multitasking on Windows 10 Pro. Featuring the latest 9th Gen Intel Core processors and GeForce RTX™ graphics, it brings impactful gaming performance to a wide audience. Intelligent Cooling unleashes the full potential of its leading-edge processors, while RangeBoost provides the strongest possible Wi-Fi signal for your environment. Wherever you play, illuminate the surroundings with Aura Sync on the new triple-edged light bar and 4-zone RGB keyboard.', CAST(180000.00 AS Decimal(18, 2)), 36, 1, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (11, N'J6 Plus', N'The Galaxy J6+ is powered by Qualcomm MSM8917 Snapdragon 425 (28 nm) including a Quad-core 1.4 GHz Cortex-A53 CPU, an Adreno 308 GPU with 3 or 4 GB RAM and either 32 or 64 GB of internal storage which can be upgraded up to 256 GB via microSD card.
', CAST(30000.00 AS Decimal(18, 2)), 12, 1, 3, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (12, N'Galaxy Trend', N'Samsung Galaxy Trend Lite or Samsung Galaxy Fresh is a low-end Android smartphone released by Samsung Electronics in October 2013. It has a 4-inch TFT', CAST(20000.00 AS Decimal(18, 2)), 12, 1, 3, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (13, N'J1', N'The Samsung Galaxy J1 is available in a 3G and a 4G version. Both models have an ARM Cortex-A7 CPU with either two (3G) or four cores (4G) with 512 MB (3G) or 768 MB (4G) of RAM and 4 GB of internal storage.[8] The phone also has a slot for a microSD card up to 256 gigabytes and dual SIM card support.[11] The rear camera''s resolution is 5 megapixels while the front camera is 2 megapixels and both travel at 30 fps.', CAST(13000.00 AS Decimal(18, 2)), 12, 1, 3, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (14, N'Xperia Z1', N'The Sony Xperia Z1 is an Android smartphone produced by Sony. The Z1, at that point known by the project code name "Honami", was unveiled during a press', CAST(80000.00 AS Decimal(18, 2)), 12, 2, 3, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (15, N'Y7 Pro', N' 48 MP Triple AI Camera. Visit Nearby Store or HUAWEI Website to Buy. Latest Technological Advances for HUAWEI Consumers. Experience Yourself. Get Yours Today. 8MP Front Camera. 6.39" Punch Display. HUAWEI Share 3.0.', CAST(35000.00 AS Decimal(18, 2)), 12, 5, 3, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (16, N'Bravia', N'Unlike any TV-viewing experience before, BRAVIA provides sound and vision in perfect harmony. As well as immersing yourself in stunning picture quality, you can now also enjoy powerful and clear sound coming from exactly where it should—all in complete ease with voice control and beautiful design.
', CAST(56000.00 AS Decimal(18, 2)), 48, 5, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (17, N'The Terrace QLED 4K UHD', N'65" Class The Terrace QLED 4K UHD HDR Smart TV - Samsung
 The Terrace
Discover the latest features and innovations available in the 65" Class The Terrace QLED 4K UHD HDR Smart TV. Find the perfect TV for you!', CAST(120000.00 AS Decimal(18, 2)), 48, 1, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (18, N'LG', N'Designed to look as beautiful off as they do on, LG Smart TVs feature sophisticated designs, with both curved and flat screens available, and come in an incredible range of sizes – from 32 inches to 86 inches .', CAST(60000.00 AS Decimal(18, 2)), 48, 3, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (19, N'Smart Singer 1', N'A smarter way to watch. As the centerpiece in your home, Singer Smart TVs are dedicated to giving you access to a world of content beyond streaming so you can schedule recordings, search and game all while connecting to more devices across your home.', CAST(40000.00 AS Decimal(18, 2)), 48, 4, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (20, N'Bravia 2', N'Bravia is a brand of Sony Visual Products Inc.,a wholly owned subsidiary of Sony Corporation, and used for its television products. Its backronym is "Best Resolution Audio Visual Integrated Architecture"', CAST(58000.00 AS Decimal(18, 2)), 48, 2, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (21, N'Master', N'Z9G | MASTER Series | LED | 8K | High Dynamic Range (HDR) | Smart TV (Android TV)', CAST(40000.00 AS Decimal(18, 2)), 12, 2, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (22, N'Singer Wash', N'Singer Washing Machine & Dryer Front Load 12Kg
PRODUCT CODE: SWD-MFC120', CAST(50000.00 AS Decimal(18, 2)), 12, 4, 5, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (23, N'Samsung Eco', N'Samsung 8kg Front Loader Washer Dryer Eco Bubble
PRODUCT CODE: SMGWD80K6410', CAST(80000.00 AS Decimal(18, 2)), 12, 1, 5, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (24, N'LG Indesit', N'Indesit Washing Machine & Dryer Front Load 7kg
PRODUCT CODE: IND-XWDE751480X', CAST(70000.00 AS Decimal(18, 2)), 12, 3, 5, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (25, N'Side B Side', N'Samsung Side-By-Side Refrigerator 689 L
PRODUCT CODE: SMGRS72R5001M9', CAST(55000.00 AS Decimal(18, 2)), 12, 1, 5, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price], [Warrenty], [SupplierId], [CategoryId], [ProductStateId]) VALUES (26, N'Turbo Drum', N' The unique technology that knows how to take care of your clothes while giving you the perfect wash. The dual direction rotating drum reduces tangling of clothes which ensures your clothes stay as fresh and new for much longer than ever before.

', CAST(55000.00 AS Decimal(18, 2)), 12, 3, 5, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductState] ON 

INSERT [dbo].[ProductState] ([Id], [State]) VALUES (1, N'Available')
INSERT [dbo].[ProductState] ([Id], [State]) VALUES (2, N'OutOfStock')
INSERT [dbo].[ProductState] ([Id], [State]) VALUES (3, N'Discontinued')
SET IDENTITY_INSERT [dbo].[ProductState] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'StockManager')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'StockKeeper')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [Name], [Description], [PhoneNumber], [Address], [SupplierStateId]) VALUES (1, N'Samsung', N'Samsung is a South Korean company that is one of the world''s largest producers of electronic devices. Samsung specializes in the production of a wide variety of consumer and industry electronics, including appliances, digital media devices, semiconductors, memory chips, and integrated systems.', N'0115413413', N'515 T. B. Jayah Mawatha, Colombo 00700', 1)
INSERT [dbo].[Supplier] ([Id], [Name], [Description], [PhoneNumber], [Address], [SupplierStateId]) VALUES (2, N'Sony', N'Sony Corporation is the electronics business unit and the parent company of the Sony Group. It primarily conducts strategic business planning of the group, research and development (R&D), planning, designing and marketing for electronics products.', N'0112677631', N'150/3 Ward Pl, Colombo 00700', 1)
INSERT [dbo].[Supplier] ([Id], [Name], [Description], [PhoneNumber], [Address], [SupplierStateId]) VALUES (3, N'LG', N'LG Electronics is a core company of South Korean conglomerate LG group, alongside LG Chem. Founded in 1958, LG Electronics has led the country''s electronics industry since its early days as the first producer of radios, TVs and other appliances.', N'0115775000', N'498 Galle Rd, Colombo 00300', 1)
INSERT [dbo].[Supplier] ([Id], [Name], [Description], [PhoneNumber], [Address], [SupplierStateId]) VALUES (4, N'Singer', N'Singer (Sri Lanka) PLC is engaged in providing retail and wholesale marketing, financing, assembling and manufacturing services.', N'0115400400', N'112 Havelock Rd, Colombo 00500', 1)
INSERT [dbo].[Supplier] ([Id], [Name], [Description], [PhoneNumber], [Address], [SupplierStateId]) VALUES (5, N'Huawei', N'Huawei Technologies Co., Ltd.This is a Chinese multinational technology company headquartered in Shenzhen, Guangdong. It provides telecommunications equipment and sells consumer electronics like smartphones.', N'0812222433', N'337 Peradeniya Rd, Kandy 20000', 1)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[SupplierState] ON 

INSERT [dbo].[SupplierState] ([Id], [State]) VALUES (1, N'Active    ')
INSERT [dbo].[SupplierState] ([Id], [State]) VALUES (2, N'Deactive  ')
SET IDENTITY_INSERT [dbo].[SupplierState] OFF
GO
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
