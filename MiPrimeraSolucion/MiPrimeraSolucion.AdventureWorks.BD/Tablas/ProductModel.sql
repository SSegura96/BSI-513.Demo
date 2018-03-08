CREATE TABLE [dbo].[ProductModel]
(
	[ProductModelID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [CatalogDescription] XML NULL, 
    [Instructions] XML NULL,
	[rowguid] UNIQUEIDENTIFIER NULL DEFAULT NEWID(), 
    [ModifiedDate] DATETIME NULL DEFAULT GETDATE() 

)
