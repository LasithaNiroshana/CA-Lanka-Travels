CREATE TABLE [dbo].[vehicle]
(
	[Vehicle No.] CHAR(10) NOT NULL PRIMARY KEY, 
    [Type] VARCHAR(20) NOT NULL, 
    [Owner Name] VARCHAR(25) NOT NULL, 
    [Owner NIC] CHAR(15) NOT NULL, 
    [Condition] VARCHAR(10) NULL
)
