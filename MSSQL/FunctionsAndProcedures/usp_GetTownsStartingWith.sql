CREATE OR ALTER PROCEDURE usp_GetTownsStartingWith
(
	@StartingString VARCHAR(10)
)
AS
BEGIN 
	SELECT T.[Name] Town
	FROM Towns T
	WHERE T.[Name] LIKE (@StartingString + '%');
END

EXEC usp_GetTownsStartingWith 'B';