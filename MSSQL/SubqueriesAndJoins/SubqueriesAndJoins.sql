SELECT TOP(5) E.EmployeeID, E.JobTitle, A.AddressID, A.AddressText
FROM Employees E
	JOIN Addresses A ON E.AddressID = A.AddressID
ORDER BY A.AddressID

SELECT TOP 50 E.FirstName, E.LastName, T.[Name], A.AddressText
FROM Employees E
	JOIN Addresses A ON E.AddressID = A.AddressID
	JOIN Towns T ON A.TownID = T.TownID
ORDER BY E.FirstName, E.LastName

SELECT E.EmployeeID, E.FirstName, E.LastName, D.[Name]
FROM Employees E
	JOIN Departments D ON E.DepartmentID = D.DepartmentID
WHERE D.[Name] = 'Sales'
ORDER BY E.EmployeeID

SELECT TOP 5 E.EmployeeID, E.FirstName, E.Salary, D.[Name] DepartmentName
FROM Employees E
	JOIN Departments D ON E.DepartmentID = D.DepartmentID
WHERE E.Salary > 15000
ORDER BY D.DepartmentID

SELECT TOP 3 E.EmployeeID, E.FirstName
FROM Employees E
	LEFT JOIN EmployeesProjects P ON E.EmployeeID = P.EmployeeID
WHERE P.EmployeeID IS NULL
ORDER BY E.EmployeeID

SELECT E.FirstName, E.LastName, E.HireDate, D.[Name] DeptName
FROM Employees E
	JOIN Departments D ON E.DepartmentID = D.DepartmentID
WHERE E.HireDate > '1999-01-01' AND (D.[Name] = 'Sales' OR D.[Name] = 'Finance')
ORDER BY E.HireDate

SELECT TOP 5 E.EmployeeID, E.FirstName, P.[Name] ProjectName
FROM Employees E
	JOIN EmployeesProjects EP ON EP.EmployeeID = E.EmployeeID
	JOIN Projects P ON P.ProjectID = EP.ProjectID
WHERE P.StartDate > '2002-08-13' AND P.EndDate IS NULL
ORDER BY E.EmployeeID

SELECT TOP 5 E.EmployeeID, E.FirstName, 
	IIF(YEAR(P.StartDate) >= 2005, NULL, P.[Name]) ProjectName
FROM Employees E
	JOIN EmployeesProjects EP ON EP.EmployeeID = E.EmployeeID
	JOIN Projects P ON P.ProjectID = EP.ProjectID
WHERE E.EmployeeID = 24

SELECT E.EmployeeID, E.FirstName, E.ManagerID, M.FirstName ManagerName	
FROM Employees E
	JOIN Employees M ON E.ManagerID = M.EmployeeID
WHERE E.ManagerID = 3 OR E.ManagerID = 7
ORDER BY E.EmployeeID

SELECT TOP 50 E.EmployeeID, CONCAT(E.FirstName, ' ', E.LastName), 
	CONCAT(M.FirstName, ' ', M.LastName) ManagerName, D.[Name] DepartmentName
FROM Employees E
	JOIN Employees M ON E. ManagerID = M.EmployeeID
	JOIN Departments D ON E. DepartmentID = D.DepartmentID
ORDER BY E.EmployeeID

SELECT MIN(T.AverageSalary) MinAverageSalary
FROM
(
	SELECT AVG(E.Salary) AverageSalary
	FROM Employees E
	GROUP BY E.DepartmentID
) T
