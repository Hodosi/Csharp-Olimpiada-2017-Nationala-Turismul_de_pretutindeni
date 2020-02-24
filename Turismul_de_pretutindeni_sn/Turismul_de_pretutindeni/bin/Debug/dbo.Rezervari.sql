CREATE TABLE [dbo].[Rezervari]
(
	[IdRezervare] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdVacanta] INT NULL, 
    [IdUser] INT NULL, 
    [DataInceput] DATETIME NULL, 
    [DataSfarsit] DATETIME NULL, 
    [NrPersoane] INT NULL, 
    [PretTotal] FLOAT NULL
)
