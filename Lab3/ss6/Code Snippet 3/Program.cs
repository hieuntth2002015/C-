using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet_3
{
    class Student
    {
        void printName(String firstName, String lastName)
        {
            Console.WriteLine("FIrst Name  = {0}, Last Name = {1} ", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.printName("Herry", "Parker");
            student.printName(firstName: "Herry", lastName: "Parker");
            student.printName(lastName: "Parker", firstName: "Herry");

            student.printName("Herry", lastName: "Parker");
        }
    }
}
