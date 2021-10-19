CREATE FUNCTION udf_ClientWithCigars
(
	@Name NVARCHAR(30)
) 
RETURNS INT
AS
BEGIN 
	DECLARE @ClientId INT = (SELECT C.Id FROM Clients C WHERE C.FirstName = @Name);

	DECLARE @Count INT = 
	(
	SELECT COUNT(*)
	FROM ClientsCigars CC
	WHERE CC.ClientId = @ClientId
	);

	RETURN @Count;
END