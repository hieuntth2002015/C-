using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    class Cydinder
    {
        public static void Main()
        {
            double r, h;
            double BaseArea, LateralArea, TotalArea, Volumn;
            double PI = 3.14159265359;
            Console.WriteLine("Enter the dimentstions of the cylinder");
            Console.Write("Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nCylinder Characteristics");

            Console.WriteLine("Radius:{0} , Height:{1}", r, h);
            
            BaseArea = r * r * Math.PI;
            
            LateralArea = 2 * Math.PI * r * h;
       
            TotalArea=2 * Math.PI * r * (h + r);
           
            Volumn = Math.PI * r * r * h;
           
            Console.WriteLine("Base:{0:F2} : LateralArea:{1:F2} : TotalArea:{2:F2} : Volumn:{3:F2}", BaseArea, LateralArea, TotalArea, Volumn);

            Console.Read();

            Console.ReadKey();
        }
    }
}
