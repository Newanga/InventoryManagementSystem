CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceDate] DATE NOT NULL, 
    [DeliveryDate] DATE NULL DEFAULT null, 
    [SpecialNotes] NVARCHAR(2000) NULL DEFAULT null, 
    [OrderStateId] INT NOT NULL, 
    [SupplierId] INT NOT NULL, 
    CONSTRAINT [FK_Order_OrderState] FOREIGN KEY (OrderStateId) REFERENCES OrderState(Id), 
    CONSTRAINT [FK_Orders_Supplier] FOREIGN KEY (SupplierId) REFERENCES Supplier(Id)
)