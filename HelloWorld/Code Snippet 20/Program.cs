using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet_20
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Short date and short tiem with seconds(G) : {0:G}", dt);
            Console.WriteLine("Month and day (m):{0:m}", dt);
            Console.WriteLine("Short time with seconds (T): {0:T}", dt);
            Console.WriteLine("Year and Month (y) : {0:y}", dt);
        }
    }
}
