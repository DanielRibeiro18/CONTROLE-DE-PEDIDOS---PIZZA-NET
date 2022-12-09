CREATE DATABASE crudCJ301116X
GO

USE crudCJ301116X
GO

CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Sexo] [varchar](20) NOT NULL,
	[Telefone] [varchar](15) NOT NULL,
	[Celular] [varchar] (15) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Numero] [varchar](10) NOT NULL,
	[Cpf] [varchar] (20) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Senha] [varchar](60) NOT NULL,
	[Admin] [varchar](5) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Pizza](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Sabor] [varchar](100) NOT NULL,
	[Tamanho] [varchar](30) NOT NULL,
	[NumeroFatia] [varchar](30) NOT NULL,
	[Preco] [varchar] (30) NOT NULL,	
	[Disponibilidade] [varchar] (30) NOT NULL
)ON [PRIMARY]

CREATE TABLE [dbo].[Pedidos](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Valor] [varchar] (30) NOT NULL,
	[Quantidade] [varchar] (10) NOT NULL,
	[Id_Pizza] [int] FOREIGN KEY REFERENCES [dbo].[Pizza]([Id]) NOT NULL,
	[DataPedido] [varchar] (50) NOT NULL
)ON [PRIMARY]

--PRÉ-CADASTRO
--Usuário: admin Senha: 1234 (CONTA DE ADMINISTRADOR)
INSERT INTO [dbo].[Usuarios] VALUES ('Daniel','Masculino','1299223275','12992232750','R. Primeiro de Janeiro','231','38121841844','admin','MTIzNA==','SIM')
GO






























