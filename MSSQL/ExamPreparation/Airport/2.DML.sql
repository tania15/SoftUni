INSERT INTO Planes
VALUES
('Airbus 336', 112,	5132),
('Airbus 330', 432,	5325),
('Boeing 369', 231, 2355),
('Stelt 297', 254, 2143),
('Boeing 338', 165, 5111),
('Airbus 558', 387, 1342),
('Boeing 128', 345, 5541);

INSERT INTO LuggageTypes
VALUES
('Crossbody Bag'),
('School Backpack'),
('Shoulder Bag');

UPDATE Tickets
SET Price = PRICE * 1.13
WHERE FlightId = (SELECT F.Id FROM Flights F WHERE F.Destination = 'Carlsbad');

DELETE FROM Tickets
WHERE FlightId = (SELECT F.Id FROM Flights F WHERE F.Destination = 'Ayn Halagim');

DELETE FROM Flights
WHERE Destination = 'Ayn Halagim';