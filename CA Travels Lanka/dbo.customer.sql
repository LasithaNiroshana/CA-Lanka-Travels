CREATE TABLE [dbo].[Customer]
(
	[Customer ID] INT NOT NULL PRIMARY KEY, 
    [Customer Name] NCHAR(10) NOT NULL, 
    [NIC] NCHAR(10) NOT NULL, 
    [Address] NCHAR(10) NULL, 
    [Phone No.] NCHAR(10) NOT NULL, 
    [Email] NCHAR(10) NULL
)
