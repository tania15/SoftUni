--CREATE DATABASE WMS

CREATE TABLE Clients
(
	ClientId INT NOT NULL PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Phone CHAR(12) CHECK(LEN(Phone) = 12)
)

CREATE TABLE Mechanics
(
	MechanicId INT NOT NULL PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	[Address] VARCHAR(255)
)

CREATE TABLE Models
(
	ModelId INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) UNIQUE
)

CREATE TABLE Vendors
(
	VendorId INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) UNIQUE
)

CREATE TABLE Parts
(
	PartId INT NOT NULL PRIMARY KEY IDENTITY,
	SerialNumber VARCHAR(50) UNIQUE,
	[Description] VARCHAR(255),
	Price DECIMAL(6, 2) CHECK(Price > 0),
	VendorId INT FOREIGN KEY REFERENCES Vendors(VendorId),
	StockQty INT NOT NULL DEFAULT 0	
)

CREATE TABLE Jobs
(
	JobId INT NOT NULL PRIMARY KEY IDENTITY,
	ModelId INT FOREIGN KEY REFERENCES Models(ModelId),
	[Status] VARCHAR(11) DEFAULT 'Pending' CHECK([Status] = 'Pending' OR [Status] = 'In Progress' OR [Status] = 'Finished'),
	ClientId INT FOREIGN KEY REFERENCES Clients(ClientId),
	MechanicId INT FOREIGN KEY REFERENCES Mechanics(MechanicId),
	IssueDate DATE,
	FinishDate DATE
)

CREATE TABLE Orders
(
	OrderId INT NOT NULL PRIMARY KEY IDENTITY,
	JobId INT FOREIGN KEY REFERENCES Jobs(JobId),
	IssueDate DATE,
	Delivered BIT DEFAULT 0
)

CREATE TABLE OrderParts
(
	OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
	PartId INT NOT NULL FOREIGN KEY REFERENCES Parts(PartId),
	Quantity INT DEFAULT 1 CHECK(Quantity > 0),
	PRIMARY KEY(OrderId, PartId)
)

CREATE TABLE PartsNeeded
(
	JobId INT NOT NULL FOREIGN KEY REFERENCES Jobs(JobId),
	PartId INT NOT NULL FOREIGN KEY REFERENCES Parts(PartId),
	Quantity INT DEFAULT 1 CHECK(Quantity > 0),
	PRIMARY KEY(JobId, PartId)
)