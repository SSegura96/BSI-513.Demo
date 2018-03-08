CREATE TABLE [dbo].[ProductCategory]
(
	[ProductCategoryID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [rowguid] UNIQUEIDENTIFIER NULL DEFAULT NEWID(), 
    [ModifiedDate] DATETIME NULL DEFAULT GETDATE()
)
