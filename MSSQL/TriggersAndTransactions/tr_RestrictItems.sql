CREATE TRIGGER tr_RestrictItems
ON UserGameItems INSTEAD OF INSERT
AS
BEGIN
	DECLARE @ItemId INT = (SELECT I.ItemId FROM inserted I);
	DECLARE @UserGameId INT = (SELECT I.UserGameId FROM inserted I);

	DECLARE @ItemLevel INT = (SELECT i.MinLevel FROM Items I WHERE I.Id = @ItemId);
	DECLARE @UserGameLevel INT = (SELECT U.Level FROM UsersGames U WHERE U.Id = @UserGameId);

	IF @UserGameLevel >= @ItemLevel
	BEGIN
		INSERT INTO UserGameItems
		VALUES (@ItemId, @UserGameId);
	END
END