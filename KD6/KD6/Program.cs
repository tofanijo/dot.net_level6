using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų sumą, 
            //bei kiek tų elementų yra.
            //Pvz.: Suma: 123, viso: 7 elementai

            int[] elementuMasyvas = { 1, 2, 3, 4, 5, 6, 7 };

            IsvestiElementus(elementuMasyvas);

            Console.ReadLine();
        }

            static void IsvestiElementus(int[] elementai)
            {
            int elementuSuma = 0;

            for (int i = 0; i <elementai.Length; i++)
            {
                elementuSuma += elementai[i];
            }
            Console.WriteLine($"Elementu suma: {elementuSuma}\nElementu skaicius: {elementai.Length}");
            }
        }
    }

