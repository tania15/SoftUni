CREATE OR ALTER PROCEDURE usp_CalculateFutureValueForAccount
(
	@AccountId INT,
	@InterestRate FLOAT
)
AS
BEGIN
	SELECT A.Id [Account Id], AH.FirstName [First Name], AH.LastName [Last Name], 
		A.Balance [Current Balance], dbo.ufn_CalculateFutureValue(A.Balance, @InterestRate, 5) [Balance in 5 years]
	FROM AccountHolders AH
		JOIN Accounts A ON AH.Id = A.AccountHolderId
	WHERE
		A.Id = @AccountId;
END

EXEC usp_CalculateFutureValueForAccount 1, 10;