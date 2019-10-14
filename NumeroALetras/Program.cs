using System;

namespace NumeroALetras
{
    class Program
    {
        static void Main(string[] args)
        {
            LongRandom lrandom = new LongRandom();
            NumerosAPalabras aPalabras = new NumerosAPalabras();

            Console.WriteLine("Valores Maximos y Minimos por tipo de dato usado");
            Console.WriteLine("double Min " + aPalabras.DMIN);
            Console.WriteLine("ulong Max " + aPalabras.UMAX);
            Console.WriteLine("ulong Min " + aPalabras.UMIN);
            Console.WriteLine("long Max " + aPalabras.Max);
            Console.WriteLine("long Min " + aPalabras.Min);
            Console.WriteLine("decimal Max " + aPalabras.DecimalMax);
            Console.WriteLine("decimal Min " + aPalabras.DecimalMin);
            Console.WriteLine("Class Max " + aPalabras.ClassMaxValue);
            Console.WriteLine("Class Min " + aPalabras.ClassMinValue);


            // Let test that the convertion works fine in al the value range and at random
            Console.WriteLine("----------------------- EJEMPLOS --------------------------");
            long numero = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(aPalabras.enLetras(numero) + "\n");
                numero *= 10;
            }
            Console.WriteLine(aPalabras.enLetras(1000001000000000) + "\n");

            Console.WriteLine(aPalabras.enLetras(aPalabras.Min) + "\n");
            Console.WriteLine(aPalabras.enLetras(aPalabras.Max) + "\n");
            Console.WriteLine(aPalabras.enLetras(aPalabras.Trillon) + "\n");
            Console.WriteLine(aPalabras.enLetras(aPalabras.Billon) + "\n");
            Console.WriteLine(aPalabras.enLetras(aPalabras.Millon) + "\n");
            Console.WriteLine(aPalabras.enLetras(0) + "\n");
            Console.WriteLine(aPalabras.enLetras(1) + "\n");
            Console.WriteLine(aPalabras.enLetras(2) + "\n");
            Console.WriteLine(aPalabras.enLetras(3) + "\n");
            Console.WriteLine(aPalabras.enLetras(4) + "\n");
            Console.WriteLine(aPalabras.enLetras(5) + "\n");
            Console.WriteLine(aPalabras.enLetras(6) + "\n");
            Console.WriteLine(aPalabras.enLetras(7) + "\n");
            Console.WriteLine(aPalabras.enLetras(8) + "\n");
            Console.WriteLine(aPalabras.enLetras(9) + "\n");
            Console.WriteLine(aPalabras.enLetras(10) + "\n");
            Console.WriteLine(aPalabras.enLetras(11) + "\n");
            Console.WriteLine(aPalabras.enLetras(12) + "\n");
            Console.WriteLine(aPalabras.enLetras(13) + "\n");
            Console.WriteLine(aPalabras.enLetras(14) + "\n");
            Console.WriteLine(aPalabras.enLetras(15) + "\n");
            Console.WriteLine(aPalabras.enLetras(16) + "\n");
            Console.WriteLine(aPalabras.enLetras(17) + "\n");
            Console.WriteLine(aPalabras.enLetras(18) + "\n");
            Console.WriteLine(aPalabras.enLetras(19) + "\n");
            Console.WriteLine(aPalabras.enLetras(20) + "\n");
            Console.WriteLine(aPalabras.enLetras(21) + "\n");
            Console.WriteLine(aPalabras.enLetras(22) + "\n");
            Console.WriteLine(aPalabras.enLetras(23) + "\n");
            Console.WriteLine(aPalabras.enLetras(24) + "\n");
            Console.WriteLine(aPalabras.enLetras(25) + "\n");
            Console.WriteLine(aPalabras.enLetras(26) + "\n");
            Console.WriteLine(aPalabras.enLetras(27) + "\n");
            Console.WriteLine(aPalabras.enLetras(28) + "\n");
            Console.WriteLine(aPalabras.enLetras(29) + "\n");
            Console.WriteLine(aPalabras.enLetras(30) + "\n");
            Console.WriteLine(aPalabras.enLetras(31) + "\n");
            Console.WriteLine(aPalabras.enLetras(32) + "\n");
            Console.WriteLine(aPalabras.enLetras(33) + "\n");
            Console.WriteLine(aPalabras.enLetras(34) + "\n");
            Console.WriteLine(aPalabras.enLetras(40) + "\n");
            Console.WriteLine(aPalabras.enLetras(41) + "\n");
            Console.WriteLine(aPalabras.enLetras(50) + "\n");
            Console.WriteLine(aPalabras.enLetras(52) + "\n");
            Console.WriteLine(aPalabras.enLetras(60) + "\n");
            Console.WriteLine(aPalabras.enLetras(70) + "\n");
            Console.WriteLine(aPalabras.enLetras(80) + "\n");
            Console.WriteLine(aPalabras.enLetras(90) + "\n");
            Console.WriteLine(aPalabras.enLetras(100) + "\n");
            Console.WriteLine(aPalabras.enLetras(101) + "\n");
            Console.WriteLine(aPalabras.enLetras(200) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.01) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.02) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.05) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.10) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.20) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.50) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.63) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.75) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.85) + "\n");
            Console.WriteLine(aPalabras.enLetras(0.95) + "\n");

            for (int i = 0; i < 500; i++)
                Console.WriteLine(aPalabras.enLetras(lrandom.LRandom()) + "\n");

            Console.ReadKey();
        }
    }
}
