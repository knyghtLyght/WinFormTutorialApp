using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the method actually save to the db
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize data</param>
        /// <returns>THe prize data including the unique identifier</returns>
        public PrizeModel CreatePirze(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
