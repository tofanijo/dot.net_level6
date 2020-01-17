using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašyti funkciją, kuri pakelią vieną skaičių į antrojo laipsnį
            //Pvz.: 2 ^ 3 = 8

            double skaicius = 2;
            int laipsnis = 3;

            Console.WriteLine($"Skaiciaus {skaicius} pakeltas {laipsnis}-iuoju laipsniu lygus {pakeltiSkaiciuLaipsniu(skaicius, laipsnis)}");

            Console.ReadLine();
        }
        static double pakeltiSkaiciuLaipsniu(double skaicius, int laipsnis)
        {
            double pakeltasSkaiciusLaipsniu = Math.Pow(skaicius, laipsnis);
            return pakeltasSkaiciusLaipsniu;
        }
    }
}
