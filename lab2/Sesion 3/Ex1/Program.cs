using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, so_hang;
            Console.Write("\n");
            Console.Write("Vex tam giac sao trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang :");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for(i=1; i<= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
