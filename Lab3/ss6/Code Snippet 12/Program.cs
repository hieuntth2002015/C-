using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet_12
{
    class RefParameters
    {
        static void Calculate (ref int numValueOne, ref int numValueTwo)
        {
            numValueOne = numValueOne * 2;
            numValueTwo = numValueTwo / 2;
        }
        static void Main(String[] args)
        {
            int numOne = 10;
            int numTWo = 20;
            Console.WriteLine("Value of Num1 and Num2 before calling method"
                + numOne + "," + numTWo);
            Calculate(ref numOne, ref numTWo);
            Console.WriteLine("Value of Num1 and Num2 after calling method"
                + numOne + "," + numTWo);
        }
    }
}
