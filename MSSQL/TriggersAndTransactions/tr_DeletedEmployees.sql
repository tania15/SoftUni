CREATE TABLE Deleted_Employees
(
	EmployeeId INT NOT NULL PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL, 
	LastName VARCHAR(50) NOT NULL, 
	MiddleName VARCHAR(50), 
	JobTitle VARCHAR(50) NOT NULL,
	DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(DepartmentId), 
	Salary MONEY NOT NULL
)

GO

CREATE OR ALTER TRIGGER tr_DeletedEmployees
ON Employees FOR DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees
	SELECT D.FirstName, D.LastName, D.MiddleName, D.JobTitle, D.DepartmentID, D.Salary
	FROM deleted D;
END

DELETE FROM Employees
WHERE EmployeeID = 3;