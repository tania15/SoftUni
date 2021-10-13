SELECT TOP 10 
	ROW_NUMBER() OVER (ORDER BY E.Salary DESC) RowNumber,
	RANK() OVER (ORDER BY E.Salary DESC) [Rank],
	DENSE_RANK() OVER (ORDER BY E.Salary DESC) [DenseRank],
	E.FirstName, E.LastName, E.Salary
FROM Employees E

SELECT *
FROM
	(
	SELECT TOP 10 
		DENSE_RANK() OVER (ORDER BY E.Salary DESC) [DenseRank],
		E.FirstName, E.LastName, E.Salary
	FROM Employees E 
	) T
WHERE T.DenseRank = 2

SELECT E.EmployeeID, E.FirstName, E.LastName, E.Salary,
	DENSE_RANK() OVER (PARTITION BY E.Salary ORDER BY E.EmployeeID) [Rank]
FROM Employees E
WHERE E.Salary BETWEEN 10000 AND 50000
ORDER BY E.Salary DESC

SELECT DISTINCT T.DepartmentID, T.Salary
FROM
	(
	SELECT E.DepartmentID, E.Salary, DENSE_RANK() OVER (PARTITION BY E.DepartmentID ORDER BY E.Salary DESC) [Rank]	
	FROM Employees E
	--GROUP BY E.DepartmentID, E.Salary
	) T
WHERE T.Rank = 3
ORDER BY T.DepartmentID



-- Geography database
SELECT D.ContinentCode,  D.CurrencyCode, D.[Count] CurrencyUsage
FROM
	(
	SELECT T.*, DENSE_RANK() OVER (PARTITION BY T.ContinentCode ORDER BY T.[Count] DESC) [Rank]
	FROM
		(
		SELECT C.ContinentCode, C.CurrencyCode, COUNT(*) [Count]  --DENSE_RANK() OVER (ORDER BY C.CurrencyCode)
		FROM Countries C
		GROUP BY C.ContinentCode, C.CurrencyCode
		) T
	) D
WHERE D.[Rank] = 1 AND D.[Count] > 1
ORDER BY D.ContinentCode, d.CurrencyCode



