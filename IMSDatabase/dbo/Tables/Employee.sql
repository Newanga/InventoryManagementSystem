CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [JoinedDate] DATE NOT NULL, 
    [AccountId] INT NOT NULL, 
    CONSTRAINT [FK_Employee_Account] FOREIGN KEY (AccountId) REFERENCES [Account](Id)
)
