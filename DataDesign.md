## Team
* ID (int)
* TeamName (string)
* TeamMembers (List\<Person>)

## Person
* ID (int)
* FirstName (string)
* LasttName (string)
* EmailAddress (string)
* CellNumber (string)

## Tournament
* ID (int)
* TournamentName (string)
* EntryFee (decimal)
* EnteredTeams (List\<Team>)
* Prizes (List\<Prize>)
* Rounds (List\<List\<Matchup>>)

## Prize
* ID (int)
* PlaceName (string)
* PrizeAmount (decimal)
* PrizePercentage (double)

## Macthup
* ID (int)
* Entries (List\<MatchupEntry>)
* Winner (Team)
* MatchupRound (int)

## MatchupEntry
* ID (int)
* TeamCompeting (Team)
* Score (double)
* ParentMatchup (Matchup)