USE RELATIONSHIPS;

CREATE TABLE Manufacturers
(
	ManufacturerID BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Name] NVARCHAR(50) NOT NULL UNIQUE,
	EstablishedOn DATETIME2
)

CREATE TABLE Models
(
	ModelID BIGINT NOT NULL PRIMARY KEY IDENTITY(101, 1),
	[Name] NVARCHAR(50) NOT NULL,
	ManufacturerID BIGINT NOT NULL FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers
VALUES
('BMV', '1916-03-07'),
('Tesla', '2003-01-01'),
('Lada', '1966-05-01')

INSERT INTO Models
VALUES
('X1', 1),
('i6', 1),
('Model S', 2),
('Model X', 2),
('Model 3', 2),
('Nova', 3)