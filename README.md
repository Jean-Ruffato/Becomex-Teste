# Becomex-Teste

* Repositório da solução do projeto teste R.O.B.O

- Para executar o projeto é necessário ter um banco local (SQLServer) e criar um banco de dados chamado ROBO e executar o script SQL abaixo para criar as tabelas nesse banco:

USE [ROBO]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NULL,
	[Mensagem] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Robo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAcesso] [varchar](50) NULL,
	[CotoveloEsquerdo] [int] NULL,
	[CotoveloDireito] [int] NULL,
	[PulsoEsquerdo] [int] NULL,
	[PulsoDireito] [int] NULL,
	[RotacaoCabeca] [int] NULL,
	[InclinacaoCabeca] [int] NULL
) ON [PRIMARY]
GO


