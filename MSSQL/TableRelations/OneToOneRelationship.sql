--USE [RELATIONSHIPS]

CREATE TABLE Passports
(
	PassportID BIGINT NOT NULL PRIMARY KEY IDENTITY(101, 1),
	PassportNumber CHAR(8) NOT NULL UNIQUE
)

CREATE TABLE People 
(
	PersonID BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	FirstName NVARCHAR(50) NOT NULL,
	Salary DECIMAL(9, 2) NOT NULL,
	PassportID BIGINT UNIQUE NOT NULL REFERENCES Passports(PassportId)
)

INSERT INTO Passports
VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2')

INSERT INTO People
VALUES
('Roberto', 43300, 102),
('Tom', 56100, 103),
('Yana', 60200, 101)