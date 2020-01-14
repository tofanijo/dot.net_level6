using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string vardas;
            Console.WriteLine("Iveskite savo varda:");

            vardas = Console.ReadLine();

            isvestiVarda(vardas, 10);
            Console.ReadLine();

        }
        static void isvestiVarda(string q, int kiekKartu)
        {
            
            for (int i = 0; i < kiekKartu; i++)
            {
                Console.WriteLine(q);
            }
        }

    }
}
