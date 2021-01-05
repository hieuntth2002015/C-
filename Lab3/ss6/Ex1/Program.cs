using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Student
    {
        int id;
        string name;
        DateTime birth;
        float gpa;
        static void main()
        {
            Console.WriteLine("Enter your ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your birthday: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter your GPA: ");
            float gpa = Convert.ToSingle(Console.ReadLine());

        }
    }
}
