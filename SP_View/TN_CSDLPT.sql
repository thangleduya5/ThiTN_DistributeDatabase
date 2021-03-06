USE [master]
GO

/****** Object:  Database [TN_CSDLPT]    Script Date: 29/10/2021 1:56:46 PM ******/
CREATE DATABASE [TN_CSDLPT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TN_CSDLPT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TN_CSDLPT.mdf' , SIZE = 31744KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TN_CSDLPT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TN_CSDLPT_log.ldf' , SIZE = 43264KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [TN_CSDLPT] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TN_CSDLPT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TN_CSDLPT] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET ARITHABORT OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TN_CSDLPT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TN_CSDLPT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TN_CSDLPT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TN_CSDLPT] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET RECOVERY FULL 
GO

ALTER DATABASE [TN_CSDLPT] SET  MULTI_USER 
GO

ALTER DATABASE [TN_CSDLPT] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TN_CSDLPT] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TN_CSDLPT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TN_CSDLPT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [TN_CSDLPT] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TN_CSDLPT] SET  READ_WRITE 
GO

