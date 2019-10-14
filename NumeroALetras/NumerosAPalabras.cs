using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroALetras
{
    public class NumerosAPalabras
    {
        public long Min { get { return Int64.MinValue; } }
        public long Max { get { return Int64.MaxValue; } }
        public long Trillon { get { return UnTrillon; } }
        public long Billon { get { return UnBillon; } }
        public long Millon { get { return UnMillon; } }
        public ulong UMAX { get { return ulong.MaxValue; } }
        public ulong UMIN { get { return ulong.MinValue; } }
        public double DMAX { get { return double.MaxValue; } }
        public double DMIN { get { return double.MinValue; } }
        public decimal DecimalMax { get { return decimal.MaxValue; } }
        public decimal DecimalMin { get { return decimal.MinValue; } }
        public double ClassMaxValue { get { return 9.99999999999999999999999999999999999999999999999999999999999999999999e68; } }
        public double ClassMinValue { get { return -9.99999999999999999999999999999999999999999999999999999999999999999999e68; } }

        /*
         * El numero mas grande que vamos a escribir en letra es:
         * 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999 999
         * 22 * 3 + 2 cifras despues del punto = 68
         * 9.99999999999999999999999999999999999999999999999999999999999999999999e68
         * este numero solo es repressentable en dentro de un double

            novecientos noventa y nueve mil novecientos noventa y nueve decallones ....

            Mil
            Millón
            Mil millones  
            Billón  
            Mil billones
            Trillón 
            Mil trillones 
            Cuadrillón 
            Mil cuadrillones 
            Quintillón 
            Mil quintillones 
            Sextillón 
            Mil sextillones 
            Septillón 
            Mil septillones 
            Octillón 
            Mil octillones 
            Nonillón 
            Mil nonillones 
            Decallón 
            Mil decillones
         */


        private const long UnTrillon = 1000000000000000000; // 1 000 000 000 000 000 000
        private const long UnBillon = 1000000000000;       //         1 000 000 000 000
        private const long UnMillon = 1000000;             //                 1 000 000

        public string enLetras(double num)
        {
            double nro;

            nro = num;
            if (nro != 0.0)
            {
                return ConvierteNumeroALetras(nro);
            }
            else
                return "CERO";
        }

        public string enLetras(float num)
        {
            double nro;

            // Convert num to rno
            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "Error";
            }
            if (nro != 0.0)
            {
                return (ConvierteNumeroALetras(nro));
            }
            else
                return "CERO";
        }


        public string enLetras(long num)
        {
            if (num != 0)
            {
                return (ConvierteNumeroALetras(num));
            }
            else
                return "CERO";
        }

        public string enLetras(int num)
        {
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "Error";
            }
            if (nro != 0.0)
            {
                return (ConvierteNumeroALetras(nro));
            }
            else
                return "CERO";
        }

        public string enLetras(string num)
        {
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "Error";
            }
            if (nro != 0.0)
            {
                return (ConvierteNumeroALetras(nro));
            }
            else
                return "CERO ";
        }

        private string ConvierteNumeroALetras(double nro)
        {
            Int64 entero;
            int decimales;
            string dec = "";

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100 ";
            }
            return (toText(entero) + dec);
        }

        private string ConvierteNumeroALetras(long entero)
        {
            return (toText(entero));
        }

        private bool SegmentoSingular;

        private string segmentoToText(long segmento)  //  convierte grupos de 6 digitoa a letras cuenta del punto hacia la izquierda
        {
            SegmentoSingular = false;
            if (segmento == 1)
            {
                SegmentoSingular = true;
                return NumerosEnLetras.DeCeroAVeintiNueveUnidades[segmento];
            }
            int ParteMiles = (int)Math.Truncate(segmento / 1000.0);
            int ParteUnidades = (int)(segmento - ParteMiles * 1000);
            string StringParteMiles = Unidades.TresDigitosUnidadesATexto(ParteMiles);
            if (Unidades.EsCero)
                return Unidades.TresDigitosUnidadesATexto(ParteUnidades);
            else
                return StringParteMiles + "MIL " + Unidades.TresDigitosUnidadesATexto(ParteUnidades);
        }

        private string toText(long value)
        {
            string texto = "";

            Console.WriteLine(value + "\n");

            if (value < 0) texto = "MENOS ";

            /*
             * El numero puede ser positivo o negativo el negativo es mayor que el positivo maximo
             * por 1 envalor absoluto
             */

            // trillones
            long milesBillones = value % UnTrillon;
            long segmentoTrillones = (value - milesBillones);
            value -= segmentoTrillones;
            segmentoTrillones /= UnTrillon;
            bool UnPeso = true; ;
            if (segmentoTrillones != 0)
            {
                if (segmentoTrillones == 1)
                    texto += "UN TRILLON ";
                else
                    texto += segmentoToText(segmentoTrillones) + "TRILLONES ";
                UnPeso = false;
            }

            long milesMillones = value % UnBillon;
            long segmentoBillones = (value - milesMillones);
            value -= segmentoBillones;
            segmentoBillones /= UnBillon;
            if (segmentoBillones != 0)
            {
                if (segmentoBillones == 1)
                    texto += "UN BILLON ";
                else
                    texto += segmentoToText(segmentoBillones) + "BILLONES ";
                UnPeso = false;
            }


            long milesUnidades = value % UnMillon;
            long segmentoMillones = (value - milesUnidades);
            value -= segmentoMillones;
            segmentoMillones /= UnMillon;
            if (segmentoMillones != 0)
            {
                if (segmentoMillones == 1)
                    texto += "UN MILLON ";
                else
                    texto += segmentoToText(segmentoMillones) + "MILLONES ";
                UnPeso = false;
            }

            long segmentoUnidades = value;
            if (segmentoUnidades != 0)
            {
                if ((segmentoUnidades == 1) & UnPeso)
                    texto += "UN PESO ";
                else
                    texto += segmentoToText(segmentoUnidades) + "PESOS ";
            }
            return texto;
        }
    }
}
