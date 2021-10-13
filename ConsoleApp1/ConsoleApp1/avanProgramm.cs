using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class avanProgramm
    {
        static int calculator(int a,int b, string c)
        {
            if (c=="+")
            {
                return a + b;
            }
            else if (c=="/")
            {
                return a / b;
            }
            else if (c=="-")
            {
                return a - b;
            }
            else if (c=="*")
            {
                return a * b;
            }
            return 0;
        }
        public static int keskmine(int a, int c)
        {
            return a / c;
        }
        public static int korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 23;
            Console.WriteLine("{0} * {1} = {2}",a,b,korruta(a, b));
            //ex1
            Console.WriteLine("sisestage mitu numbrit soovite keskmist leida?");
            int c = int.Parse(Console.ReadLine());
            int[] arvud = new int[c];
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Sisetaja {0} num:", i);
                int arvu = int.Parse(Console.ReadLine());
                arvud[i] = arvu;
            }
            int arv=0;
            foreach (var avr in arvud)
            {
                arv += avr;
            }
            Console.WriteLine("Keskmine arv: {0}",keskmine(arv,c));
            //ex2
            Console.WriteLine("sisetaja esimene arv:");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisetaja teine arv:");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisetaja operatsioon(+,/,*,-):");
            string op = Console.ReadLine();
            int Result = calculator(nr1, nr2, op);
            Console.WriteLine("{0} {1} {2} = {3}",nr1,op,nr2,Result);
            for (int i = 0; i < Result; i++)
            {
                Console.WriteLine("nur");
            }
            //ex3
            int stars = 10;
            for (int i = 0; i < stars; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine("Sisetaja stars num:");
            int stars1=int.Parse(Console.ReadLine());
            for (int i = 0; i < stars1; i++)
            {
                Console.WriteLine("*");
            }
            Console.ReadLine();
            

        }
        
    }
}
