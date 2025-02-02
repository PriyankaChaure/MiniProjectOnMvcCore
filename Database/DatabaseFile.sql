USE [Mvc_Core_PC]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Admin]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[FristName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Author]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [bigint] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Book]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [bigint] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](max) NULL,
	[BookDesc] [nvarchar](max) NULL,
	[AuthorId] [bigint] NOT NULL,
	[SubjectId] [bigint] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[CustomerAddress] [nvarchar](max) NULL,
	[CustomerEmail] [nvarchar](max) NULL,
	[CustomerPhone] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sales]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SalesId] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[SalesDate] [datetime2](7) NULL,
	[BookId] [bigint] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Qty] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SalesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subject]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectId] [bigint] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 07-06-2024 17:08:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240326092318_Database-Create', N'7.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240328140327_Database-Create', N'7.0.17')
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (1, N'Priyanka', N'Chaure', N'priya@24', N'123')
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (2, N'Nishu', N'Chaure', N'Nishu@14', N'123')
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (3, N'Vinaya', N'Sable', N'Vinaya', N'123')
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (4, N'Gayatri', N'Mane', N'Gayatri Mane', N'123')
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (5, N'Jahnvi', N'Chavan', N'Jahnvi chavan', NULL)
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (6, N'Jahnvi', N'Chavan', N'Jahnvi chavan', N'123')
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (7, N'mane', N'm', N'mane', N'123')
INSERT [dbo].[Admin] ([AdminId], [FristName], [LastName], [UserName], [Password]) VALUES (8, N'prachi', N'salve', N'prachi@123', N'123')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (1, N'S.K.Narayan')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (3, N'P.P.Chaure')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (4, N'N.G.Gaikwad')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (5, N'L.S.Landge')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (7, N'R.K.Kamble')
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([BookId], [BookName], [BookDesc], [AuthorId], [SubjectId], [Price]) VALUES (1, N'C#', N'Programming Language Book ', 3, 1, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[Book] ([BookId], [BookName], [BookDesc], [AuthorId], [SubjectId], [Price]) VALUES (3, N'VB', N'Programming Language Book ', 1, 5, CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[Book] ([BookId], [BookName], [BookDesc], [AuthorId], [SubjectId], [Price]) VALUES (4, N'F#', N'Programming Language Book ', 4, 6, CAST(900.00 AS Decimal(18, 2)))
INSERT [dbo].[Book] ([BookId], [BookName], [BookDesc], [AuthorId], [SubjectId], [Price]) VALUES (6, N'Linq', N'Programming Language Book ', 4, 2, CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[Book] ([BookId], [BookName], [BookDesc], [AuthorId], [SubjectId], [Price]) VALUES (7, N'Asp.Net MVC', N'Programming Language Book ', 5, 6, CAST(600.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (1, N'Priyanka', N'pune', N'priya@gmail.com', N'1234567842')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (2, N'Sweety', N'Nigadi', N'sweety@gmail.com', N'9876543210')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (26, N'nitin', N'akurdi', N'nitin@rediffmail.com', N'45645654645')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (27, N'Vishakha', N'Khadki', N'vishakha@gmail.com', N'09876549999')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (28, N'sima', N'pune', N'sima@gmail.com', N'01234567842')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (30, N'Shital', N'Kamshet', N'shital@123', N'123456784')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (31, N'Kaveri', N'Dapodi', N'kaveri@gmail.com', N'777777777')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (32, N'sima', N'pune', N'sima@gmail.com', N'01234567842')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (33, N'Kaveri 5555', N'Dapodi 566', N'kaveri@gmail.com 76', N'77777777776')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (34, N'jhhg', N'dffgfg', N'fgf@gmail.com', N'777777777')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (35, N'jhhg fytu', N'dffgfg tytu', N'fgf@gmail.com ty', N'777777777 tyt')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (36, N'prachi sima', N'pune', N'sima@gmail.com', N'01234567842')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerAddress], [CustomerEmail], [CustomerPhone]) VALUES (37, N'Vishakha', N'Khadki', N'vishakha@gmail.com', N'09876549999')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (25, 27, CAST(N'2024-03-27 18:48:34.4045282' AS DateTime2), 3, CAST(700.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (26, 28, CAST(N'2024-03-27 18:52:15.8013780' AS DateTime2), 1, CAST(70.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (27, 30, CAST(N'2024-03-28 15:41:00.4748129' AS DateTime2), 6, CAST(990.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (28, 31, CAST(N'2024-03-28 15:41:36.3148960' AS DateTime2), 6, CAST(600.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (30, 33, CAST(N'2024-03-28 17:32:49.1560127' AS DateTime2), 6, CAST(600.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (31, 34, CAST(N'2024-03-28 17:56:22.7685965' AS DateTime2), 6, CAST(990.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (33, 36, CAST(N'2024-04-02 15:09:51.9336586' AS DateTime2), 1, CAST(123.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Sales] ([SalesId], [CustomerId], [SalesDate], [BookId], [Price], [Qty]) VALUES (34, 37, CAST(N'2024-04-06 11:05:33.1553156' AS DateTime2), 3, CAST(700.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Sales] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([SubjectId], [SubjectName]) VALUES (1, N'English')
INSERT [dbo].[Subject] ([SubjectId], [SubjectName]) VALUES (2, N'Hindi')
INSERT [dbo].[Subject] ([SubjectId], [SubjectName]) VALUES (5, N'Marathi')
INSERT [dbo].[Subject] ([SubjectId], [SubjectName]) VALUES (6, N'Science')
INSERT [dbo].[Subject] ([SubjectId], [SubjectName]) VALUES (9, N'History')
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [EmailId], [MobileNo], [Password]) VALUES (1, N'Priya', N'Chaure', N'priya@24gmail.com', N'99999999', N'123')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [EmailId], [MobileNo], [Password]) VALUES (2, N'yogita', N'Chavan', N'yogi@gmail.com', N'1234567890', N'123')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [EmailId], [MobileNo], [Password]) VALUES (3, N'yogita', N'Chavan', N'yogi@gmail.com', N'768878', N'123')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [EmailId], [MobileNo], [Password]) VALUES (4, N'yogita', N'Chavan', N'yogi@gmail.com', N'768878', N'1234')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author_AuthorId] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author_AuthorId]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Subject_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Subject_SubjectId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Book_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Book_BookId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customer_CustomerId]
GO
