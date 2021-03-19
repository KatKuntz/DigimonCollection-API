
INSERT INTO [dbo].[Set](Name, ReleaseDate) VALUES ('Test Set', '3/17/2021');
DECLARE @testSetId INT = SCOPE_IDENTITY();

DECLARE @testCardId NCHAR(7) = 'TES-001';
INSERT INTO [dbo].[Card](Id, SetId, Name, Color, Type) VALUES (@testCardId, @testSetId, 'Test Card', 'Red', 'Tamer');

SELECT @testSetId AS testSetId, @testCardId AS testCardId;
