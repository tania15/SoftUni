CREATE OR ALTER PROCEDURE usp_GetHoldersWithBalanceHigherThan
(
	@Amount INT
)
AS 
BEGIN 
	SELECT AH.FirstName [First Name], AH.LastName [Last Name]
	FROM 
		Accounts A
		JOIN AccountHolders AH ON A.AccountHolderId = AH.Id
	--WHERE A.Balance > @Amount
	GROUP BY AH.FirstName, AH.LastName
	HAVING SUM(A.Balance) > @Amount
	ORDER BY AH.FirstName, AH.LastName;
END

EXEC usp_GetHoldersWithBalanceHigherThan 5000;