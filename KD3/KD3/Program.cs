using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašyti funkciją, kuri gauna string tipo parametrą.Funkcija turi 
            //gražinti eilutę su tiek „#“,kiek simbolių gautame parametre.

            Console.WriteLine(suskaiciuotiSimbolius("Romanas"));
            Console.ReadLine();
        }
        static string suskaiciuotiSimbolius(string eilute)
        {
            string simboliai = "";
            for (int i = 0; i < eilute.Length; i++)
            {
                simboliai += '#';
            }
            return simboliai;
        }
    }
}
