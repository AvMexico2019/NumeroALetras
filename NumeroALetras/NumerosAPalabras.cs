﻿using System;
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

        private const long UnTrillon = 1000000000000000000; // 1 000 000 000 000 000 000
        private const long UnBillon  = 1000000000000;       //         1 000 000 000 000
        private const long UnMillon  = 1000000;             //                 1 000 000

        public string enLetras(double num)
        {
            double nro;

            nro = num;
            if (nro != 0.0)
            {
                return ConvierteNumeroALetras(nro);
            }
            else
                return "CERO M.N.";
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
                return "CERO M.N.";
        }


        public string enLetras(long num)
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
                return "CERO M.N.";
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
                return "CERO M.N.";
        }

        public string enLetras(string num)
        {
            double nro;

            try {
                nro = Convert.ToDouble(num);
            }
            catch {
                return "Error";
            }
            if (nro != 0.0)
            {
                return (ConvierteNumeroALetras(nro));
            }
            else
                return "CERO M.N.";
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
            return(toText(entero) + dec + "M.N.");
        }

        /*
         * Minimun ans Maximum numbers
         * System.Int32 struct. 
         * It has minimum -2,147,483,648
         * (DOS MIL CIENTO CUARENTA Y SIETE MILLONES CUATROCIENTOS OCHENTA Y TRES MIL SEICIENTOS CUARENTA Y OCHO)
         * and maximum +2,147,483,647 value
         * (DOS MIL CIENTO CUARENTA Y SIETE MILLONES CUATROCIENTOS OCHENTA Y TRES MIL SEICIENTOS CUARENTA Y SIETE)
         * 
         * System.Int64 struct. 
         * It has minimum –9,223,372,036,854,775,808
         * (menos 9 TRILLONES DOCIENTOS VEINTITRES MIL TRECIENTOS SETENTA Y DOS BILLONES TREINTA Y SEIS MIL OCHOCIENTOS CINCUENTA Y CUATRO MILLONES SETECIENTOS SETENTA Y CINCO MIL OCHOCIENTOS OCHO) 
         * and maximum 9,223,372,036,854,775,807 value
         * (9 TRILLONES DOCIENTOS VEINTITRES MIL TRECIENTOS SETENTA Y DOS BILLONES TREINTA Y SEIS MIL OCHOCIENTOS CINCUENTA Y CUATRO MILLONES SETECIENTOS SETENTA Y CINCO MIL OCHOCIENTOS SIETE) 
         */
        
        /*
         * En español grupos de seis numero siempre se escriben de igual forma independientemente de si son unidades,
         * millones, billones, trillones.
         * Por lo que esta rutina solo convertira numeros entre 0 y 999 999.
         * No debe tomar en cuenta el signo que traiga el numero
         * Se tiene que hacer esto porque la magnitud absoluta del maximo long es una unidad menor a la magnitud absoluta del mínimo.
         */

        
        private string segmentoToText(long segmento)
        {
            string Num2Text = "";

            segmento = Math.Abs(segmento); // es necesario deshacerse del signo que puede traer el numero
            if (segmento == 0) Num2Text = "CERO";
            else if (segmento == 1) Num2Text = "UNO";
            else if (segmento == 2) Num2Text = "DOS";
            else if (segmento == 3) Num2Text = "TRES";
            else if (segmento == 4) Num2Text = "CUATRO";
            else if (segmento == 5) Num2Text = "CINCO";
            else if (segmento == 6) Num2Text = "SEIS";
            else if (segmento == 7) Num2Text = "SIETE";
            else if (segmento == 8) Num2Text = "OCHO";
            else if (segmento == 9) Num2Text = "NUEVE";
            else if (segmento == 10) Num2Text = "DIEZ";
            else if (segmento == 11) Num2Text = "ONCE";
            else if (segmento == 12) Num2Text = "DOCE";
            else if (segmento == 13) Num2Text = "TRECE";
            else if (segmento == 14) Num2Text = "CATORCE";
            else if (segmento == 15) Num2Text = "QUINCE";
            else if (segmento < 20) Num2Text = "DIECI" + toText(segmento - 10);
            else if (segmento == 20) Num2Text = "VEINTE";
            else if (segmento < 30) Num2Text = "VEINTI" + toText(segmento - 20);
            else if (segmento == 30) Num2Text = "TREINTA";
            else if (segmento == 40) Num2Text = "CUARENTA";
            else if (segmento == 50) Num2Text = "CINCUENTA";
            else if (segmento == 60) Num2Text = "SESENTA";
            else if (segmento == 70) Num2Text = "SETENTA";
            else if (segmento == 80) Num2Text = "OCHENTA";
            else if (segmento == 90) Num2Text = "NOVENTA";
            else if (segmento < 100) Num2Text = toText(Math.Truncate(segmento / 10) * 10) + " Y " + toText(segmento % 10);
            else if (segmento == 100) Num2Text = "CIEN";
            else if (segmento < 200) Num2Text = "CIENTO " + toText(segmento - 100);
            else if ((segmento == 200) || (segmento == 300) || (segmento == 400) || (segmento == 600) || (segmento == 800)) Num2Text = toText(Math.Truncate(segmento / 100)) + "CIENTOS";
            else if (segmento == 500) Num2Text = "QUINIENTOS";
            else if (segmento == 700) Num2Text = "SETECIENTOS";
            else if (segmento == 900) Num2Text = "NOVECIENTOS";
            else if (segmento < 1000) Num2Text = toText(Math.Truncate(segmento / 100) * 100) + " " + toText(segmento % 100);
            else if (segmento == 1000) Num2Text = "MIL";
            else if (segmento < 2000) Num2Text = "MIL " + toText(segmento % 1000);
            return Num2Text;
        }

        private string toText(long value)
        {
            string texto = "";
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
            if (segmentoTrillones != 0)
                texto += segmentoToText(segmentoTrillones) + "TRILLONES ";

            long milesMillones = value % UnBillon;
            long segmentoBillones = (value - milesMillones);
            value -= segmentoBillones;
            segmentoBillones /= UnBillon;
            if (segmentoBillones != 0)
                texto += segmentoToText(segmentoBillones) + "BILLONES ";

            long milesUnidades = value % UnMillon;
            long segmentoMillones = (value - milesUnidades);
            value -= segmentoMillones;
            segmentoMillones /= UnMillon;
            if (segmentoMillones != 0)
                texto += segmentoToText(segmentoMillones) + "MILLONES ";

            long segmentoUnidades = value;
            if (segmentoUnidades != 0)
                texto += segmentoToText(segmentoUnidades) + "PESOS ";
            
            return texto;
        }
    }
}
