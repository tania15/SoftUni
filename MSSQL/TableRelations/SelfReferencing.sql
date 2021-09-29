CREATE TABLE Teachers
(
	TeacherId BIGINT NOT NULL PRIMARY KEY IDENTITY(101, 1),
	[Name] NVARCHAR(50) NOT NULL,
	ManagerID BIGINT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers
VALUES
('John', null),
('Maya', 106),
('Silvia', 106),
('Ted', 105),
('Mark', 101),
('Greta', 101)