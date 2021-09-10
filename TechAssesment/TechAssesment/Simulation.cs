using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAssesment
{
    class Simulation
    {
        public Simulation()
        {
            while (true)
            {





                var ch = Console.ReadKey(true);
                if (ch.Key == ConsoleKey.Q || ch.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                };
            }
            
        }

    }
}
