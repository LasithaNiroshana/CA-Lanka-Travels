CREATE TABLE [dbo].[owner payment]
(
	[Receipt No.] INT NOT NULL PRIMARY KEY, 
    [Payment made date] DATE NOT NULL, 
    [Owner Name] VARCHAR(25) NOT NULL, 
    [Vehicle No.] CHAR(10) NOT NULL, 
    [Monthly Fee] MONEY NOT NULL, 
    [Damages Amunt] MONEY NULL, 
    [Total Amount paid] MONEY NOT NULL
)
