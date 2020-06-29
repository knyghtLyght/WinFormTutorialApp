-- SQL table creation commands
-- Refer to DataDesign.md
CREATE TABLE Tournaments (
	tournament_id INT PRIMARY KEY IDENTITY (1,1),
	tournament_name NVARCHAR (100) NOT NULL,
	entry_fee MONEY NOT NULL,
    create_on DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE Prizes (
	prize_id INT PRIMARY KEY IDENTITY (1, 1),
	place_number INT NOT NULL,
	place_name NVARCHAR (100) NOT NULL,
	prize_value MONEY NOT NULL,
	prize_Percentage FLOAT,
    create_on DATETIME2 DEFAULT GETUTCDATE()
);

-- Depends on both Tournaments and Prizes tables to be completed first
CREATE TABLE TournamentPrizes (
	tournament_prizes_id INT PRIMARY KEY IDENTITY (1, 1),
	tournament_id INT NOT NULL,
	prize_id INT NOT NULL,
	FOREIGN KEY (tournament_id) REFERENCES Tournaments (tournament_id),
	FOREIGN KEY (prize_id) REFERENCES Prizes (prize_id),
);

CREATE TABLE People (
	person_id INT PRIMARY KEY IDENTITY (1, 1),
    first_name NVARCHAR (100) NOT NULL,
    last_name NVARCHAR (100) NOT NULL,
	email_address NVARCHAR (50) NOT NULL,
    phone VARCHAR(20),
    created_on DATETIME2 DEFAULT GETUTCDATE()
);

CREATE TABLE Teams (
    team_id INT PRIMARY KEY IDENTITY (1,1),
    team_name NVARCHAR(100) NOT NULL,
    create_on DATETIME2 DEFAULT GETUTCDATE()
);

-- Depends on Teams and People
CREATE TABLE TeamMembers (
    team_member_id INT PRIMARY KEY IDENTITY (1,1),
    team_id INT NOT NULL,
    person_id INT NOT NULL,
	FOREIGN KEY (team_id) REFERENCES Teams (team_id),
	FOREIGN KEY (person_id) REFERENCES People (person_id)
);

-- Depends on Tournaments and Teams
CREATE TABLE TournamentEntries (
    tournamentEntries_id INT PRIMARY KEY IDENTITY (1,1),
    tournament_id INT NOT NULL,
    team_id INT NOT NULL,
	FOREIGN KEY (tournament_id) REFERENCES Tournaments (tournament_id),
	FOREIGN KEY (team_id) REFERENCES Teams (team_id)
);

-- Depends on Teams
CREATE TABLE Matchups (
    matchup_id INT PRIMARY KEY IDENTITY (1,1),
    winner_id INT NOT NULL,
    matchup_round INT NOT NULL,
	FOREIGN KEY (winner_id) REFERENCES Teams (team_id)
);

-- Depends on Matchups and Teams
CREATE TABLE MatchupEntries (
    matchup_entries_id INT PRIMARY KEY IDENTITY (1,1),
    matchup_id INT NOT NULL,
    parent_matchup_id INT NOT NULL,
    competing_team INT NOT NULL,
    score INT NOT NULL,
	FOREIGN KEY (matchup_id) REFERENCES Matchups (matchup_id),
	FOREIGN KEY (parent_matchup_id) REFERENCES Matchups (matchup_id),
	FOREIGN KEY (competing_team) REFERENCES Teams (team_id)
);