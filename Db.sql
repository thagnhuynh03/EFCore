CREATE DATABASE [Company]
GO
USE [Company]
GO
CREATE TABLE [Company] (
	[Id] int PRIMARY KEY IDENTITY(1, 1),
	[Name] nvarchar(50) NOT NULL
)
GO
CREATE TABLE [Department] (
	[Id] int PRIMARY KEY IDENTITY(1, 1),
	[Name] nvarchar(50),
	[CompanyId] int FOREIGN KEY REFERENCES [Company]([id])
)
CREATE TABLE [Employee] (
	[Id] int PRIMARY KEY IDENTITY(1, 1),
	[Name] nvarchar(50),
	[Gender] bit,
	[Age] int,
	[DepartmentId] int FOREIGN KEY REFERENCES [Department]([id]),
)

INSERT INTO [Company]
VALUES
	(N'Hoa Mai')

INSERT INTO [Department]
VALUES
	(N'IT', 1),
	(N'Marketing', 1),
	(N'Nhân sự', 1)
	

INSERT INTO [Employee]
VALUES
	(N'Huỳnh Kim Thắng', 1, 30, 2),
	(N'Hoàng Văn Sơn', 1, 20, 1),
	(N'Lê Xuân Thắng', 1, 39, 3),
	(N'Đinh Công Minh', 1, 34, 2),
	(N'Đoàn Văn Ca', 1, 35, 1)