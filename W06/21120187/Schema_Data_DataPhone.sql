USE [DataPhone]
GO
/****** Object:  Table [dbo].[Phone]    Script Date: 24/12/2023 9:25:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phone](
	[PhoneID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Manufacturer] [nvarchar](max) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PhoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Phone] ON 

INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (1, N'iPhone 14 Pro Max', N'Images/1.png', N'Apple', 27290000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (2, N'iPhone 14 Pro', N'Images/2.png', N'Apple', 25290000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (3, N'Samsung Galaxy S21 FE', N'Images/3.png', N'Samsung', 10990000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (4, N'Xiaomi Redmi 12C', N'Images/4.png', N'Xiaomi', 2890000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (5, N'Samsung Galaxy S23 Ultra', N'Images/5.png', N'Samsung', 26990000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (6, N'iPhone 11 64GB', N'Images/6.png', N'Apple', 10590000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (7, N'Vivo Y35', N'Images/7.png', N'Vivo', 6290000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (8, N'OPPO Reno8 T 5G', N'Images/8.png', N'OPPO', 10990000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (9, N'Samsung Galaxy A23', N'Images/9.png', N'Samsung', 4790000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (10, N'Samsung Galaxy S20 FE', N'Images/10.png', N'Samsung', 8650000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (11, N'iPhone 14 128GB', N'Images/11.png', N'Apple', 19590000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (12, N'iPhone 15', N'Images/12.png', N'Apple', 21990000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (13, N'iPhone 15 Plus', N'Images/13.png', N'Apple', 24990000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (14, N'iPhone 15 Pro', N'Images/14.png', N'Apple', 28190000)
INSERT [dbo].[Phone] ([PhoneID], [Name], [ImagePath], [Manufacturer], [Price]) VALUES (15, N'iPhone 15 Pro Max', N'Images/15.png', N'Apple', 32990000)
SET IDENTITY_INSERT [dbo].[Phone] OFF
GO
