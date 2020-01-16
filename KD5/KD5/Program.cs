using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašyti funkciją, kuri suskaičiuoja ir gražina, kiek yra tarpų eilutėje

            string eilute = "Senis nese zuvi";

            Console.WriteLine("Tarpu skaicius eiluteje - Senis nese zuvi:");
            Console.WriteLine(suskaiciuotiTarpus(eilute));
            Console.ReadLine();
        }
        static int suskaiciuotiTarpus(string eilute)
        {
            int tarpuSkaicius = 0;

            foreach (var item in eilute)
            {
                if(item == ' ')
                {
                    tarpuSkaicius++;
                }
            }
            return tarpuSkaicius;
        }
    }
}
