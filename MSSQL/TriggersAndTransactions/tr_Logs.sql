CREATE TABLE NotificationEmails
(
	Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Recipient INT NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
	[Subject] VARCHAR(100) NOT NULL,
	Body VARCHAR(100) NOT NULL
)

GO

CREATE OR ALTER TRIGGER tr_Logs
ON Logs FOR INSERT
AS
BEGIN
	INSERT INTO NotificationEmails
	SELECT I.AccountId, 'Balance change for account: ' + CAST(I.AccountId AS VARCHAR(10)), 
		'On ' + CAST(GETDATE() AS VARCHAR(50)) + 'your balance was changed from ' + CAST(I.OldSum AS VARCHAR(10)) + 'to ' + CAST(I.NewSum AS VARCHAR(10))
	FROM inserted I;
END