using System;

namespace NumeroALetras
{
    class Program
    {
        static void Main(string[] args)
        {
            LongRandom lrandom = new LongRandom();
            NumerosAPalabras aPalabras = new NumerosAPalabras();
            Console.WriteLine("double Max " + aPalabras.DMAX);
            Console.WriteLine("double Min " + aPalabras.DMIN);
            Console.WriteLine("ulong Max " + aPalabras.UMAX);
            Console.WriteLine("ulong Min " + aPalabras.UMIN);
            Console.WriteLine("long Max " + aPalabras.Max);
            Console.WriteLine("long Min " + aPalabras.Min);
            Console.WriteLine("decimal Max " + aPalabras.DecimalMax);
            Console.WriteLine("decimal Min " + aPalabras.DecimalMin);
            Console.WriteLine("Class Max " + aPalabras.ClassMaxValue);
            Console.WriteLine("Class Min " + aPalabras.ClassMinValue);


            //Let test that the convertion workss fine in al the value range and at random

            Console.WriteLine(aPalabras.enLetras(aPalabras.Min));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Max));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Trillon));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Billon));
            Console.WriteLine(aPalabras.enLetras(aPalabras.Millon));
            Console.WriteLine(aPalabras.enLetras(0));
            Console.WriteLine(aPalabras.enLetras(1));
            Console.WriteLine(aPalabras.enLetras(2));
            Console.WriteLine(aPalabras.enLetras(3));
            Console.WriteLine(aPalabras.enLetras(4));
            Console.WriteLine(aPalabras.enLetras(5));
            Console.WriteLine(aPalabras.enLetras(6));
            Console.WriteLine(aPalabras.enLetras(7));
            Console.WriteLine(aPalabras.enLetras(8));
            Console.WriteLine(aPalabras.enLetras(9));
            Console.WriteLine(aPalabras.enLetras(10));
            Console.WriteLine(aPalabras.enLetras(11));
            Console.WriteLine(aPalabras.enLetras(12));
            Console.WriteLine(aPalabras.enLetras(13));
            Console.WriteLine(aPalabras.enLetras(14));
            Console.WriteLine(aPalabras.enLetras(15));
            Console.WriteLine(aPalabras.enLetras(16));
            Console.WriteLine(aPalabras.enLetras(17));
            Console.WriteLine(aPalabras.enLetras(18));
            Console.WriteLine(aPalabras.enLetras(19));
            Console.WriteLine(aPalabras.enLetras(20));
            Console.WriteLine(aPalabras.enLetras(30));
            Console.WriteLine(aPalabras.enLetras(40));
            Console.WriteLine(aPalabras.enLetras(50));
            Console.WriteLine(aPalabras.enLetras(60));
            Console.WriteLine(aPalabras.enLetras(70));
            Console.WriteLine(aPalabras.enLetras(80));
            Console.WriteLine(aPalabras.enLetras(90));
            Console.WriteLine(aPalabras.enLetras(100));
            Console.WriteLine(aPalabras.enLetras(101));
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
                Console.WriteLine(aPalabras.enLetras(lrandom.LRandom()));
            Console.ReadKey();
        }
    }
}
