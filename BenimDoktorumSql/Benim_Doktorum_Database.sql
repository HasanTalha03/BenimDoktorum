USE [master]
GO
/****** Object:  Database [Benim_Doktorum]    Script Date: 14.05.2025 16:48:38 ******/
CREATE DATABASE [Benim_Doktorum]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Benim_Doktorum', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Benim_Doktorum.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Benim_Doktorum_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Benim_Doktorum_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Benim_Doktorum] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Benim_Doktorum].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Benim_Doktorum] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET ARITHABORT OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Benim_Doktorum] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Benim_Doktorum] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Benim_Doktorum] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Benim_Doktorum] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Benim_Doktorum] SET  MULTI_USER 
GO
ALTER DATABASE [Benim_Doktorum] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Benim_Doktorum] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Benim_Doktorum] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Benim_Doktorum] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Benim_Doktorum] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Benim_Doktorum] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Benim_Doktorum] SET QUERY_STORE = ON
GO
ALTER DATABASE [Benim_Doktorum] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Benim_Doktorum]
GO
/****** Object:  User [Semih]    Script Date: 14.05.2025 16:48:38 ******/
CREATE USER [Semih] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[Benim_Doktorum]
GO
ALTER ROLE [db_owner] ADD MEMBER [Semih]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Semih]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Semih]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Semih]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Semih]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Semih]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Semih]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [Semih]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [Semih]
GO
/****** Object:  Schema [Benim_Doktorum]    Script Date: 14.05.2025 16:48:38 ******/
CREATE SCHEMA [Benim_Doktorum]
GO
/****** Object:  Schema [dbo.Tbl_Doktor]    Script Date: 14.05.2025 16:48:38 ******/
CREATE SCHEMA [dbo.Tbl_Doktor]
GO
/****** Object:  Table [dbo].[Tbl_Doktor]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Doktor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[isim] [varchar](50) NULL,
	[soy_isim] [varchar](50) NULL,
	[universite] [smallint] NULL,
	[e_posta] [varchar](50) NULL,
	[sifre] [int] NULL,
	[telefon] [varchar](15) NULL,
	[yas] [smallint] NULL,
	[cinsiyet] [bit] NULL,
	[sehir] [smallint] NULL,
	[uzmanlik] [smallint] NULL,
	[resim] [varbinary](max) NULL,
	[hastane] [smallint] NULL,
 CONSTRAINT [PK_Tbl_Doktor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Telefon] UNIQUE NONCLUSTERED 
(
	[telefon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Hasta]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Hasta](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[isim] [varchar](50) NOT NULL,
	[soy_isim] [varchar](50) NOT NULL,
	[sehir] [smallint] NULL,
	[e_posta] [varchar](50) NOT NULL,
	[sifre] [int] NOT NULL,
	[sigorta] [smallint] NOT NULL,
	[telefon] [varchar](15) NOT NULL,
	[yas] [smallint] NOT NULL,
	[cinsiyet] [bit] NOT NULL,
 CONSTRAINT [PK_Tbl_Hasta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Hastane]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Hastane](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[Hastane_adi] [varchar](150) NULL,
 CONSTRAINT [PK_Tbl_Hastane] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Randevu]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Randevu](
	[randevu_id] [smallint] IDENTITY(1,1) NOT NULL,
	[randevu_tarihi] [datetime] NULL,
	[randevu_url] [varchar](100) NULL,
	[doktor_id] [int] NULL,
	[hasta_id] [smallint] NULL,
	[saat] [varchar](10) NULL,
 CONSTRAINT [PK_Tbl_Randevu] PRIMARY KEY CLUSTERED 
(
	[randevu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sehir]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sehir](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[sehir] [nchar](13) NULL,
 CONSTRAINT [PK_Tbl_Sehir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_sigorta]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_sigorta](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[sigorta_turu] [nvarchar](250) NULL,
 CONSTRAINT [PK__Tbl_sigo__3213E83FF66C475F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Universite]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Universite](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[universite_adi] [nchar](70) NULL,
 CONSTRAINT [PK_Tbl_Universite] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Uzmanlik]    Script Date: 14.05.2025 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Uzmanlik](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[uzmanlik] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_uzmanlik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tbl_Doktor]    Script Date: 14.05.2025 16:48:38 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tbl_Doktor] ON [dbo].[Tbl_Doktor]
(
	[e_posta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tbl_Hasta]    Script Date: 14.05.2025 16:48:38 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tbl_Hasta] ON [dbo].[Tbl_Hasta]
(
	[e_posta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Doktor]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Doktor_Tbl_Hastane] FOREIGN KEY([hastane])
REFERENCES [dbo].[Tbl_Hastane] ([id])
GO
ALTER TABLE [dbo].[Tbl_Doktor] CHECK CONSTRAINT [FK_Tbl_Doktor_Tbl_Hastane]
GO
ALTER TABLE [dbo].[Tbl_Doktor]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Doktor_Tbl_Sehir] FOREIGN KEY([sehir])
REFERENCES [dbo].[Tbl_Sehir] ([id])
GO
ALTER TABLE [dbo].[Tbl_Doktor] CHECK CONSTRAINT [FK_Tbl_Doktor_Tbl_Sehir]
GO
ALTER TABLE [dbo].[Tbl_Doktor]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Doktor_Tbl_Universite] FOREIGN KEY([universite])
REFERENCES [dbo].[Tbl_Universite] ([id])
GO
ALTER TABLE [dbo].[Tbl_Doktor] CHECK CONSTRAINT [FK_Tbl_Doktor_Tbl_Universite]
GO
ALTER TABLE [dbo].[Tbl_Doktor]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Doktor_Tbl_Uzmanlik] FOREIGN KEY([uzmanlik])
REFERENCES [dbo].[Tbl_Uzmanlik] ([id])
GO
ALTER TABLE [dbo].[Tbl_Doktor] CHECK CONSTRAINT [FK_Tbl_Doktor_Tbl_Uzmanlik]
GO
ALTER TABLE [dbo].[Tbl_Hasta]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Hasta_Tbl_Sehir] FOREIGN KEY([sehir])
REFERENCES [dbo].[Tbl_Sehir] ([id])
GO
ALTER TABLE [dbo].[Tbl_Hasta] CHECK CONSTRAINT [FK_Tbl_Hasta_Tbl_Sehir]
GO
ALTER TABLE [dbo].[Tbl_Hasta]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Hasta_Tbl_sigorta] FOREIGN KEY([sigorta])
REFERENCES [dbo].[Tbl_sigorta] ([id])
GO
ALTER TABLE [dbo].[Tbl_Hasta] CHECK CONSTRAINT [FK_Tbl_Hasta_Tbl_sigorta]
GO
ALTER TABLE [dbo].[Tbl_Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Randevu_Tbl_Doktor] FOREIGN KEY([doktor_id])
REFERENCES [dbo].[Tbl_Doktor] ([id])
GO
ALTER TABLE [dbo].[Tbl_Randevu] CHECK CONSTRAINT [FK_Tbl_Randevu_Tbl_Doktor]
GO
ALTER TABLE [dbo].[Tbl_Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Randevu_Tbl_Hasta] FOREIGN KEY([hasta_id])
REFERENCES [dbo].[Tbl_Hasta] ([id])
GO
ALTER TABLE [dbo].[Tbl_Randevu] CHECK CONSTRAINT [FK_Tbl_Randevu_Tbl_Hasta]
GO
USE [master]
GO
ALTER DATABASE [Benim_Doktorum] SET  READ_WRITE 
GO
