-- CREATE DATABASE [Minions];

USE [Minions]

--CREATE TABLE [Minions]
--(
--	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
--	[Name] NVARCHAR(100) NOT NULL,
--	[Age] INT 
--)

--CREATE TABLE [Towns]
--(
--	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
--	[Name] NVARCHAR(100) NOT NULL	
--)

--ALTER TABLE dbo.Minions 
--ADD [TownId] BIGINT FOREIGN KEY REFERENCES [Towns]([Id]);


--INSERT INTO [Towns] ([Id], [Name])
--VALUES 
--(1, 'Sofia'),
--(2, 'Plovdiv'),
--(3, 'Varna');

--INSERT INTO [Minions] ([Id], [Name], [Age], [TownId])
--VALUES 
--(1, 'Kevin', 22, 1),
--(2, 'Bob', 15, 3),
--(3, 'Steward', null, 2);

--TRUNCATE TABLE [Minions]

--DROP TABLE [Minions];
--DROP TABLE [Towns];

--CREATE TABLE [People]
--(
--	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
--	[Name] NVARCHAR(200) NOT NULL,
--	[Picture] VARBINARY(MAX) CHECK (DATALENGTH([Picture]) <= 2 * 1024 * 1024),
--	[Height] DECIMAL(3, 2),
--	[Weight] DECIMAL(5, 2),
--	[Gender] CHAR(1) NOT NULL CHECK([Gender] = 'm' OR [Gender] = 'f'),
--	[Birthdate] DATETIME2 NOT NULL,
--	[Biography] NVARCHAR(MAX)
--);

--INSERT INTO [People] ([Name], [Height], [Weight], [Gender], [Birthdate])
--VALUES
--('Tania', 1.69, 46.8, 'f', '1996-02-15'),
--('Emo', 1.73, 61, 'm', '1989-02-14'),
--('Maria', NULL, NULL, 'f', '1960-11-30'),
--('Tania', 1.69, 46.8, 'f', '1980-08-08'),
--('Tania', 1.69, 46.8, 'f', '1996-12-01');

--CREATE TABLE [Users]
--(
--	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
--	[Username] VARCHAR(30) NOT NULL UNIQUE,
--	[Password] VARCHAR(26) NOT NULL,
--	[ProfilePicture] VARBINARY(MAX) CHECK (DATALENGTH([ProfilePicture]) <= 900000),
--	[LastLoginTime] DATETIME2,
--	[IsDeleted] BIT
--);

--INSERT INTO [Users] ([Username], [Password], [IsDeleted])
--VALUES
--('tania_15', '150296', 0),
--('tania', '150296', 0),
--('tania_1502', '150296', 0),
--('tania_1522', '150296', 0),
--('tania_1596', '150296', 0);

--ALTER TABLE [Users]
--DROP CONSTRAINT [PK__Users__3214EC0785D02353];

--ALTER TABLE [Users]
--ADD CONSTRAINT [PK_UsersCompositeIsUsername] PRIMARY KEY ([Id], [Username]);

ALTER TABLE [Users]
ADD CHECK (DATALENGTH([Password]) <= 5);