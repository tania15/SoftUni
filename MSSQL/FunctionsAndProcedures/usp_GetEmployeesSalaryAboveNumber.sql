CREATE OR ALTER PROCEDURE usp_GetEmployeesSalaryAboveNumber
(
	@Salary DECIMAL(18,4)
)
AS
BEGIN
	SELECT E.FirstName [First Name], E.LastName [Last Name]
	FROM Employees E
	WHERE E.Salary >= @Salary;
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100;