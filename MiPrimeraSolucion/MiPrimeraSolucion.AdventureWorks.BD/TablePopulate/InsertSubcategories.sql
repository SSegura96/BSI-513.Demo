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
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (1, 1, N'Mountain Bikes', N'2d364ade-264a-433c-b092-4fcbf3804e01', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (2, 1, N'Road Bikes', N'000310c0-bcc8-42c4-b0c3-45ae611af06b', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (3, 1, N'Touring Bikes', N'02c5061d-ecdc-4274-b5f1-e91d76bc3f37', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (4, 2, N'Handlebars', N'3ef2c725-7135-4c85-9ae6-ae9a3bdd9283', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (5, 2, N'Bottom Brackets', N'a9e54089-8a1e-4cf5-8646-e3801f685934', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (6, 2, N'Brakes', N'd43ba4a3-ef0d-426b-90eb-4be4547dd30c', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (7, 2, N'Chains', N'e93a7231-f16c-4b0f-8c41-c73fdec62da0', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (8, 2, N'Cranksets', N'4f644521-422b-4f19-974a-e3df6102567e', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (9, 2, N'Derailleurs', N'1830d70c-aa2a-40c0-a271-5ba86f38f8bf', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (10, 2, N'Forks', N'b5f9ba42-b69b-4fdd-b2ec-57fb7b42e3cf', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (11, 2, N'Headsets', N'7c782bbe-5a16-495a-aa50-10afe5a84af2', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (12, 2, N'Mountain Frames', N'61b21b65-e16a-4be7-9300-4d8e9db861be', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (13, 2, N'Pedals', N'6d24ac07-7a84-4849-864a-865a14125bc9', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (14, 2, N'Road Frames', N'5515f857-075b-4f9a-87b7-43b4997077b3', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (15, 2, N'Saddles', N'049fffa3-9d30-46df-82f7-f20730ec02b3', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (16, 2, N'Touring Frames', N'd2e3f1a8-56c4-4f36-b29d-5659fc0d2789', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (17, 2, N'Wheels', N'43521287-4b0b-438e-b80e-d82d9ad7c9f0', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (18, 3, N'Bib-Shorts', N'67b58d2b-5798-4a90-8c6c-5ddacf057171', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (19, 3, N'Caps', N'430dd6a8-a755-4b23-bb05-52520107da5f', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (20, 3, N'Gloves', N'92d5657b-0032-4e49-bad5-41a441a70942', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (21, 3, N'Jerseys', N'09e91437-ba4f-4b1a-8215-74184fd95db8', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (22, 3, N'Shorts', N'1a5ba5b3-03c3-457c-b11e-4fa85ede87da', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (23, 3, N'Socks', N'701019c3-09fe-4949-8386-c6ce686474e5', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (24, 3, N'Tights', N'5deb3e55-9897-4416-b18a-515e970bc2d1', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (25, 3, N'Vests', N'9ad7fe93-5ba0-4736-b578-ff80a2071297', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (26, 4, N'Bike Racks', N'4624b5ce-66d6-496b-9201-c053df3556cc', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (27, 4, N'Bike Stands', N'43b445c8-b820-424e-a1d5-90d81da0b46f', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (28, 4, N'Bottles and Cages', N'9b7dff41-9fa3-4776-8def-2c9a48c8b779', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (29, 4, N'Cleaners', N'9ad3bcf0-244d-4ec4-a6a0-fb701351c6a3', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (30, 4, N'Fenders', N'1697f8a2-0a08-4883-b7dd-d19117b4e9a7', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (31, 4, N'Helmets', N'f5e07a33-c9e0-439c-b5f3-9f25fb65becc', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (32, 4, N'Hydration Packs', N'646a8906-fc87-4267-a443-9c6d791e6693', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (33, 4, N'Lights', N'954178ba-624f-42db-95f6-ca035f36d130', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (34, 4, N'Locks', N'19646983-3fa0-4773-9a0c-f34c49df9bc8', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (35, 4, N'Panniers', N'3002a5d5-fec3-464b-bef3-e0f81d35f431', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (36, 4, N'Pumps', N'fe4d46f2-c87c-48c5-a4a1-3f55712d80b1', CAST(N'2008-04-30T00:00:00.000' AS DateTime))
INSERT [ProductSubcategory] ([ProductSubcategoryID], [ProductCategoryID], [Name], [rowguid], [ModifiedDate]) VALUES (37, 4, N'Tires and Tubes', N'3c17c9ae-e906-48b4-bdd3-60e28d47dcdf', CAST(N'2008-04-30T00:00:00.000' AS DateTime))