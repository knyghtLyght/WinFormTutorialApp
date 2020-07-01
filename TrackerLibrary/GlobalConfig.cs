using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType connectionType)
        {
            if (connectionType == DatabaseType.Sql)
            {
                // TODO - Create sql connection properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (connectionType == DatabaseType.TextFile)
            {
                // TODO - Create actual text file connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
