CREATE OR ALTER FUNCTION ufn_IsWordComprised
(
	@SetOfLetters VARCHAR(30), 
	@Word VARCHAR(30)
)
RETURNS BIT
AS
BEGIN
	--DECLARE @Result BIT = 1;
	DECLARE @Count TINYINT = 1;
	DECLARE @Symbol CHAR(1);

	WHILE @Count <= LEN(@Word)
	BEGIN
		SET @Symbol = SUBSTRING(@Word, @Count, 1);

		IF CHARINDEX(@Symbol, @SetOfLetters, 1) = 0
		BEGIN
			RETURN 0;
		END

		SET @Count += 1;
	END

	RETURN 1;
END

SELECT dbo.ufn_IsWordComprised('abcdefgh', 'ab');