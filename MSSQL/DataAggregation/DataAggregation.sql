SELECT COUNT(*)
FROM WizzardDeposits

SELECT MAX(W.MagicWandSize) LongestMagicWand
FROM WizzardDeposits W

SELECT W.DepositGroup, MAX(W.MagicWandSize) LongestMagicWand
FROM WizzardDeposits W
GROUP BY W.DepositGroup

SELECT TOP 2 T.DepositGroup
FROM 
	( 
	SELECT W.DepositGroup, AVG(W.MagicWandSize) LongestMagicWand
	FROM WizzardDeposits W
	GROUP BY W.DepositGroup
	--ORDER BY 2 
	) T
ORDER BY T.LongestMagicWand

SELECT W.DepositGroup, SUM(W.DepositAmount)
FROM WizzardDeposits W
GROUP BY W.DepositGroup

SELECT W.DepositGroup, SUM(W.DepositAmount)
FROM WizzardDeposits W
WHERE W.MagicWandCreator LIKE '%Ollivander%'
GROUP BY W.DepositGroup

SELECT W.DepositGroup, SUM(W.DepositAmount) TotalSum
FROM WizzardDeposits W
WHERE W.MagicWandCreator LIKE '%Ollivander%'
GROUP BY W.DepositGroup
HAVING SUM(W.DepositAmount) < 150000
ORDER BY 2 DESC

SELECT W.DepositGroup, W.MagicWandCreator, MIN(W.DepositCharge)
FROM WizzardDeposits W
GROUP BY W.DepositGroup, W.MagicWandCreator
ORDER BY W.MagicWandCreator, W.DepositGroup

SELECT T.AgeGroup, COUNT(T.AgeGroup)
FROM
	(
	SELECT
		CASE 
			WHEN W.Age BETWEEN 0 AND 10 THEN '[0-10]'
			WHEN W.Age BETWEEN 11 AND 20 THEN '[11-20]'
			WHEN W.Age BETWEEN 21 AND 30 THEN '[21-30]'
			WHEN W.Age BETWEEN 31 AND 40 THEN '[31-40]'
			WHEN W.Age BETWEEN 41 AND 50 THEN '[41-50]'
			WHEN W.Age BETWEEN 51 AND 60 THEN '[51-60]'
			ELSE '[61+]'
		END AgeGroup
	FROM WizzardDeposits W 
	) T
GROUP BY T.AgeGroup

SELECT DISTINCT SUBSTRING(W.FirstName, 1, 1) FirstLetter
FROM WizzardDeposits W
WHERE W.DepositGroup = 'Troll Chest'

SELECT W.DepositGroup, W.IsDepositExpired, AVG(W.DepositInterest)
FROM WizzardDeposits W
WHERE W.DepositStartDate > '1985-01-01'	
GROUP BY W.DepositGroup, W.IsDepositExpired
ORDER BY W.DepositGroup DESC, W.IsDepositExpired

SELECT E.DepartmentID, SUM(E.Salary) TotalSalary
FROM Employees E
GROUP BY E.DepartmentID
ORDER BY E.DepartmentID

SELECT E.DepartmentID, MIN(E.Salary) MinimumSalary
FROM Employees E
WHERE E.DepartmentID IN (2, 5, 7) AND E.HireDate > '2000-01-01'
GROUP BY E.DepartmentID

SELECT E.DepartmentID, MAX(E.Salary) MaxSalary
FROM Employees E
GROUP BY E.DepartmentID
HAVING MAX(E.Salary) NOT BETWEEN 30000 AND 70000

SELECT COUNT(*)
FROM Employees E
WHERE E.ManagerID IS NULL

SELECT E.DepartmentID, MAX(E.Salary) MaxSalary
FROM Employees E
GROUP BY E.DepartmentID
ORDER BY 2 DESC
OFFSET 2 ROWS
FETCH NEXT 1 ROWS ONLY

SELECT TOP 10 E.FirstName, E.LastName, E.DepartmentID
FROM Employees E
WHERE E.Salary > (SELECT AVG(S.Salary) FROM Employees S WHERE E.DepartmentID = S.DepartmentID)
ORDER BY E.DepartmentID