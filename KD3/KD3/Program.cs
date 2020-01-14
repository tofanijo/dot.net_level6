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
