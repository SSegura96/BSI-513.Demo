CREATE TABLE [dbo].[Product]
(
	[ProductID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [ProductNumber] NVARCHAR(25) NULL, 
    [MakeFlag] BIT NULL DEFAULT 1 , 
    [FinishedGoodsFlag] BIT NULL DEFAULT 1, 
    [Color] NVARCHAR(25) NULL, 
    [SafetyStockLevel] SMALLINT NULL, 
    [ReorderPoint] SMALLINT NULL, 
    [StandardCost] MONEY NULL, 
    [ListPrice] MONEY NULL, 
    [Size] NVARCHAR(5) NULL, 
    [SizeUnitMeasureCode] NCHAR(3) NULL, 
    [WeightUnitMeasureCode] NCHAR(3) NULL, 
    [Weight] DECIMAL(8, 2) NULL, 
    [DaysToManufacture] INT NULL, 
    [ProductLine] NCHAR(2) NULL, 
    [Class] NCHAR(2) NULL, 
    [Style] NCHAR(2) NULL, 
    [ProductSubcategoryID] INT NULL, 
    [ProductModelID] INT NULL, 
    [SellStartDate] DATETIME NULL, 
    [SellEndDate] DATETIME NULL, 
    [DiscontinuedDate] DATETIME NULL,
	[rowguid] UNIQUEIDENTIFIER NULL DEFAULT NEWID(), 
    [ModifiedDate] DATETIME NULL DEFAULT GETDATE()
    CONSTRAINT [FK_Product_ProductModel_ProductModelID] FOREIGN KEY ([ProductModelID]) REFERENCES [ProductModel] ([ProductModelID]), 
    CONSTRAINT [FK_Product_ProductSubcategory_ProductSubcategoryID] FOREIGN KEY ([ProductSubcategoryID]) REFERENCES [ProductSubcategory] ([ProductSubcategoryID])

)
