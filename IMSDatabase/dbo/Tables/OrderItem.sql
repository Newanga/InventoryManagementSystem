CREATE TABLE [dbo].[OrderItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantiy] INT NOT NULL, 
    [Price] MONEY NOT NULL, 
    CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY (ProductId) REFERENCES Product(Id), 
    CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY (OrderId) REFERENCES Orders(Id)
)
