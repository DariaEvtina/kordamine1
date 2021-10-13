using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine1
{
    class Program
    {
        static void Main23(string[] args)
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

            //ex4
            Random randNum = new Random();
            int A = randNum.Next(1, 15);
            int AA;
            int K = 1;
            Console.WriteLine("arvake arv 1 kuni 15:");
            do
            {
                Console.WriteLine("{0} Katse. Mis on arv?", K);
                AA = int.Parse(Console.ReadLine());
                K++;
            } while (AA != A && K != 6);
            if (AA == A)
            {
                Console.WriteLine("Palju õnne");
            }
            else
            {
                Console.WriteLine("Proovi uuesti");
            }
            //ex5
            int ridadearv = 10, veergudearv = 10;
            if (args.Length == 2)
            {
                ridadearv = int.Parse(args[0]);
                veergudearv = int.Parse(args[1]);
            }
            for (int rida = 0; rida < ridadearv; rida++)
            {
                for (int veerg = 0; veerg < veergudearv; veerg++)
                {
                    Console.Write("{0, 5}", rida * veerg);
                }
                Console.WriteLine();
            }
            //ex6
            int arv;
            int[] arvud = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisetaja {0} arv!", i + 1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            int arv4 = 0;
            Array.Sort(arvud);
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = arv4 * 10 + a;
            }
            Console.Write(arv4);
            Console.ReadLine();
        }
    }
}
