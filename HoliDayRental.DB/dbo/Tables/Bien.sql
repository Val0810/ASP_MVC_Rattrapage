CREATE TABLE [dbo].[Bien] (
    [idBien]            INT            NOT NULL,
    [descriptionCourte] NVARCHAR (50)  NOT NULL,
    [descriptionLongue] NVARCHAR (550) NOT NULL,
    [pays]              NVARCHAR (50)  NOT NULL,
    [ville]             NVARCHAR (50)  NOT NULL,
    [rue]               NVARCHAR (50)  NOT NULL,
    [numero]            NVARCHAR (50)  NOT NULL,
    [codePostal]        NVARCHAR (50)  NOT NULL,
    [photo]             NVARCHAR (50)  NOT NULL,
    [NombrePersonne]    INT            NOT NULL,
    [NombreSalleDeBain] INT            NOT NULL,
    [NombreWC]          INT            NOT NULL,
    [idEchange]         INT            NOT NULL,
    CONSTRAINT [PK_Bien] PRIMARY KEY CLUSTERED ([idBien] ASC)
);
GO
ALTER TABLE [dbo].[Bien]
    ADD CONSTRAINT [FK_Bien_Echange] FOREIGN KEY ([idEchange]) REFERENCES [dbo].[Echange] ([idEchange]);