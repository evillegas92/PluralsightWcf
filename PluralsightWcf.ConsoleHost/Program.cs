using System;
using System.Diagnostics;
using System.ServiceModel;
using PluralsightWcf.Wcf;

namespace PluralsightWcf.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(OrderManagementService));
                host.Open();

                Console.ReadKey();
                host.Close(); //graceful shutdown (terminate running calls and then shutdown).
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
