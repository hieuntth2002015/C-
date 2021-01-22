using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalDemo
    {
        static void Main(string[] args)
        {
            Animal Tiger = new Animal("Tiger", 100);

            Console.WriteLine("Name:" + Tiger.Name + "," + " Weight " + Tiger.Weight);
            

            Animal Lion = new Animal("Lion", 200);

            Console.WriteLine("Name:" + Lion.Name + "," + " Weight " + Lion.Weight);
            
            Console.ReadLine();
        }
    }
}
