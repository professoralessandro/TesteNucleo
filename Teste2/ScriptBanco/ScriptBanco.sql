CREATE TABLE TabelaRegistros
(
idTexto int not null identity,
texto varchar(244),
dataHora dateTime
)
GO
--CADASTRARDADOS
IF EXISTS (SELECT * FROM sysobjects WHERE name = 'InserirDados' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].InserirDados
GO

CREATE PROCEDURE [dbo].InserirDados
(
	@texto varchar(244)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[TabelaRegistros] ([texto], [dataHora]) VALUES (@texto, SYSDATETIME())
GO
--PROCEDURE SELECT
IF EXISTS (SELECT * FROM sysobjects WHERE name = 'SelecionarDados' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].SelecionarDados
GO

CREATE PROCEDURE [dbo].SelecionarDados
AS
	SET NOCOUNT ON;
SELECT COUNT(*) FROM TabelaRegistros
GO

insert into TabelaRegistros(texto, dataHora) values('Olá, se inscreva no meu canal', SYSDATETIME())
go
