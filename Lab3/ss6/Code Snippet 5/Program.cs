using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet_5
{
    class OptionalParameterExample{
        void printMessage (String message="Hello user!")
    {
        Console.WriteLine("{0}", message);
    }
    static void Main(string[] args)
        {
            OptionalParameterExample opExample = new OptionalParameterExample();
            opExample.printMessage("Welcom User!");
            opExample.printMessage();
        }
       
    }
}
