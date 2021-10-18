SELECT S.FirstName, S.LastName, S.Age
FROM Students S
WHERE S.Age >= 12
ORDER BY S.FirstName, S.LastName

SELECT S.FirstName, S.LastName, COUNT(*) TeachersCount
FROM StudentsTeachers ST
	JOIN Students S ON ST.StudentId = S.Id
GROUP BY S.FirstName, S.LastName

SELECT CONCAT(S.FirstName, ' ', S.LastName) [Full Name]
FROM Students S
WHERE S.ID NOT IN 
	(
	SELECT DISTINCT SE.StudentId
	FROM StudentsExams SE
	)
ORDER BY 1

SELECT TOP 10 S.FirstName [First Name], S.LastName [Last Name], FORMAT(T.Grade, 'N2') Grade
FROM Students S
	JOIN
	(
	SELECT SE.StudentId, AVG(SE.Grade) Grade
	FROM StudentsExams SE
	GROUP BY SE.StudentId
	) T ON S.Id = T.StudentId
ORDER BY 3 DESC, 1, 2

SELECT CONCAT_WS(' ', S.FirstName, S.MiddleName, S.LastName) [Full Name]
--CONCAT(S.FirstName, ' ', COALESCE(S.MiddleName,), S.LastName) [Full Name]
FROM Students S
WHERE S.Id NOT IN 
	(
	SELECT DISTINCT SS.StudentId
	FROM StudentsSubjects SS
	)
ORDER BY 1

SELECT S.[Name], T.AverageGrade
FROM Subjects S
	JOIN 
	(
	SELECT SS.SubjectId, AVG(SS.Grade) AverageGrade
	FROM StudentsSubjects SS
	GROUP BY SS.SubjectId
	) T ON S.Id = T.SubjectId
ORDER BY S.Id