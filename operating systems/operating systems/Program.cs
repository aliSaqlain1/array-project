using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace operating_systems
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize the select query with command text
            //saqlain
            SelectQuery query = new SelectQuery(@"Select * from Win32_OperatingSystem");

            //initialize the searcher with the query it is supposed to execute
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                //execute the query
                foreach (ManagementObject process in searcher.Get())
                {
                    //print OS properties
                    Console.WriteLine("/*********Operating System Information ***************/");
                    Console.WriteLine("{0}{1}", "Caption:", process["Caption"]);
                    Console.WriteLine("{0}{1}", "ServicePackMajorVersion :", process["ServicePackMajorVersion"]);
                    Console.WriteLine("{0}{1}", "ServicePackMinorVersion:", process["ServicePackMinorVersion"]);
                    Console.WriteLine("{0}{1}", "InstallDate:", process["InstallDate"]);
                    Console.WriteLine("{0}{1}", "Version:", process["Version"]);
                    Console.WriteLine("{0}{1}", "FreePhysicalMemory:", process["FreePhysicalMemory"]);
                    Console.ReadKey();
                }
            }

        }
    }
}
