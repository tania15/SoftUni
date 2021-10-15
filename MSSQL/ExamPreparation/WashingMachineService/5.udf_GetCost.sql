CREATE OR ALTER FUNCTION udf_GetCost
(
	@JobId INT
)
RETURNS DECIMAL(8, 2)
AS
RETURN
(
	SELECT PN.PartId, COALESCE(PN.Quantity * P.Price, 0) Result
	FROM PartsNeeded PN 
		JOIN Parts P ON P.PartId = PN.PartId
	WHERE PN.JobId = @JobId
)


SELECT *
FROM dbo.udf_GetCost(2)

