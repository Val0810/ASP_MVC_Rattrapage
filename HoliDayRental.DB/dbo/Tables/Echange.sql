CREATE TABLE [dbo].[Echange] (
    [idEchange]         INT           NOT NULL,
    [numeroReservation] NVARCHAR (50) NOT NULL,
    [dateReservation]   DATETIME2 (7) NOT NULL,
    [dateEntree]        DATETIME2 (7) NOT NULL,
    [dateSortie]        DATETIME2 (7) NOT NULL,
    [dateReglement]     DATETIME2 (7) NOT NULL,
    [moyenPaiement]     NVARCHAR (50) NOT NULL,
    [statutEchange]     NVARCHAR (50) NOT NULL,
    [idMembre]          INT           NOT NULL,
    CONSTRAINT [PK_Echange] PRIMARY KEY CLUSTERED ([idEchange] ASC)
);
GO
ALTER TABLE [dbo].[Echange]
    ADD CONSTRAINT [FK_Echange_Membre] FOREIGN KEY ([idMembre]) REFERENCES [dbo].[Membre] ([idMembre]);