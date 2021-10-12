CREATE OR ALTER PROCEDURE usp_TransferMoney
(
	@SenderId INT,
	@ReceiverId INT,
	@Amount MONEY
)
AS 
BEGIN TRANSACTION
	EXEC usp_WithdrawMoney @SenderId, @Amount;
	EXEC usp_DepositMoney @ReceiverId, @Amount;

	COMMIT;
