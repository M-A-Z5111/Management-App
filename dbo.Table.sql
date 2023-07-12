CREATE TABLE [dbo].[Airplane]
(
	[AirplaneId] INT NOT NULL PRIMARY KEY Identity (1,1), 
    [Owner] NCHAR(10) NOT NULL, 
    [Capacity] INT NOT NULL, 
    [DepartureTime] DATETIME NOT NULL, 
    [Color] NCHAR(10) NOT NULL
)
