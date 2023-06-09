USE [test]
GO
ALTER TABLE [dbo].[tu_luan] DROP CONSTRAINT [FK_question_id]
GO
ALTER TABLE [dbo].[trac_nghiem] DROP CONSTRAINT [FK_ID_question]
GO
/****** Object:  Index [UQ__question__2045B481DC253B49]    Script Date: 5/10/2023 11:53:55 PM ******/
ALTER TABLE [dbo].[question] DROP CONSTRAINT [UQ__question__2045B481DC253B49]
GO
/****** Object:  Table [dbo].[tu_luan]    Script Date: 5/10/2023 11:53:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tu_luan]') AND type in (N'U'))
DROP TABLE [dbo].[tu_luan]
GO
/****** Object:  Table [dbo].[trac_nghiem]    Script Date: 5/10/2023 11:53:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trac_nghiem]') AND type in (N'U'))
DROP TABLE [dbo].[trac_nghiem]
GO
/****** Object:  Table [dbo].[question]    Script Date: 5/10/2023 11:53:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[question]') AND type in (N'U'))
DROP TABLE [dbo].[question]
GO
/****** Object:  Table [dbo].[account]    Script Date: 5/10/2023 11:53:55 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[account]') AND type in (N'U'))
DROP TABLE [dbo].[account]
GO
USE [master]
GO
/****** Object:  Database [test]    Script Date: 5/10/2023 11:53:55 PM ******/
DROP DATABASE [test]
GO
/****** Object:  Database [test]    Script Date: 5/10/2023 11:53:55 PM ******/
CREATE DATABASE [test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [test] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [test] SET ARITHABORT OFF 
GO
ALTER DATABASE [test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [test] SET  MULTI_USER 
GO
ALTER DATABASE [test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [test] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [test] SET QUERY_STORE = ON
GO
ALTER DATABASE [test] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [test]
GO
/****** Object:  Table [dbo].[account]    Script Date: 5/10/2023 11:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
	[email] [varchar](30) NULL,
	[role] [int] NULL,
	[password_key] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[question]    Script Date: 5/10/2023 11:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[question](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Noi_dung] [nvarchar](40) NOT NULL,
	[Hoc_phan] [nvarchar](20) NOT NULL,
	[Kieu_cau_hoi] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trac_nghiem]    Script Date: 5/10/2023 11:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trac_nghiem](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[ID_question] [int] NOT NULL,
	[A] [nvarchar](50) NOT NULL,
	[B] [nvarchar](50) NOT NULL,
	[C] [nvarchar](50) NOT NULL,
	[D] [nvarchar](50) NOT NULL,
	[Lua_chon] [char](1) NOT NULL,
	[Diem] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tu_luan]    Script Date: 5/10/2023 11:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tu_luan](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[ID_question] [int] NOT NULL,
	[Diem] [float] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 

INSERT [dbo].[account] ([id], [username], [password], [email], [role], [password_key]) VALUES (10, N'longthanh', N'1411', N'longthanh1411@gmail.com', 1, N'0CD55561B4')
INSERT [dbo].[account] ([id], [username], [password], [email], [role], [password_key]) VALUES (11, N'duchuy', N'1411', N'duchuy@gmail.com', 1, N'724A7CF7BB')
INSERT [dbo].[account] ([id], [username], [password], [email], [role], [password_key]) VALUES (12, N'vuan', N'1411', N'vuan@gmail.com', 1, N'D2451B6CA4')
INSERT [dbo].[account] ([id], [username], [password], [email], [role], [password_key]) VALUES (13, N'huyhoang', N'1411', N'huyhoang@gmail.com', 1, N'2C7BB7A228')
SET IDENTITY_INSERT [dbo].[account] OFF
GO
SET IDENTITY_INSERT [dbo].[question] ON 

INSERT [dbo].[question] ([ID], [Noi_dung], [Hoc_phan], [Kieu_cau_hoi]) VALUES (19, N'test0', N'TIN', N'tự luận')
INSERT [dbo].[question] ([ID], [Noi_dung], [Hoc_phan], [Kieu_cau_hoi]) VALUES (20, N'test1', N'TIN', N'tự luận')
INSERT [dbo].[question] ([ID], [Noi_dung], [Hoc_phan], [Kieu_cau_hoi]) VALUES (21, N'test2', N'GDQP', N'tự luận')
INSERT [dbo].[question] ([ID], [Noi_dung], [Hoc_phan], [Kieu_cau_hoi]) VALUES (22, N'test89', N'TIN', N'tự luận')
INSERT [dbo].[question] ([ID], [Noi_dung], [Hoc_phan], [Kieu_cau_hoi]) VALUES (23, N'test4', N'GDQP', N'tự luận')
INSERT [dbo].[question] ([ID], [Noi_dung], [Hoc_phan], [Kieu_cau_hoi]) VALUES (31, N'test56', N'TIN', N'trắc nghiệm')
SET IDENTITY_INSERT [dbo].[question] OFF
GO
SET IDENTITY_INSERT [dbo].[trac_nghiem] ON 

INSERT [dbo].[trac_nghiem] ([STT], [ID_question], [A], [B], [C], [D], [Lua_chon], [Diem]) VALUES (21, 31, N'1', N'2', N'3', N'4', N'D', 4.5)
SET IDENTITY_INSERT [dbo].[trac_nghiem] OFF
GO
SET IDENTITY_INSERT [dbo].[tu_luan] ON 

INSERT [dbo].[tu_luan] ([STT], [ID_question], [Diem]) VALUES (7, 19, 2.5)
INSERT [dbo].[tu_luan] ([STT], [ID_question], [Diem]) VALUES (8, 20, 2.5)
INSERT [dbo].[tu_luan] ([STT], [ID_question], [Diem]) VALUES (9, 21, 2.5)
INSERT [dbo].[tu_luan] ([STT], [ID_question], [Diem]) VALUES (12, 22, 2.8)
INSERT [dbo].[tu_luan] ([STT], [ID_question], [Diem]) VALUES (11, 23, 2.5)
SET IDENTITY_INSERT [dbo].[tu_luan] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__question__2045B481DC253B49]    Script Date: 5/10/2023 11:53:55 PM ******/
ALTER TABLE [dbo].[question] ADD UNIQUE NONCLUSTERED 
(
	[Noi_dung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[trac_nghiem]  WITH CHECK ADD  CONSTRAINT [FK_ID_question] FOREIGN KEY([ID_question])
REFERENCES [dbo].[question] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[trac_nghiem] CHECK CONSTRAINT [FK_ID_question]
GO
ALTER TABLE [dbo].[tu_luan]  WITH CHECK ADD  CONSTRAINT [FK_question_id] FOREIGN KEY([ID_question])
REFERENCES [dbo].[question] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tu_luan] CHECK CONSTRAINT [FK_question_id]
GO
USE [master]
GO
ALTER DATABASE [test] SET  READ_WRITE 
GO
