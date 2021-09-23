USE [SoftUni]

--SELECT D.Name
--FROM Departments D

--SELECT E.FirstName, E.LastName, E.Salary
--FROM Employees E

--SELECT E.FirstName, E.MiddleName, E.LastName
--FROM Employees E

--SELECT CONCAT(E.FirstName, '.', E.LastName, '@softuni.bg') [Full Email Address]
--FROM Employees E

--SELECT DISTINCT E.Salary
--FROM Employees E

--SELECT *
--FROM Employees E
--WHERE E.JobTitle = 'Sales Representative'

--SELECT E.FirstName, E.LastName, E.JobTitle
--FROM Employees E
--WHERE E.Salary BETWEEN 20000 AND 30000

--SELECT CONCAT(E.FirstName, ' ', E.MiddleName, ' ', E.LastName)
--FROM Employees E
--WHERE E.Salary IN (25000, 14000, 12500, 23600)

--SELECT E.FirstName, E.LastName
--FROM Employees E
--WHERE E.EmployeeID NOT IN (
--		SELECT E.EmployeeID
--		FROM Employees E
--		WHERE E.JobTitle like '%manager%')

--SELECT E.FirstName, E.LastName
--FROM Employees E
--WHERE E.ManagerID IS NULL

--SELECT E.FirstName, E.LastName, E.Salary
--FROM Employees E
--WHERE E.Salary > 50000
--ORDER BY E.Salary DESC

--SELECT TOP(5) E.FirstName, E.LastName
--FROM Employees E
--ORDER BY E.Salary DESC

--SELECT E.FirstName, E.LastName
--FROM Employees E
--WHERE E.DepartmentID != 4

--SELECT *
--FROM Employees E
--ORDER BY E.Salary DESC, E.FirstName, E.LastName DESC, E.MiddleName

--CREATE VIEW V_EmployeesSalaries AS
--SELECT E.FirstName, E.LastName, E.Salary
--FROM Employees E

--CREATE VIEW V_EmployeeNameJobTitle AS
--SELECT CONCAT(E.FirstName, ' ', COALESCE(E.MiddleName, ''), ' ', E.LastName) [Full NAME], E.JobTitle [Job Title]
--FROM Employees E

--SELECT DISTINCT E.JobTitle
--FROM Employees E

--SELECT TOP(10) *
--FROM Projects P
--ORDER BY P.StartDate, P.Name

--SELECT TOP(7) E.FirstName, E.LastName, E.HireDate
--FROM Employees E
--ORDER BY E.HireDate DESC

UPDATE Employees 
SET Salary = Salary * 1.12
WHERE DepartmentID IN (1, 2, 4, 11)

SELECT E.Salary
FROM Employees E