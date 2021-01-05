using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int toan, ly, hoa;
            string name;
            int dtb;
            Console.Write("Nhap ten cua hoc sinh:");
            name = Console.ReadLine();
            Console.Write("Nhap diem mon toan:");
            toan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem mon ly:");
            ly = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem mon hoa:");
            hoa = Convert.ToInt32(Console.ReadLine());

            dtb = (toan + ly + hoa) / 3;
            Console.WriteLine("Diem trung binh 3 mon hoc: ", dtb);
            //if((toan >=0 & toan <=100) & (ly >=0 & ly <=100) & (hoa>=0 & hoa <=100))
            if (dtb >= 75)
            {
                Console.WriteLine("Ban nhan duoc hoc bong tri gia: $1500 ";
            }
            else if (dtb < 75 & dtb>= 60){
                Console.WriteLine("Ban nhan duoc hoc bong tri gia : $1000 ");
            }
            else(dtb < 65)
            {
                Console.WriteLine("Rat tiec ban chua the dat duoc hoc bong");
            }
           

            Console.ReadKey();
        }
    }
}
