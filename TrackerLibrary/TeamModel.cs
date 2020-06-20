using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of Team Members associated with the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Display name for the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
