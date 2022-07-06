using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }

            string restar4 = Console.ReadLine();
            if (restar4.ToUpper() == "R")
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                Environment.Exit(0);
            }
        }
    }
}
