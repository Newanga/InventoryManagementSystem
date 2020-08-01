CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [OrderItemId] INT NOT NULL, 
    [DateAdded] DATE NOT NULL
)
