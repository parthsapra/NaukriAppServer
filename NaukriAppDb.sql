USE [master]
GO

/****** Object:  Database [NaukriAppDb]    Script Date: 23-03-2020 14:31:44 ******/
DROP DATABASE [NaukriAppDb]
GO

/****** Object:  Database [NaukriAppDb]    Script Date: 23-03-2020 14:31:44 ******/
CREATE DATABASE [NaukriAppDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NaukriAppDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NaukriAppDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NaukriAppDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NaukriAppDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [NaukriAppDb] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NaukriAppDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [NaukriAppDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [NaukriAppDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [NaukriAppDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [NaukriAppDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [NaukriAppDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [NaukriAppDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [NaukriAppDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [NaukriAppDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [NaukriAppDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [NaukriAppDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [NaukriAppDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [NaukriAppDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [NaukriAppDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [NaukriAppDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [NaukriAppDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [NaukriAppDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [NaukriAppDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [NaukriAppDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [NaukriAppDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [NaukriAppDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [NaukriAppDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [NaukriAppDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [NaukriAppDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [NaukriAppDb] SET  MULTI_USER 
GO

ALTER DATABASE [NaukriAppDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [NaukriAppDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [NaukriAppDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [NaukriAppDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [NaukriAppDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [NaukriAppDb] SET  READ_WRITE 
GO

