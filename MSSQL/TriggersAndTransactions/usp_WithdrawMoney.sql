CREATE OR ALTER PROCEDURE usp_WithdrawMoney 
(
	@AccountId INT, 
	@MoneyAmount MONEY
)
AS
BEGIN TRANSACTION
	IF @MoneyAmount < 0
	BEGIN
		ROLLBACK;
		RAISERROR('Amount can not be negative!', 16, 1);
		RETURN;
	END

	IF @AccountId IS NULL
	BEGIN
		ROLLBACK;
		RAISERROR('Invalid account id!', 16, 1);
		RETURN;
	END

	UPDATE Accounts
	SET Balance -= ROUND(@MoneyAmount, 4)
	WHERE Id = @AccountId;
	
	COMMIT;


EXEC usp_WithdrawMoney 5, 25