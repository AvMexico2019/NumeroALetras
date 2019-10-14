using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroALetras
{
    static class Unidades
    {
        public static int centenas;
        public static int decenas;
        public static int unidades;
        public static bool singular = false;
        public static bool EsCero = false;

        public static string TresDigitosUnidadesATexto(int tresDigitos) // 0 a 999 unicamente
        {
            singular = false;
            EsCero = false;
            string Num2Text = "";
            tresDigitos = Math.Abs(tresDigitos);
            if (tresDigitos == 0) EsCero = true;

            centenas = (int)Math.Truncate(tresDigitos / 100.0);
            decenas = (int)Math.Truncate((tresDigitos - centenas * 100) / 10.0);
            unidades = tresDigitos - centenas * 100 - decenas * 10;
            if (tresDigitos == 100)
            {
                return NumerosEnLetras.DeTreintaACien[7]; // string CIEN está en la posición 7
            }
            if (centenas > 0)
            {
                Num2Text += NumerosEnLetras.Cientos[centenas - 1];
                if ((decenas * 10 + unidades) < 30)
                {
                    if (decenas + unidades > 0)
                        Num2Text += NumerosEnLetras.DeCeroAVeintiNueveUnidades[decenas * 10 + unidades];
                }
                else
                {
                    Num2Text += NumerosEnLetras.DeTreintaACien[decenas - 3];
                    if (unidades > 0)
                    {
                        Num2Text += "Y " + NumerosEnLetras.DeCeroAVeintiNueveUnidades[unidades];
                    }
                }
            }
            else
            {
                if ((decenas * 10 + unidades) < 30)
                {
                    if (decenas + unidades > 0)
                        Num2Text += NumerosEnLetras.DeCeroAVeintiNueveUnidades[decenas * 10 + unidades];
                    if ((decenas == 0) & (unidades == 1)) singular = true;
                }
                else
                {
                    Num2Text += NumerosEnLetras.DeTreintaACien[decenas - 3];
                    if (unidades > 0)
                    {
                        Num2Text += "Y " + NumerosEnLetras.DeCeroAVeintiNueveUnidades[unidades];
                    }
                }
            }
            return Num2Text;
        }
    }
}
