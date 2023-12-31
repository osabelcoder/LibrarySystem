USE [master]
GO
/****** Object:  Database [LibSys]    Script Date: 11/26/2023 8:14:42 PM ******/
CREATE DATABASE [LibSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibSys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS03\MSSQL\DATA\LibSys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibSys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS03\MSSQL\DATA\LibSys_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LibSys] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibSys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibSys] SET  MULTI_USER 
GO
ALTER DATABASE [LibSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibSys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibSys] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibSys] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LibSys] SET QUERY_STORE = ON
GO
ALTER DATABASE [LibSys] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LibSys]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 11/26/2023 8:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[roleID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[author]    Script Date: 11/26/2023 8:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[author](
	[authorID] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[title] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book]    Script Date: 11/26/2023 8:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[accession_number] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[author] [varchar](50) NOT NULL,
	[volume] [varchar](50) NULL,
	[genre] [varchar](50) NOT NULL,
	[date_published] [datetime] NOT NULL,
	[publisher] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[accession_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[borrowedBooks]    Script Date: 11/26/2023 8:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[borrowedBooks](
	[borrow_id] [int] IDENTITY(1,1) NOT NULL,
	[studentID] [varchar](50) NOT NULL,
	[studentName] [varchar](50) NOT NULL,
	[department] [varchar](50) NOT NULL,
	[course] [varchar](50) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[dateBorrowed] [datetime] NULL,
	[dateReturned] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role]    Script Date: 11/26/2023 8:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role](
	[roleID] [int] NOT NULL,
	[roleName] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 11/26/2023 8:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[studentID] [varchar](50) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[year_level] [varchar](50) NOT NULL,
	[department] [varchar](50) NOT NULL,
	[course] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[dateregistered] [datetime] NOT NULL,
	[roleID] [int] NOT NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [LibSys] SET  READ_WRITE 
GO
