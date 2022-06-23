CREATE TABLE [dbo].[Assurance] (
    [idAssurance]      INT           NOT NULL,
    [numeroContrat]    NVARCHAR (50) NOT NULL,
    [souscription]     BIT           NOT NULL,
    [dateSouscription] DATETIME2 (7) NOT NULL,
    [moyenPaiement]    NVARCHAR (50) NOT NULL,
    [idMembre]         INT           NOT NULL,
    CONSTRAINT [PK_Assurance] PRIMARY KEY CLUSTERED ([idAssurance] ASC)
);
GO
ALTER TABLE [dbo].[Assurance]
    ADD CONSTRAINT [FK_Assurance_Membre] FOREIGN KEY ([idMembre]) REFERENCES [dbo].[Membre] ([idMembre]);