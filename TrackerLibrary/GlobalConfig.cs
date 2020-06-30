using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool dataBase, bool textFiles)
        {
            if (dataBase)
            {
                // TODO - Create sql connection properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create actual text file connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
