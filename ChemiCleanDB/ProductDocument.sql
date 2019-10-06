CREATE TABLE [dbo].[ProductDocument]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductId] INT NOT NULL, 
    [Document] XML NULL
)
