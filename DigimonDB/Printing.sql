CREATE TABLE [dbo].[Printing]
(
    [Id] INT NOT NULL IDENTITY,
    [CardId] INT NOT NULL,
    [AlternateArt] BIT NOT NULL
        CONSTRAINT [DF_Printing_AltArt] DEFAULT 0,
    CONSTRAINT [PK_Printing] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Printing_CardId_AltArt] UNIQUE ([CardId],[AlternateArt]),
    CONSTRAINT [FK_Printing_CardId] FOREIGN KEY ([CardId]) REFERENCES [Card]([Id])
)
