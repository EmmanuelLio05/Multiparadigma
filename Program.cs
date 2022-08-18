using System;
using System.Collections.Generic;

namespace Multiparadigma {
    class Program {
        static void Main(string[] args) {
            Program IrA = new Program();
            List<int> nNumeros = new List<int>(){1,4,7,25,267,3,45,673,34,68,35654,387,543,22354};

            Console.WriteLine("---------------------------");
            IrA.DentroDeRango(new Rango(30, 80), nNumeros).ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------");
            IrA.DentroDeRangoFunc(new Rango(30, 80), nNumeros).ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------");
            IrA.DentroDeRangoFuncTuple(Tuple.Create(30, 80), nNumeros).ForEach(Console.WriteLine);
        }

        List<int> DentroDeRango(Rango oRango, List<int> nNumeros) {
            List<int> nNumerosDentro = new List<int>();

            foreach (int nNumero in nNumeros) {
                if (nNumero >= oRango.Inferior && nNumero <= oRango.Superior)
                    nNumerosDentro.Add(nNumero);
            }
            return nNumerosDentro;
        }

        Func<Rango, List<int>, List<int>> DentroDeRangoFunc = (a, b)
             => b.FindAll(x => x >= a.Inferior && x <= a.Superior);

        Func<Tuple<int, int>, List<int>, List<int>> DentroDeRangoFuncTuple = (a, b)
               => b.FindAll(x => x >= a.Item1 && x <= a.Item2);
    }
}
