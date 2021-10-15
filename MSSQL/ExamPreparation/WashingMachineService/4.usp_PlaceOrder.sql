CREATE OR ALTER PROCEDURE usp_PlaceOrder
(
	@JobID INT,
	@PartSerialNumber VARCHAR(50),
	@Quantity INT
)
AS
BEGIN TRANSACTION
	--DECLARE @CountOrder SMALLINT = (SELECT COUNT(*) FROM Orders O WHERE O.JobId = @JobID);
	IF EXISTS(SELECT J.JobId FROM Jobs J WHERE J.JobId = @JobID AND J.[Status] = 'Finished') 
	BEGIN 
		ROLLBACK;
		RAISERROR('This job is not active!', 50011, 1);
		RETURN;
	END

	IF @Quantity <= 0
	BEGIN 
		ROLLBACK;
		RAISERROR('Part quantity must be more than zero!', 50012, 1);
		RETURN;
	END

	IF EXISTS(SELECT J.JobId FROM Jobs J WHERE J.JobId = @JobID)
	BEGIN
		ROLLBACK;
		RAISERROR('Job not found!', 50013, 1);
		RETURN;
	END
	
	IF EXISTS(SELECT P.PartId FROM Parts P WHERE P.SerialNumber = @PartSerialNumber)
	BEGIN
		ROLLBACK;
		RAISERROR('Part not found!', 50014, 1);
		RETURN;
	END

	IF NOT EXISTS(SELECT O.OrderId FROM Orders O WHERE O.JobId = @JobID AND O.IssueDate IS NULL)
	BEGIN
		DECLARE @Part INT = (SELECT P.PartId FROM Parts P WHERE P.SerialNumber = @PartSerialNumber);
		DECLARE @Order INT = (SELECT O.OrderId FROM Orders O WHERE O.JobId = @JobID);

		IF EXISTS(SELECT OP.PartId FROM OrderParts OP WHERE OP.PartId = @Part AND OP.OrderId = @Order)
		BEGIN
			UPDATE OrderParts 
			SET Quantity += 1
			WHERE OrderId = @Order AND PartId = @Part;
		END
		ELSE
		BEGIN
			INSERT INTO OrderParts
			VALUES(@Order, @Part, @Quantity);
		END
	END
	ELSE
	BEGIN
		INSERT INTO Orders(JobId, IssueDate)
		VALUES(@JobID, NULL);

		INSERT INTO OrderParts
		VALUES (@Order, @Part, @Quantity);
	END

	COMMIT;
	