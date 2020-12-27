using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COde_Snipper_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\MyFile.txt";
            bool found = true;
            if (found)
            {
                Console.WriteLine("Filepath:\'" + path + "\'");
            }
            else
            {
                Console.WriteLine("File Not Found!\a");
            }
        }
    }
}
