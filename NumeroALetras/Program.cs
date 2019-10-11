using System;

namespace NumeroALetras
{
    class Program
    {
        static void Main(string[] args)
        {
            LongRandom lrandom = new LongRandom();
            NumerosAPalabras aPalabras = new NumerosAPalabras();

            //Let test that the convertion workss fine in al the value range and at random

            Console.WriteLine(aPalabras.enLetras(aPalabras.Min));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Max));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Trillon));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Billon));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Millon));
            Console.WriteLine(aPalabras.enLetras(1));
            Console.WriteLine(aPalabras.enLetras(0.01));
            Console.WriteLine(aPalabras.enLetras(0.02));
            Console.WriteLine(aPalabras.enLetras(0.05));
            Console.WriteLine(aPalabras.enLetras(0.10));
            Console.WriteLine(aPalabras.enLetras(0.20));
            Console.WriteLine(aPalabras.enLetras(0.50));
            Console.WriteLine(aPalabras.enLetras(0.63));
            Console.WriteLine(aPalabras.enLetras(0.75));
            Console.WriteLine(aPalabras.enLetras(0.85));
            Console.WriteLine(aPalabras.enLetras(0.95));

            for (int i = 0; i < 500; i++)
                Console.WriteLine(lrandom.LRandom());
            Console.ReadKey();
        }
    }
}
