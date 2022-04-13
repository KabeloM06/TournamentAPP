using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                // Create the SQL Connection
                // TODO - Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            /// New if statement because else statement would ignore the creation
            /// of a text file if the SQL connection was created
            /// 

            if (textFiles == true)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
