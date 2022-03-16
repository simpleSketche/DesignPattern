using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class TableServers
    {
        // ***** this line creates a instance only if there is no other instance created in this class
        // once it is assigned, cannot be reassigned to another value
        // ---------------> Singleton
        private static readonly TableServers _tableServers = new TableServers();
        
        private List<string> servers= new List<string>();
        private int nextServer = 0;

        // ***** making the class constructor private, meaning it won't be assigned from externally
        private TableServers()
        {
            servers.Add("name1");
            servers.Add("name2");
            servers.Add("name3");
            servers.Add("name4");
        }

        // ***** This method returns the instance value
        public static TableServers GetTableServers()
        {
            return _tableServers;
        }

        /// <summary>
        /// Get the next server info
        /// </summary>
        /// <returns></returns>
        public string GetNextServer()
        {
            string output = servers[nextServer];

            nextServer += 1;

            if(nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}
