INSERT INTO Teachers
VALUES 
('Ruthanne', 'Bamb', '84948 Mesta Junction', '3105500146', 6), 
('Gerrard', 'Lowin', '370 Talisman Plaz', '3324874824', 2), 
('Merrile', 'Lambdin', '81 Dahle Plaza', '4373065154', 5), 
('Bert', 'Ivie', '2 Gateway Circle', '4409584510', 4);

INSERT INTO Subjects 
VALUES 
('Geometry', 12),
('Health', 10),
('Drama', 7),
('Sports', 9);

UPDATE StudentsSubjects
SET Grade = 6
WHERE Grade >= 5.5;

DELETE FROM StudentsTeachers
WHERE TeacherId IN (SELECT T.Id FROM Teachers T WHERE T.Phone LIKE '%72%');

DELETE FROM Teachers
WHERE Phone LIKE '%72%';