CREATE TABLE [dbo].[Users]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [EmailID] VARCHAR(254) NOT NULL, 
    [DateOfBirth] DATETIME NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [IsEmailVerified] bit NOT NULL, 
    [ActivationCode] UNIQUEIDENTIFIER NOT NULL
)
