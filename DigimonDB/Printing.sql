CREATE TABLE [dbo].[Printing]
(
	[Id] INT NOT NULL  IDENTITY,
    [AlternateArt] BIT NOT NULL DEFAULT 0,
    CONSTRAINT [PK_Printing] PRIMARY KEY ([Id])
)
