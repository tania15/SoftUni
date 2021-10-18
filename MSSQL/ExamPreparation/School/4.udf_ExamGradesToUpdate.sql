CREATE FUNCTION udf_ExamGradesToUpdate
(
	@StudentId INT, 
	@Grade DECIMAL(3, 2)
)
RETURNS VARCHAR(300)
AS
BEGIN
	DECLARE @Student INT = (SELECT S.Id FROM Students S WHERE S.Id = @StudentId);

	IF @Student IS NULL
		RETURN 'The student with provided id does not exist in the school!';

	IF @Grade > 6
		RETURN 'Grade cannot be above 6.00!';

	DECLARE @FirstName NVARCHAR(30) = (SELECT S.FirstName FROM Students S WHERE S.Id = @StudentId);
	DECLARE @Count INT = 
		(SELECT COUNT(SE.Grade) FROM StudentsExams SE WHERE SE.StudentId = @StudentId AND SE.Grade >= @Grade AND SE.Grade <= @Grade + 0.50);

	RETURN 'You have to update ' + CAST(@Count AS VARCHAR(3)) + ' grades for the student ' + @FirstName;
END

SELECT dbo.udf_ExamGradesToUpdate(12, 6.20);

SELECT dbo.udf_ExamGradesToUpdate(12, 5.50);

SELECT dbo.udf_ExamGradesToUpdate(121, 5.50);