/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT [ProductCategory] ([ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (1, N'Bikes', N'cfbda25c-df71-47a7-b81b-64ee161aa37c', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductCategory] ([ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (2, N'Components', N'c657828d-d808-4aba-91a3-af2ce02300e9', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductCategory] ([ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (3, N'Clothing', N'10a7c342-ca82-48d4-8a38-46a2eb089b74', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductCategory] ([ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (4, N'Accessories', N'2be3be36-d9a2-4eee-b593-ed895d97c2a6', CAST(N'2008-04-30T00:00:00.000' AS DateTime))