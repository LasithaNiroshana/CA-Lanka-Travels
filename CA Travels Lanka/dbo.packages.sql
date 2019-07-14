CREATE TABLE [dbo].[package]
(
	[Package ID] CHAR(10) NOT NULL PRIMARY KEY, 
    [Package Type] VARCHAR(20) NOT NULL, 
    [Rate] MONEY NOT NULL
)
