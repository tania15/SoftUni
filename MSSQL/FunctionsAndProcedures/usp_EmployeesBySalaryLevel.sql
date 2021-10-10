CREATE OR ALTER PROCEDURE usp_EmployeesBySalaryLevel
(
	@LevelOfSalary VARCHAR(10)
)
AS
BEGIN
	SELECT E.FirstName [First Name], E.LastName [Last Name]
	FROM Employees E
	WHERE dbo.ufn_GetSalaryLevel(E.Salary) = @LevelOfSalary;
END

EXEC usp_EmployeesBySalaryLevel 'Low';