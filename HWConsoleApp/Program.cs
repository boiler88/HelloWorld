using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Hello World message and write it to the console
            HWServiceReference.HWServiceClient hwServClient = new HWServiceReference.HWServiceClient();
            Console.WriteLine(hwServClient.GetMessage());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
