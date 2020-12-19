using ServiceRest_022_YunusNiandySaputro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfigRest_022_YunusNiandySaputro
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObject = null;

            try
            {
                hostObject = new ServiceHost(typeof(TI_UMY));
                hostObject.Open();
                Console.WriteLine(hostObject);
                Console.WriteLine("Server ready ..");
                Console.ReadLine();
                hostObject.Close();
            }
            catch (Exception ex)
            {
                hostObject = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}