using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroALetras
{
    static class NumerosEnLetras
    {
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


        public static string[] DeCeroAVeintiNueveUnidades = new string[]
        {
                "CERO ",
                "UN ",
                "DOS ",
                "TRES ",
                "CUATRO ",
                "CINCO ",
                "SEIS ",
                "SIETE ",
                "OCHO ",
                "NUEVE ",
                "DIEZ ",
                "ONCE ",
                "DOCE ",
                "TRECE ",
                "CATORCE ",
                "QUINCE ",
                "DIECISÉIS ",
                "DIECISIETE ",
                "DIECIOCHO ",
                "DIECINUEVE ",
                "VEINTE ",
                "VEINTIUN ",
                "VEINTIDOS ",
                "VEINTITRES ",
                "VEINTICUATRO ",
                "VEINTICINCO ",
                "VEINTISEIS ",
                "VEINTISIETE ",
                "VEINTIOCHO ",
                "VEINTINUEVE "
            };

        public static string[] DeTreintaACien = new string[]
        {
                "TREINTA ",
                "CUARENTA ",
                "CINCUENTA ",
                "SESENTA ",
                "SETENTA ",
                "OCHENTA ",
                "NOVENTA ",
                "CIEN "
        };

        public static string[] Cientos = new string[]
        {
                "CIENTO ",
                "DOCIENTOS ",
                "TRECIENTOS ",
                "CUATROCIENTOS ",
                "QUINIENTOS ",
                "SEISCIENTOS ",
                "SETECIENTOS ",
                "OCHOCIENTOS ",
                "NOVECIENTOS "
        };

        public static string[] DeMilADecillonesSingular = new string[]
        {
            "MIL ",
            "MILLÓN ",
            "BILLÓN ",
            "TRILLÓN ",
            "CUADRILLÓN ",
            "QUINTILLÓN ",
            "SEXTILLÓN ",
            "SEPTILLÓN ",
            "OCTILLÓN ",
            "NONILLÓN ",
            "DECALLÓN "
        };

        public static string[] DeMilADecillonesPlural = new string[]
        {
            "MILES  ",
            "MILLONES ",
            "BILLONES ",
            "TRILLONES ",
            "CUADRILLONES ",
            "QUINTILLONES ",
            "SEXTILLONES ",
            "SEPTILLONES ",
            "OCTILLONES ",
            "NONILLONES ",
            "DECALLONES "
        };

        // me parece que lo que sigue son:
        // EONES, BIEONES, TRIEONES, CUADRIEONES, QUINTIEONES, SEXTIEONES, SEPTIEONES, OCTIEONES, NONIEONES, DECAEONES
    }
}
