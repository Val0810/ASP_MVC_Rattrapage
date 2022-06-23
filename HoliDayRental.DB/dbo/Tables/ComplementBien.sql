CREATE TABLE [dbo].[ComplementBien] (
    [idComplementBien] INT NOT NULL,
    [jardin]           BIT NOT NULL,
    [piscine]          BIT NOT NULL,
    [laveLinge]        BIT NOT NULL,
    [internet]         BIT NOT NULL,
    [animaux]          BIT NOT NULL,
    [idBien]           INT NOT NULL,
    CONSTRAINT [PK_ComplementBien] PRIMARY KEY CLUSTERED ([idComplementBien] ASC)
);
GO
ALTER TABLE [dbo].[ComplementBien]
    ADD CONSTRAINT [FK_ComplementBien_Bien] FOREIGN KEY ([idBien]) REFERENCES [dbo].[Bien] ([idBien]);