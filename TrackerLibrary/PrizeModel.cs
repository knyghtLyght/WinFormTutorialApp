using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the torunament rank this prize is for
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the tournament rank this prize is for
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The monatary value of this prize
        /// </summary>
        public decimal PrizeValue { get; set; }

        /// <summary>
        /// The percentage of the prize pool this prize represents
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
