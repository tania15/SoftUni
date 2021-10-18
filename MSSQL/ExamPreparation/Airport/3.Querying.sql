SELECT P.Id, P.[Name], P.Seats, P.[Range]
FROM Planes P
WHERE P.[Name] LIKE '%tr%'
ORDER BY P.Id, P.[Name], P.Seats, P.[Range]

SELECT T.FlightId, SUM(T.Price)
FROM Tickets T
GROUP BY T.FlightId
ORDER BY 2 DESC, 1

SELECT CONCAT(P.FirstName, ' ', P.LastName) [Full Name], F.Origin, F.Destination
FROM Passengers P
	JOIN Tickets T ON T.PassengerId = P.Id
	JOIN Flights F ON F.Id = T.FlightId
ORDER BY 1, 2, 3

SELECT P.FirstName [First Name], P.LastName [Last Name], P.Age
FROM Passengers P
	LEFT JOIN Tickets T ON P.Id = T.PassengerId
WHERE T.Id IS NULL
ORDER BY 3 DESC, 1, 2

SELECT CONCAT(P.FirstName, ' ', P.LastName) [Full Name], PL.[Name] [Plane Name], CONCAT(F.Origin, ' - ', F.Destination) Trip, LT.[Type]
FROM Passengers P
	JOIN Tickets T ON P.Id = T.PassengerId
	JOIN Flights F ON F.Id = T.FlightId
	JOIN Planes PL ON PL.Id = F.PlaneId 
	LEFT JOIN Luggages L ON L.PassengerId = P.Id
	LEFT JOIN LuggageTypes LT ON LT.Id = L.LuggageTypeId	
ORDER BY 1, 2, F.Origin, F.Destination, LT.[Type]

SELECT CONCAT(P.FirstName, ' ', P.LastName) [Full Name], PL.[Name] [Plane Name], CONCAT(F.Origin, ' - ', F.Destination) Trip, LT.[Type]
FROM Tickets T
	JOIN Passengers P ON T.PassengerId = P.Id
	JOIN Flights F ON F.Id = T.FlightId
	JOIN Planes PL ON PL.Id = F.PlaneId
	JOIN Luggages L ON L.Id = T.LuggageId
	JOIN LuggageTypes LT ON LT.Id = L.LuggageTypeId	
ORDER BY 1, 2, F.Origin, F.Destination, LT.[Type]

SELECT P.[Name], P.Seats, COUNT(T.Id) [Passengers Count]
FROM Planes P 
	LEFT JOIN Flights F ON P.Id = F.PlaneId
	LEFT JOIN Tickets T ON F.Id = T.FlightId
GROUP BY P.[Name], P.Seats
ORDER BY 3 DESC, 1, 2

