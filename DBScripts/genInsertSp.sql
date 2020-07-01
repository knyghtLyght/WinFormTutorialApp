USE [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kevin Farrow>
-- Create date: <07/01/2020>
-- Description:	<>
-- =============================================
CREATE PROCEDURE dbo.spPrizes_Insert
	@Place_Number int,
	@Place_Name NVARCHAR(50),
	@Prize_Value MONEY,
	@Prize_Percentage FLOAT,
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Prizes (place_number, place_name, prize_value, prize_Percentage)
	values (@Place_Number, @Place_Name, @Prize_Value, @Prize_Percentage);

	select @id = SCOPE_IDENTITY();

END
GO
