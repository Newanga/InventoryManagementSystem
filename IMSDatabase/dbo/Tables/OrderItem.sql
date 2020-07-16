CREATE TABLE [dbo].[OrderItem]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OrderId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantiy] INT NOT NULL, 
    [Price] MONEY NOT NULL
)
