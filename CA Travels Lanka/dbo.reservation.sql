CREATE TABLE [dbo].[Table]
(
	[Reservation ID] CHAR(10) NOT NULL PRIMARY KEY, 
    [Customer ID] CHAR(10) NOT NULL, 
    [Package] VARCHAR(20) NOT NULL, 
    [Date] DATE NOT NULL, 
    [Vehicle No.] VARCHAR(10) NULL, 
    [Status] VARCHAR(10) NOT NULL, 
    [Ending Date] DATE NULL
)
