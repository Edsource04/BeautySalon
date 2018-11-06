using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public static class DatabaseInfo
    {
        public static String GetApplicationConnectionString()

        {

            return System.Configuration.ConfigurationManager.ConnectionStrings["SalonContext"].ConnectionString;

        }



        public static String GetServerNameFromConfiguration()

        {

            String path = GetApplicationConnectionString();

            String[] pathParts = path.Split(';');

            String serverName = null;

            foreach (String s in pathParts)

            {

                if (s.Contains("Data Source="))

                {

                    Int32 index = s.LastIndexOf('=') + 1;

                    serverName = s.Substring(index).Trim();

                    break;

                }

            }



            return serverName;

        }



        public static String GetDatabaseNameFromConfiguration()

        {

            String path = GetApplicationConnectionString();

            String[] pathParts = path.Split(';');

            String databaseName = null;

            foreach (String s in pathParts)

            {

                if (s.Contains("Initial Catalog="))

                {

                    databaseName = s.Substring((s.LastIndexOf('=') + 1)).Trim();

                    break;

                }

            }



            return databaseName;

        }
    }
}
