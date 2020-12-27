using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestA
{
    class testA
    {
        public String name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            Console.WriteLine("****Test value type: ");
            Console.WriteLine("The value of 2 before: " + z);
            changeValue(z);
            Console.WriteLine("The value of 2 after :" + z);
           
            Console.WriteLine("****Test reference type: ");
            testA a = new testA();
            a.name = "not changed";
            Console.WriteLine("The value of str before: " + a.name);
            changeValue2(a);
            Console.WriteLine("The value of str after: " + a.name);

            Console.ReadLine();
        }
        public static void changeValue(int k)
        {
            Console.WriteLine("[in changeValue] orignal value: " + k);
            k = 100;
            Console.WriteLine("[in changeValue] new value " + k);
        }
        public static void changeValue2(testA v)
        {
            v.name = "changed it";
        }
    }
}
