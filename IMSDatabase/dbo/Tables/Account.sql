CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [AccountStateId] INT NOT NULL, 
    [RoleId] INT NOT NULL, 
    CONSTRAINT [FK_Account_AccountState] FOREIGN KEY (AccountStateId) REFERENCES AccountState(Id), 
    CONSTRAINT [FK_Account_Role] FOREIGN KEY (RoleId) REFERENCES Roles(Id)
)
