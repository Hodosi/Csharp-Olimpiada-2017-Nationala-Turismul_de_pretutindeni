CREATE TABLE [dbo].[Utilizatori]
(
	[IdUser] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] VARCHAR(30) NULL, 
    [Prenume] VARCHAR(30) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Parola] VARCHAR(50) NULL, 
    [TipCont] INT NULL
)
