﻿CREATE TABLE [dbo].[TB_TESTE] (
    [ID]                  INT          IDENTITY (1, 1) NOT NULL,
    [DISCIPLINA_ID]       INT          NOT NULL,
    [DATA_TESTE]          DATETIME     NOT NULL,
    [QUANTIDADE_QUESTOES] INT          NOT NULL,
    [SERIE]               INT          NOT NULL,
    [TITULO]              VARCHAR (50) NOT NULL,
    [RECUPERACAO]         BIT          NOT NULL,
    [MATERIA_ID]          INT          NULL,
    CONSTRAINT [PK_TB_TESTE] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_DISCIPLINA_TESTE] FOREIGN KEY ([DISCIPLINA_ID]) REFERENCES [dbo].[TB_DISCIPLINA] ([ID]),
    CONSTRAINT [FK_MATERIA_TESTE] FOREIGN KEY ([MATERIA_ID]) REFERENCES [dbo].[TB_MATERIA] ([ID])
);







