CREATE OR ALTER PROCEDURE usp_DeleteEmployeesFromDepartment
(
	@DepartmentId INT
)
AS 
BEGIN
	DELETE FROM EmployeesProjects
	WHERE EmployeeID IN (
		SELECT E.EmployeeID
		  FROM Employees E
		 WHERE E.DepartmentID = @DepartmentId
	);

	UPDATE Employees
	SET ManagerID = NULL
	WHERE ManagerID IN ( 
		SELECT E.EmployeeID
		  FROM Employees E
		 WHERE E.DepartmentID = @DepartmentId
	);

	ALTER TABLE Departments
	ALTER COLUMN ManagerId INT;

	UPDATE Departments
	SET ManagerID = NULL
	WHERE DepartmentID = @DepartmentId;

	DELETE FROM Employees
	WHERE DepartmentID = @DepartmentId;

	DELETE FROM Departments
	WHERE DepartmentID = @DepartmentId;

	SELECT COUNT(*)
	FROM Employees
    WHERE DepartmentID = @DepartmentId;
END

EXEC usp_DeleteEmployeesFromDepartment 1;

SELECT COUNT(*)
	FROM Employees
    WHERE DepartmentID = 1;
