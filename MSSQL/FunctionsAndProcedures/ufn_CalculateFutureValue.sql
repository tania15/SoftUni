CREATE OR ALTER FUNCTION ufn_CalculateFutureValue
(
	@Sum DECIMAL(18, 2),
	@YearlyInterestRate FLOAT,
	@Years INT 
)
RETURNS DECIMAL(18, 4)
AS
BEGIN
	DECLARE @Count TINYINT = 1;
	DECLARE @Result DECIMAL(18, 4) = @Sum;

	WHILE @Count <= @Years
	BEGIN 
		SET @Result = @Result * (100 + @YearlyInterestRate) / 100;
		SET @Count += 1;
	END

	RETURN ROUND(@Result, 4);
END