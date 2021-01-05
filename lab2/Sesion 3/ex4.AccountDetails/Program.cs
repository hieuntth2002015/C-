using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4.AccountDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID, accNumber, amount;
            char type;
            DateTime openDate;
            double balance;

            Console.Write("Enter the ID of customer: ");
            ID = Convert.ToInt32(Console.ReadLine());
            if(ID >0)
            {
                Console.Write("Enter account number: ");
                accNumber = Convert.ToInt32(Console.ReadLine());
                if(accNumber >0 )
                {
                    Console.Write("Enter acoount type [Fixed/Savings]: ");
                    type = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter the date of opening acoount [MM/DD/YYYY}: ");
                    openDate = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Enter the amount depostited : ");
                    amount = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Invalid emtry  for accNumber");
                }
            }
            else
            {
                Console.WriteLine("Invalid emtry for ID");
            }


        }
    }
}
