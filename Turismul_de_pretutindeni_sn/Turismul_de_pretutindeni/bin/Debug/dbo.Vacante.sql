CREATE TABLE [dbo].[Vacante] (
    [IdVacanta]   INT           IDENTITY (1, 1) NOT NULL,
    [NumeVacanta] VARCHAR (50)  NULL,
    [Descriere]   VARCHAR (300) NULL,
    [CaleFisier]  VARCHAR (200) NULL,
    [Pret]        FLOAT (53)    NULL,
    [NrLocuri]    INT           NULL,
    PRIMARY KEY CLUSTERED ([IdVacanta] ASC)
);

