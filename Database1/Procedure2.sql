CREATE PROCEDURE [dbo].[Procedure2]
(
	@current int output
)
AS
BEGIN
	DECLARE @max INT = 500
	
	if @current is null
		set @current = 0
	INSERT INTO [TABLE1] ([Value]) VALUES (NEWID())
	set @current = @current+1
	IF @current < @max
		return 0 --tell boss program to keep going
	else
		return 1 --tell boss program we're complete
	
END
