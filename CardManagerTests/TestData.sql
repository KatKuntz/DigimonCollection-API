
INSERT INTO [dbo].[Set](Name, ReleaseDate) VALUES ('Test Set', '3/17/2021');
DECLARE @testSetId INT = SCOPE_IDENTITY();

SELECT @testSetId AS testSetId;
