USE [Geography]

--SELECT P.PeakName
--FROM Peaks P
--ORDER BY P.PeakName

--SELECT TOP(30) C.CountryName, C.Population
--FROM Countries C
--WHERE C.ContinentCode = 'EU'
--ORDER BY C.Population DESC

SELECT C.CountryName, C.CountryCode, IIF(C.CurrencyCode = 'EUR', 'Euro', 'Not Euro') [Currency]
FROM Countries C
ORDER BY C.CountryName