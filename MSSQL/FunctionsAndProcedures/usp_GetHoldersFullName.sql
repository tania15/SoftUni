CREATE OR ALTER PROCEDURE usp_GetHoldersFullName
AS
BEGIN
	--SELECT CONCAT_WS(' ', A.FirstName, A.LastName) [Full Name]
	--FROM AccountHolders A;

	SELECT CONCAT(A.FirstName, ' ', A.LastName) [Full Name]
	FROM AccountHolders A;
END

EXEC usp_GetHoldersFullName;