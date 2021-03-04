CREATE TABLE [dbo].[Printing]
(
    [Id] INT NOT NULL IDENTITY,
    [CardId] INT NOT NULL,
    [AlternateArt] BIT NOT NULL
        CONSTRAINT [DF_Printing_AltArt] DEFAULT 0,
    CONSTRAINT [PK_Printing] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Printing_CardId_AltArt] UNIQUE ([CardId],[AlternateArt])
)
