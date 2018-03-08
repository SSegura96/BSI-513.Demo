CREATE TABLE [dbo].[ProductSubcategory]
(
	[ProductSubcategoryID] INT NOT NULL PRIMARY KEY, 
    [ProductCategoryID] INT NULL,
    [Name] NVARCHAR(50) NULL, 
    [rowguid] UNIQUEIDENTIFIER NULL DEFAULT NEWID(), 
    [ModifiedDate] DATETIME NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_ProductSubcategory_ProductCategory_ProductCategoryID] FOREIGN KEY ([ProductCategoryID]) REFERENCES [ProductCategory] ([ProductCategoryID])
)
