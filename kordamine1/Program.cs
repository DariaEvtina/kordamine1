using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex2
            int mult = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter num:");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt * mult;
            }
            double avg = sum / 5;
            Console.WriteLine($"AVG={avg}\nSUM={sum}\nMULTIPLIED={mult}");
            //ex3
            string nr;
            do
            {
                Console.WriteLine("Tere,Osta elevant ära!");
                nr = Console.ReadLine();
            } while (nr != "elevant");
            Console.WriteLine("elevant!");
            Console.ReadLine();
        }
    }
}
