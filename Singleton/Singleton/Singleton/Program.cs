using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// This singleton demo is an example of saving values only.
    /// </summary>
    class Program
    {
        // In case two tables getting the same server at the same time
        // we create singleton class that only sends out the server one at a time
        // So the very same server doesn't get called at two tables the same time
        static TableServers host1List = TableServers.GetTableServers();
        static TableServers host2List = TableServers.GetTableServers();

        static void Main(string[] args)
        {
            TableServers servers = TableServers.GetTableServers();

            int numCallingServers = 10;

            // Call numCallingsServers times the servers
            for(int i = 0; i < numCallingServers; i++)
            {
                //Console.WriteLine($"The next server is {servers.GetNextServer()}");
                Host1GetNextServer();
                Host2GetNextServer();
            }
            Console.ReadLine();
        }

        // Host 1 calling server
        private static void Host1GetNextServer()
        {
            Console.WriteLine($"The next server is {host1List.GetNextServer()}");
        }

        // Host 2 calling server
        private static void Host2GetNextServer()
        {
            Console.WriteLine($"The next server is {host2List.GetNextServer()}");
        }
    }
}
