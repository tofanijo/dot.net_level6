using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Parašyti metodą, kuris gražina užšifruotą eilutę.
            //a.Idėja tokia: paimti pirma eilutės simbolį, paversti jį į byte, pridėti bet kokį skaičių.Pradžioje išbandykite su 1.rezultatą paversti atgal į char.Šitaip padaryti su visais simboliais
            //b.Rezultate raidė „a“ taps „b“, „b“ -> „c“ ir tt.
            //c.Tai yra taip vadinamas Cezario Šifras(arba postūmio šifas). 
            char c = 'a';
            int i = (int)c;
            Console.WriteLine("c:{0}, (int)c:{ 1}", c, i);
            Console.ReadLine();

            i++;
                c = (char)i;
            Console.WriteLine("c:{0}, (int)c:{ 1}", c, i);
            Console.ReadLine();



        }
    }
}
