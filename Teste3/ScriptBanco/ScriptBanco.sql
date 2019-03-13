CREATE DATABASE XYZ
GO
CREATE TABLE TabelaRegistros
(
idTexto int not null identity,
reansmEscritorios varchar(60),
dds varchar(60),
posicao varchar(60)
)
GO
--CADASTRARDADOS
IF EXISTS (SELECT * FROM sysobjects WHERE name = 'InserirDados' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].InserirDados
GO

CREATE PROCEDURE [dbo].InserirDados
(
	@reansmEscritorios varchar(60),
	@dds varchar(60),
	@posicao varchar(60)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[TabelaRegistros] ([reansmEscritorios], [dds], [posicao]) VALUES (@reansmEscritorios, @dds, @posicao)
GO

--BUSCAR
IF EXISTS (SELECT * FROM sysobjects WHERE name = 'BuscarDados' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].BuscarDados
GO

CREATE PROCEDURE [dbo].BuscarDados
AS
	SET NOCOUNT ON;
SELECT idTexto, reansmEscritorios, dds, posicao FROM dbo.TabelaRegistros
GO


