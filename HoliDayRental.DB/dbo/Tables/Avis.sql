CREATE TABLE [dbo].[Avis] (
    [idAvis]      INT           NOT NULL,
    [titre]       NVARCHAR (50) NOT NULL,
    [commentaire] NVARCHAR (50) NOT NULL,
    [validation]  BIT           NOT NULL,
    [idMembre]    INT           NOT NULL,
    [idBien]      INT           NOT NULL,
    CONSTRAINT [PK_Avis] PRIMARY KEY CLUSTERED ([idAvis] ASC)
);
GO
ALTER TABLE [dbo].[Avis]
    ADD CONSTRAINT [FK_Avis_Membre] FOREIGN KEY ([idMembre]) REFERENCES [dbo].[Membre] ([idMembre]);
GO
ALTER TABLE [dbo].[Avis]
    ADD CONSTRAINT [FK_Avis_Bien] FOREIGN KEY ([idBien]) REFERENCES [dbo].[Bien] ([idBien]);