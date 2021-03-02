CREATE TABLE [dbo].[Card]
(
	[Id] INT NOT NULL, 
    [SetId] NCHAR(10) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Color] VARCHAR(16) NOT NULL, 
    [Type] CHAR(16) NOT NULL, 
    CONSTRAINT [FK_Card_ToSet] FOREIGN KEY ([SetId]) REFERENCES [Set]([Id]), 
    CONSTRAINT [CK_Card_Color] CHECK (Color IN ('Red','Yellow','Blue','Green','Purple','Black','White')), 
    CONSTRAINT [CK_Card_Type] CHECK (Type IN ('Option','Tamer','Digimon','Digi-Egg')), 
    CONSTRAINT [PK_Card] PRIMARY KEY ([Id], [SetId]) 
)
