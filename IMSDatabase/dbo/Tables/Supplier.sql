﻿CREATE TABLE [dbo].[Supplier]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(500) NOT NULL, 
    [Description] NVARCHAR(2000) NOT NULL, 
    [PhoneNumber] NVARCHAR(20) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [SupplierStateId] INT NOT NULL, 
    CONSTRAINT [FK_Supplier_SupplierState] FOREIGN KEY ([SupplierStateId]) REFERENCES SupplierState(Id)
)
