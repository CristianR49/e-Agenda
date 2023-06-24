CREATE TABLE [dbo].[TBContato] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [nome]     VARCHAR (200) NOT NULL,
    [telefone] VARCHAR (100) NOT NULL,
    [email]    VARCHAR (100) NOT NULL,
    [cargo]    VARCHAR (100) NOT NULL,
    [empresa]  VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

