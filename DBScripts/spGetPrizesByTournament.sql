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
-- Description:	<Tournament Tracker get calls>
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
	inner join dbo.TournamentPrizes t on p.prize_id = t.prize_id
	where t.tournament_id = @TournamentId;
END
GO

CREATE PROCEDURE dbo.spMatchupEntries_GetByMatchup
	@MatchupId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select m.*
	from dbo.Matchups m
	inner join dbo.MatchupEntries me on m.matchup_id = me.matchup_id
	where m.matchup_id = @MatchupId;
END
GO

CREATE PROCEDURE dbo.spTeam_GetByTournament
	@TournamentId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select t.*
	from dbo.Teams t
	inner join dbo.TournamentEntries te on t.team_id = te.team_id
	where te.tournament_id = @TournamentId;
END
GO

CREATE PROCEDURE dbo.spPeople_GetAll
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select *
	from dbo.People;
END
GO

CREATE PROCEDURE dbo.spTeamMembers_GetByTeamId
	@TeamId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select tm.*
	from dbo.TeamMembers tm
	inner join dbo.Teams t on tm.team_id = t.team_id
	where tm.team_id = @TeamId;
END
GO

CREATE PROCEDURE dbo.spTournaments_GetAll
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select *
	from dbo.Tournaments;
END
GO