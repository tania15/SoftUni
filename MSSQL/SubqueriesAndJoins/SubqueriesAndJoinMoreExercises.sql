SELECT MC.CountryCode, M.MountainRange, P.PeakName, P.Elevation
FROM Peaks P
	JOIN Mountains M ON P.MountainId = M.Id
	JOIN MountainsCountries MC ON MC.MountainId = P.MountainId
WHERE MC.CountryCode = 'BG' AND P.Elevation > 2835 
ORDER BY P.Elevation DESC

SELECT MC.CountryCode, COUNT(MC.CountryCode) MountainRanges
FROM Mountains M 
	JOIN MountainsCountries MC ON MC.MountainId = M.Id
WHERE MC.CountryCode IN ('BG', 'RU', 'US')
GROUP BY MC.CountryCode

SELECT TOP 5 C.CountryName, R.RiverName
FROM Countries C
	LEFT JOIN CountriesRivers CR ON CR.CountryCode = C.CountryCode
	LEFT JOIN Rivers R ON R.Id = CR.RiverId
WHERE C.ContinentCode = 'AF'
ORDER BY C.CountryName

SELECT COUNT(*)
FROM Countries C 
	LEFT JOIN MountainsCountries MC ON C.CountryCode = MC.CountryCode
WHERE MC.CountryCode IS NULL

SELECT TOP 5 C.CountryName, MAX(P.Elevation) HighestPeakElevation, MAX(R.Length)
FROM Countries C
	LEFT JOIN MountainsCountries MC ON C.CountryCode = MC.CountryCode
	JOIN Peaks P ON P.MountainId = MC.MountainId
	LEFT JOIN CountriesRivers CR ON CR.CountryCode = C.CountryCode
	JOIN Rivers R ON R.Id = CR.RiverId
GROUP BY C.CountryName
ORDER BY 2 DESC, 3 DESC, 1