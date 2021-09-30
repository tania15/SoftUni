SELECT TOP(50) G.[Name], FORMAT(G.[Start], 'yyyy-MM-dd') [Start]
FROM Games G
WHERE YEAR(G.[Start]) IN (2011, 2012)
ORDER BY G.[Start], G.[Name]

SELECT U.Username, SUBSTRING(U.Email, 1 + CHARINDEX('@', U.Email), LEN(U.Email) - CHARINDEX('@', U.Email)) [Email Provider]
FROM Users U
WHERE U.Email IS NOT NULL
ORDER BY 2, 1

SELECT U.Username, U.IpAddress [IP Address]
FROM Users U
WHERE U.IpAddress LIKE '___.1%.%.___'
order by u.Username

SELECT G.[Name],
	CASE 
		WHEN DATEPART(HOUR, Start) >= 0 AND DATEPART(HOUR, Start) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR, Start) >= 12 AND DATEPART(HOUR, Start) < 18 THEN 'Afternoon'
		ELSE 'Evening'
	END [Part of the Day],
	CASE 
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration > 3 AND Duration <= 6 THEN 'Short'
		WHEN Duration > 6 THEN 'Long'
		ELSE 'Extra Long'
	END [Duration]
FROM Games G
ORDER BY G.[Name], G.Duration