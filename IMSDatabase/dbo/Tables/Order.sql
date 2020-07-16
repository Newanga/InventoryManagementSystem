CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PlacedDate] DATE NOT NULL, 
    [DelieveredDate] DATE NULL DEFAULT null, 
    [SpecialNotes] NVARCHAR(2000) NOT NULL DEFAULT null, 
    [OrderStateId] INT NOT NULL
)
