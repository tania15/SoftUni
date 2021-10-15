SELECT CONCAT(M.FirstName, ' ', M.LastName) Mechanic, J.[Status], J.IssueDate
FROM Mechanics M
	JOIN Jobs J ON M.MechanicId = J.MechanicId
ORDER BY M.MechanicId, J.IssueDate, J.JobId

SELECT CONCAT(C.FirstName, ' ', C.LastName) Client, DATEDIFF(DAY, J.IssueDate, '2017-04-24') [Days going], J.[Status]
FROM Clients C
	JOIN Jobs J ON C.ClientId = J.ClientId
WHERE J.[Status] != 'Finished'
ORDER BY 2 DESC, 1 

SELECT R.Mechanic, R.[Average Days]
FROM
	(
	SELECT M.MechanicId, CONCAT(M.FirstName, ' ', M.LastName) Mechanic, AVG(T.[Days]) [Average Days]
	FROM
		(
		SELECT J.MechanicId, DATEDIFF(DAY, J.IssueDate, J.FinishDate) [Days]
		FROM Jobs J
		WHERE J.[Status] = 'Finished'
		) T
		JOIN Mechanics M ON M.MechanicId = T.MechanicId
	GROUP BY M.MechanicId, CONCAT(M.FirstName, ' ', M.LastName)
	) R
ORDER BY R.MechanicId

SELECT CONCAT(M.FirstName, ' ', M.LastName) Available
FROM Mechanics M
WHERE M.MechanicId NOT IN
	(
	SELECT J.MechanicId
	FROM Jobs J
	WHERE J.Status = 'In Progress'
	)
ORDER BY M.MechanicId

SELECT J.JobId, SUM(P.Price * PN.Quantity) Total
FROM Jobs J
	JOIN PartsNeeded PN ON J.JobId = PN.JobId
	JOIN Parts P ON P.PartId = PN.PartId
WHERE J.[Status] = 'Finished'
GROUP BY J.JobId
ORDER BY 2 DESC, J.JobId

SELECT T.PartId, T.[Description], T.[Required], T.[In Stock], T.Ordered
FROM
	(
	SELECT P.PartId, P.[Description], P.StockQty [In Stock], PN.Quantity [Required], COALESCE(OP.Quantity, 0) Ordered
	FROM Parts P
		JOIN PartsNeeded PN ON P.PartId = PN.PartId
		JOIN Jobs J ON J.JobId = PN.JobId AND J.[Status] != 'Finished'
		LEFT JOIN OrderParts OP ON OP.PartId = P.PartId
		LEFT JOIN Orders O ON O.JobId = J.JobId AND (O.Delivered = 0 OR O.Delivered IS NULL)
	) T
WHERE T.[Required] > T.[In Stock] + T.Ordered
ORDER BY T.PartId

 
