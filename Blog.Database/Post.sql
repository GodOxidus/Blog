CREATE TABLE [dbo].[Posts] (
    [Id]           INT            NOT NULL,
    [Name]         NVARCHAR (200) NOT NULL,
    [Content]      NVARCHAR (MAX) NOT NULL,
    [PostDateTime] DATETIME       NOT NULL,
    [Prephrase]    NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
