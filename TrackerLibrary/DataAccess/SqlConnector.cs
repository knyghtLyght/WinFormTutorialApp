using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@Place_Number", model.PlaceNumber);
                p.Add("@Place_Name", model.PlaceName);
                p.Add("@Prize_Value", model.PrizeValue);
                p.Add("@Prize_Percentage", model.PrizePercentage);
                p.Add("@id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
