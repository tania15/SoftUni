SELECT C.CigarName, C.PriceForSingleCigar, C.ImageURL
FROM Cigars C
ORDER BY C.PriceForSingleCigar, C.CigarName DESC

SELECT C.Id, C.CigarName, C.PriceForSingleCigar, T.TasteType, T.TasteStrength
FROM Cigars C
	JOIN Tastes T ON T.Id = C.TastId
WHERE T.TasteType = 'Earthy' OR T.TasteType = 'Woody'
ORDER BY C.PriceForSingleCigar DESC

SELECT C.Id, CONCAT(C.FirstName, ' ', C.LastName) ClientName, C.Email
FROM Clients C
WHERE C.Id NOT IN 
	(
	SELECT DISTINCT C.ClientId
	FROM ClientsCigars C
	)
ORDER BY 2

SELECT TOP(5) C.CigarName, C.PriceForSingleCigar, C.ImageURL
FROM Cigars C
	JOIN Sizes S ON C.SizeId = S.Id
WHERE S.[Length] > 12 AND (C.CigarName LIKE '%ci%' OR C.PriceForSingleCigar > 50) AND S.RingRange > 2.55
ORDER BY C.CigarName, 2 DESC

SELECT CONCAT(C.FirstName, ' ', C.LastName) FullName, A.Country, A.ZIP, '$' + CAST(MAX(CI.PriceForSingleCigar) AS VARCHAR(10)) CigarPrice
FROM Clients C
	JOIN Addresses A ON C.AddressId = A.Id
	LEFT JOIN ClientsCigars CC ON CC.ClientId = C.Id
	 LEFT JOIN Cigars CI ON CI.ID = CC.CigarId
WHERE A.Id NOT IN
(SELECT A.Id
FROM Addresses A
WHERE CHARINDEX('A', A.ZIP) > 0 OR CHARINDEX('B', A.ZIP) > 0 OR CHARINDEX('C', A.ZIP) > 0 OR CHARINDEX('D', A.ZIP) > 0 OR CHARINDEX('E', A.ZIP) > 0
	OR CHARINDEX('F', A.ZIP) > 0 OR CHARINDEX('G', A.ZIP) > 0 OR CHARINDEX('H', A.ZIP) > 0 OR CHARINDEX('I', A.ZIP) > 0 OR CHARINDEX('J', A.ZIP) > 0 
	OR CHARINDEX('K', A.ZIP) > 0 OR CHARINDEX('L', A.ZIP) > 0 OR CHARINDEX('M', A.ZIP) > 0 OR CHARINDEX('N', A.ZIP) > 0 OR CHARINDEX('O', A.ZIP) > 0
	OR CHARINDEX('P', A.ZIP) > 0 OR CHARINDEX('Q', A.ZIP) > 0 OR CHARINDEX('R', A.ZIP) > 0 OR CHARINDEX('S', A.ZIP) > 0 OR CHARINDEX('T', A.ZIP) > 0
	OR CHARINDEX('U', A.ZIP) > 0 OR CHARINDEX('V', A.ZIP) > 0 OR CHARINDEX('W', A.ZIP) > 0 OR CHARINDEX('X', A.ZIP) > 0
	OR CHARINDEX('Y', A.ZIP) > 0 OR CHARINDEX('Z', A.ZIP) > 0)
GROUP BY C.FirstName, C.LastName, A.Country, A.ZIP
ORDER BY 1

SELECT C.LastName, AVG(S.[Length]) CigarLength, FLOOR(S.RingRange) CigarRingRange
FROM Clients C
	JOIN ClientsCigars CC ON C.Id = CC.ClientId
	JOIN Cigars CI ON CC.CigarId = CI.Id
	JOIN Sizes S ON S.Id = CI.SizeId
GROUP BY C.LastName, S.RingRange
ORDER BY 2 DESC

SELECT C.LastName, AVG(S.[Length]) CigarLength, CEILING(AVG(S.RingRange)) CigarRingRange
FROM ClientsCigars CC 
	JOIN Cigars CI ON CC.CigarId = CI.Id
	JOIN Sizes S ON S.Id = CI.SizeId
	JOIN Clients C ON C.Id = CC.ClientId
GROUP BY C.LastName
ORDER BY 2 DESC

