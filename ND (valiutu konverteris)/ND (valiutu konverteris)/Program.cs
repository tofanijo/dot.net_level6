using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND__valiutu_konverteris_
{
    class Program
    {
        class Converter
        {

            double eur;
            public void SetEur(double value)
            {
                eur = value;
            }
            public double GetEur()
            {
                return eur;
            }
            double usd;
            public double GetUsd()
            {
                return usd;
            }
            double pln;
            public double GetPln()
            {
                return pln;
            }
            double byr;
            public double GetByr()
            {
                return byr;
            }
            public double nUsd;
            public void SetNUsd(double value)
            {
                nUsd = value;
            }
            public double MethodUsd()
            {
                return nUsd;
            }
            static double MethodUsd(double Usd, double Eur, double nUsd)
            {
                nUsd = Usd * Eur;
                return nUsd;
            }
            public Converter(double Usd, double Pln, double Byr, double Eur)
            {
                this.usd = Usd;
                this.pln = Pln;
                this.byr = Byr;
                Console.Write("Iveskite suma(EUR):");
                this.eur = Convert.ToDouble(Console.ReadLine());
            }

        }
        static void Main(string[] args)
        {
            Converter money = new Converter(1.085, 4.961, 22289.9, 4);
            Console.WriteLine("Valiutos kursas: ");
            Console.WriteLine("USD: {0}, \nPLN: {1}, \nBYR: {2}, \nIvesta suma: {3}", money.GetUsd(), money.GetPln(), money.GetByr(), money.GetEur());
            money.MethodUsd();
            Console.WriteLine(money.MethodUsd());
            Console.ReadKey();
        }
    }
}
