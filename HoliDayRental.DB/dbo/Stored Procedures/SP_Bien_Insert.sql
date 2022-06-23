CREATE PROCEDURE [dbo].[SP_Bien_Insert]
	@descriptionCourte NVARCHAR (50),
	@descriptionLongue NVARCHAR (550),
	@pays  NVARCHAR (50),
	@ville NVARCHAR (50),
	@rue NVARCHAR (50),
	@numero NVARCHAR (50),
	@codePostal NVARCHAR (50),
	@photo NVARCHAR (50),
	@NombrePersonne INT,
	@NombreSalleDeBain INT,
	@NombreWC INT,
	@titre NVARCHAR(128),
	@date DATE
AS
	INSERT INTO [Bien]([descriptionCourte],[descriptionLongue], [pays], [ville], [rue], [numero], [codePostal], [photo], [NombrePersonne], [NombreSalleDeBain], [NombreWC])
	OUTPUT [inserted].[idBien]
	VALUES (@descriptionCourte, @descriptionLongue, @pays, @ville, @rue, @numero, @codePostal, @photo, @NombrePersonne, @NombreSalleDeBain, @NombreWC)