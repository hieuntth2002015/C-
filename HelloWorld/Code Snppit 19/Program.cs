using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snppit_19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Short date format(d) : {0:d}", dt);
            Console.WriteLine("Long date format {D}: {0:D}", dt);
            Console.WriteLine("Full date with time without seconds (f) : (0:f)", dt);
            Console.WriteLine("Full date with time with seconds (F): {0:F}", dt);
            Console.WriteLine("Short date and short tiem without seconds (g) : {0:g}", dt);
        }
    }
}
