CREATE FUNCTION udf_CalculateTickets
(
	@Origin VARCHAR(30), 
	@Destination VARCHAR(30), 
	@PeopleCount SMALLINT
)
RETURNS VARCHAR(500)
AS
BEGIN
	IF @PeopleCount <= 0
	BEGIN
		RETURN 'Invalid people count!';
	END

	DECLARE @Flight INT = (SELECT F.Id FROM Flights F WHERE F.Origin = @Origin AND F.Destination = @Destination);

	IF @Flight IS NULL
	BEGIN
		RETURN 'Invalid flight!';
	END

	DECLARE @Price DECIMAL(10, 2) = 
		(
		SELECT TOP 1 T.Price 
		FROM Flights F 
			JOIN Tickets T ON T.FlightId = F.Id 
		WHERE F.Origin = @Origin AND F.Destination = @Destination
		);

	RETURN CONCAT('Total price ', CAST((@Price * @PeopleCount) AS VARCHAR(10)));
END

SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', 33)