CREATE OR ALTER PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT E.FirstName [First Name], E.LastName [Last Name]
	FROM Employees E
	WHERE E.Salary > 35000;
END

GO

EXEC usp_GetEmployeesSalaryAbove35000