using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the Tournament for display
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// THe entry fee in USD for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of the Teams entered into the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The list of Prizes for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// A compund list representing the rounds and matchups associated with those rounds 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
