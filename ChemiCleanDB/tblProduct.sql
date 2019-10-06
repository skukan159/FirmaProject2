CREATE TABLE [dbo].[tblProduct]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductName] NVARCHAR(250) NOT NULL, 
    [SupplierName] NVARCHAR(250) NOT NULL, 
    [Url] NVARCHAR(300) NOT NULL, 
    [UserName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL
)
