CREATE TABLE [dbo].[Membre] (
    [idMembre]    INT            IDENTITY (1, 1) NOT NULL,
    [nom]         NVARCHAR (50)  NOT NULL,
    [prenom]      NVARCHAR (50)  NOT NULL,
    [mail]        NVARCHAR (250) NOT NULL,
    [pays]        NVARCHAR (50)  NOT NULL,
    [telephone]   NVARCHAR (50)  NOT NULL,
    [identifiant] NVARCHAR (50)  NULL,
    [motDePasse]  NVARCHAR (250) NULL,
    [CGV]         BIT            NULL,
    CONSTRAINT [PK_Membre] PRIMARY KEY CLUSTERED ([idMembre] ASC)
);

