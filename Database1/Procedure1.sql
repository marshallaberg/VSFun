CREATE PROCEDURE [dbo].[Procedure1]
AS
BEGIN
	DECLARE @current INT = 0
	DECLARE @max INT = 500
	WHILE @current < @max
	BEGIN
		INSERT INTO [TABLE1] ([Value]) VALUES (NEWID())
		set @current = @current+1
	END
END
