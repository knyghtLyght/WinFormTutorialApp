# Requirements for Tournement app

## Requirements Given

1. Tracks games played and their outcome (Who won).
2. Multiple competitors play in the tournament.
3. Creates a tournament plan (who plays in what order).
4. Schedules games.
5. A single loss eliminates a player.
6. The last player standing is the winner.

## Discovery questions

1. How many players will the tournament handle? is it variable?

   Variable.

2. If a tournament has less than the full complement of players, how do we handle it?

   * A tournament with less than the perfect number shoudl add "byes" at randmo.

3. Should the ordering of who plays each other be random or ordered by input order?

   * Should be random.
4. Should we schedule the game or are the just played whenever?

   * Should be played in whatever order.
5. If the games are scheduled, how does the system know when to schedule games?

   * Not schedualed

6. If the games are played whenever, can a game from the second round be played before the first round is complete?

   * No. Each round should be complete before any new round games start 

7. Does the system need to store a score of some kind or just who won?

   * Storing a simple score would be nice. Just a number for each player but flexable enough to handle multiple game types.

8. What type of front end should the system have (form, webpage, app)?

   * The system should be a desktop app for now but down the road we might want to turn it into a website.

9. Where is the data going to stored?
   * MS SQL database but with the opiton to store as plain text

10. Will this system handle entry fees, prizes, or other payouts?

    * Yes. "Good" fiscale reporting

11. What kind of reporting is needed?

    * A simple report stating the outcome of each of the games per round as well as a report that states who won and how much the won. Displayed via form or emailed to tournament competitors and the admin.

12. Who can fill in the results of a game?

    * Anybody using the app should be able to fill in game scores.

13. Are there varying levels of access?

    * No

14. Should the system contact the users about upcoming games?

    * Yes, System should email competetors who thye are playing.

15. Is each player on thier own or can teams use this system?

    * The tournament tracker should be able to handle the addition of other members. All members should be treated as equals in that theu all get tournament emails. Teams should be able to name their team.
