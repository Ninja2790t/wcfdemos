using Service.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApciClient client = new ApciClient();
            Console.WriteLine(client.GetApciUpdates());

            ESWClient eSWClient = new ESWClient();
            Console.WriteLine(eSWClient.GetSoftwareConfiguration());

            Console.ReadLine();
        }
    }
}
