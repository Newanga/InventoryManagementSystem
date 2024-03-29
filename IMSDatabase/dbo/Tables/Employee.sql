﻿CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [DateOfBirth] DATETIME NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [StartDate] DATETIME NOT NULL,
    [LeaveDate]  DATETIME NULL, 
    [AccountId] INT NOT NULL, 
    CONSTRAINT [FK_Employee_Account] FOREIGN KEY (AccountId) REFERENCES [Account](Id)
)
