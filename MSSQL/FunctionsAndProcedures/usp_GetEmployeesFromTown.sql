CREATE OR ALTER PROCEDURE usp_GetEmployeesFromTown
(
	@TownName VARCHAR(50)
)
AS 
BEGIN 
	SELECT E.FirstName [First Name], E.LastName [Last Name]
	FROM 
		(
		 SELECT T.TownID
		 FROM Towns T
		 WHERE T.[Name] = @TownName
		) T
		JOIN Addresses A ON A.TownID = T.TownID
		JOIN Employees E ON E.AddressID = A.AddressID
END

EXEC usp_GetEmployeesFromTown 'Sofia';