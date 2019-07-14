CREATE TABLE [dbo].[customer payment]
(
	[Payment No.] INT NOT NULL PRIMARY KEY, 
    [Payment made date] DATE NOT NULL, 
    [Customer Name] VARCHAR(25) NOT NULL, 
    [Customer NIC] CHAR(15) NOT NULL, 
    [Package Type] VARCHAR(20) NOT NULL, 
    [Damages] MONEY NULL, 
    [Total Amount] MONEY NOT NULL, 
    [Paid Amount] MONEY NOT NULL, 
    [Balane] MONEY NOT NULL
)
