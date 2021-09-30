SELECT E.FirstName, E.LastName
FROM Employees E
WHERE E.FirstName LIKE 'Sa%'

SELECT E.FirstName, E.LastName
FROM Employees E
WHERE E.LastName LIKE '%ei%'

SELECT E.FirstName
FROM Employees E
WHERE (E.DepartmentID = 3 OR E.DepartmentID = 10) AND DATEPART(YEAR, E.HireDate) BETWEEN 1995 AND 2005

SELECT E.FirstName, E.LastName
FROM Employees E
WHERE E.JobTitle NOT LIKE '%engineer%'

SELECT T.Name
FROM Towns T
WHERE LEN(T.Name) = 5 OR LEN(T.Name) = 6
ORDER BY T.Name

SELECT T.TownID, T.Name
FROM Towns T
WHERE T.Name LIKE '[M, K, B, E]%'
ORDER BY T.Name

SELECT T.TownID, T.Name
FROM Towns T
WHERE T.Name NOT LIKE '[R, B, D]%'
ORDER BY T.Name

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT E.FirstName, E.LastName
FROM Employees E
WHERE DATEPART(YEAR, E.HireDate) > 2000

SELECT E.FirstName, E.LastName
FROM Employees E
WHERE LEN(E.LastName) = 5

SELECT E.EmployeeID, E.FirstName, E.LastName, E.Salary,
	DENSE_RANK() OVER (PARTITION BY E.Salary ORDER BY E.EmployeeID) Rank
FROM Employees E
WHERE E.Salary BETWEEN 10000 AND 50000
ORDER BY E.Salary DESC

SELECT *
FROM
(
SELECT E.EmployeeID, E.FirstName, E.LastName, E.Salary,
	DENSE_RANK() OVER (PARTITION BY E.Salary ORDER BY E.EmployeeID) [Rank]
FROM Employees E
WHERE E.Salary BETWEEN 10000 AND 50000
--ORDER BY E.Salary DESC
) T
WHERE T.[Rank] = 2
ORDER BY T.Salary DESC