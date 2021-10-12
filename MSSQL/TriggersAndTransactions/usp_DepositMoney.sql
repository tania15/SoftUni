CREATE OR ALTER PROCEDURE usp_DepositMoney
(
	@AccountId INT, 
	@MoneyAmount MONEY
)
AS
BEGIN TRANSACTION
	IF @MoneyAmount < 0
	BEGIN
		ROLLBACK;
		RAISERROR('Negative amount!', 16, 1);
		RETURN;
	END

	DECLARE @Account INT = (SELECT A.Id FROM Accounts A WHERE A.Id = @AccountId);

	IF @Account IS NULL
	BEGIN
		ROLLBACK;
		RAISERROR('Invalid accoint id!', 16, 1);
		RETURN;
	END

	UPDATE Accounts
	SET Balance += Round(@MoneyAmount, 4)
	WHERE Id = @AccountId;

	COMMIT;
