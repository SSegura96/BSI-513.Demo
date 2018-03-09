CREATE TABLE [dbo].[ProductReview]
(
	[ProductReviewID] INT NOT NULL PRIMARY KEY, 
    [ProductID] INT NULL, 
    [ReviewerName] NVARCHAR(50) NULL, 
    [ReviewDate] DATETIME NULL DEFAULT GETDATE(), 
    [EmailAddress] NVARCHAR(50) NULL, 
    [Rating] INT NULL, 
    [Comments] NVARCHAR(3850) NULL, 
    [ModifiedDate] DATETIME NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_ProductReview_Product_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Product] ([ProductID])
)
