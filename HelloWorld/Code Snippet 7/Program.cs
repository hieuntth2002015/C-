using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet_7
{
    class Employee
    {
        private int id;
        private string name;

        public Employee()
        {
            id = -1;
            name = null;
        }
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name; }

        static void Main(string[] args){
                Employee objEmp = new Employee(101, "David Smith");
                Console.WriteLine("Employee ID: {0} \nEmployee Name: {1}", objEmp.name);
            }
       
    }
}
