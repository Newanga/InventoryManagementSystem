CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(250) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Warrenty] INT NOT NULL, 
    [SupplierId] INT NOT NULL, 
    [CategoryId] INT NOT NULL, 
    [ProductStateId] INT NOT NULL, 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY (CategoryId) REFERENCES Category(Id), 
    CONSTRAINT [FK_Product_ProductStateId] FOREIGN KEY ([ProductStateId]) REFERENCES ProductState(Id), 
    CONSTRAINT [FK_Product_Supplier] FOREIGN KEY (SupplierId) REFERENCES Supplier(Id) 
)
