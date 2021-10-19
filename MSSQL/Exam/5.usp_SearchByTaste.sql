CREATE PROC usp_SearchByTaste
(
	@Taste VARCHAR(20)
)
AS
BEGIN
	SELECT C.CigarName, '$' + CAST(C.PriceForSingleCigar AS VARCHAR(10)) Price, T.TasteType, 
		B.BrandName, CAST(S.[Length] AS VARCHAR(10))  + ' cm' CigarLength, CAST(S.RingRange AS VARCHAR(10))  + ' cm'  CigarRingRange
	FROM Cigars C
		JOIN Tastes T ON C.TastId = T.Id
		JOIN Brands B ON B.Id = C.BrandId
		JOIN Sizes S ON C.SizeId = S.Id
	WHERE T.TasteType = @Taste
	ORDER BY 5, 6 DESC;
END

EXEC usp_SearchByTaste 'Woody';