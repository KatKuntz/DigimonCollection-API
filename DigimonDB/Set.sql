﻿CREATE TABLE [dbo].[Set]
(
	[Id] NVARCHAR(10) NOT NULL ,
    [Name] NVARCHAR(50) NOT NULL,
    [ReleaseDate] DATE NOT NULL,
    CONSTRAINT [PK_Set] PRIMARY KEY ([Id])
)
