-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
USE [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kevin Farrow>
-- Create date: <6/29/2020>
-- Description:	<>
-- =============================================
CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select p.*
	from dbo.Prizes p
	inner join dbo.TournamnetPrizes t on p.id = t.prize_id
	where t.tournament_id = @TournamentId;
END
GO
