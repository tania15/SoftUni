CREATE OR ALTER PROCEDURE usp_AssignProject
(
	@EmloyeeId INT,
	@ProjectID INT
)
AS 
BEGIN TRANSACTION
	IF NOT EXISTS(SELECT * FROM Employees E WHERE E.EmployeeID = @EmloyeeId)
	BEGIN
		ROLLBACK;
		RAISERROR('Invalid Emloyee id!', 16, 1);
		RETURN;
	END

	IF NOT EXISTS(SELECT * FROM Projects P WHERE P.ProjectID = @ProjectID)
	BEGIN
		ROLLBACK;
		RAISERROR('Invalid Project id!', 16, 1);
		RETURN;
	END

	DECLARE @Count INT = (
		SELECT COUNT(*)
		FROM EmployeesProjects E
		WHERE E.EmployeeID = @EmloyeeId
		);

	IF @Count >= 3
	BEGIN
		ROLLBACK;
		RAISERROR('The employee has too many projects!', 16, 1);
		RETURN;
	END

	INSERT INTO EmployeesProjects
	VALUES (@EmloyeeId, @ProjectID);

	COMMIT;