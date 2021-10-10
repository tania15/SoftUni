CREATE OR ALTER FUNCTION ufn_GetSalaryLevel
(
	@Salary DECIMAL(18,4)
)
RETURNS VARCHAR(10)
AS 
BEGIN
	DECLARE @Result VARCHAR(10);

	IF @Salary < 30000
	BEGIN
		SET @Result = 'Low';
	END
	ELSE IF @Salary >= 30000 AND @Salary <= 50000
	BEGIN
		SET @Result = 'Average';
	END
	ELSE
		SET @Result = 'High';

	RETURN @Result;
END

SELECT E.FirstName, E.LastName, E.Salary, dbo.ufn_GetSalaryLevel(E.Salary)
FROM Employees E