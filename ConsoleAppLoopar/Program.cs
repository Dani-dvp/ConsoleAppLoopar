using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoopar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 1");
            for(int i = 0; i < 13; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Uppgift 2");
            int Nummer = 0;
            while(Nummer < 13)
            {
                Console.WriteLine(Nummer);
                Nummer = Nummer + 1;
            }
            Console.WriteLine("Uppgift 3");
            for(int i = 77; i > 64; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nUppgift 4");
            int Nummer2 = 77;
            while (Nummer2 > 64)
            {
                Console.WriteLine(Nummer2);
                Nummer2 = Nummer2 - 1;
            }

            Console.ReadLine();
        }
    }
}
