using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the method actually save to a text file
        /// <summary>
        /// Saves a new prize to a text file
        /// </summary>
        /// <param name="model">The prize data</param>
        /// <returns>The prize data including the unique identifier</returns>
        public PrizeModel CreatePirze(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
