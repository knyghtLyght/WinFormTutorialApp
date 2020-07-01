using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The Unique model identifier
        /// </summary>
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeValue, string prizePercentage)
        {
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            PlaceName = placeName;

            decimal parsedPrizeValue = 0;
            decimal.TryParse(prizeValue, out parsedPrizeValue);
            PrizeValue = parsedPrizeValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
