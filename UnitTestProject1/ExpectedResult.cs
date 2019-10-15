using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    static public class ExpectedResult
    {
        static public TestRecord[] Result = new TestRecord[] {
            new TestRecord(1000000000000, @"UN BILLON DE PESOS "),
            new TestRecord(1000000000001, @"UN BILLON UN PESOS "),
            new TestRecord(1007001, @"UN MILLON SIETE MIL UN PESOS "),
            new TestRecord(8446744073709551616, @"OCHO TRILLONES CUATROCIENTOS CUARENTA Y SEIS MIL SETECIENTOS CUARENTA Y CUATRO BILLONES SETENTA Y TRES MIL SETECIENTOS NUEVE MILLONES QUINIENTOS CINCUENTA Y UN MIL SEISCIENTOS DIECISÉIS PESOS "),
            new TestRecord(7001, @"SIETE MIL UN PESOS "),
            new TestRecord(1, @"UN PESO "),
            new TestRecord(1000, @"MIL PESOS "),
            new TestRecord(1000000000, @"MIL MILLONES DE PESOS "),
            new TestRecord(1000000000000000, @"MIL BILLONES "),
            new TestRecord(1001000000000, @"UN BILLON MIL MILLONES "),
            new TestRecord(1007001, @"UN MILLON SIETE MIL UN PESOS "),
            new TestRecord(8446744073709551616, @"OCHO TRILLONES CUATROCIENTOS CUARENTA Y SEIS MIL SETECIENTOS CUARENTA Y CUATRO BILLONES SETENTA Y TRES MIL SETECIENTOS NUEVE MILLONES QUINIENTOS CINCUENTA Y UN MIL SEISCIENTOS DIECISÉIS PESOS "),
            new TestRecord(7001, @"SIETE MIL UN PESOS "),
            new TestRecord(1000, @"MIL PESOS "),
            new TestRecord(1000000000, @"MIL MILLONES "),
            new TestRecord(1000000000000000, @"MIL BILLONES "),
            new TestRecord(10, @"DIEZ PESOS "),
            new TestRecord(100, @"CIEN PESOS "),
            new TestRecord(1000, @"MIL PESOS "),
            new TestRecord(10000, @"DIEZ MIL PESOS "),
            new TestRecord(100000, @"CIEN MIL PESOS "),
            new TestRecord(1000000, @"UN MILLON "),
            new TestRecord(10000000, @"DIEZ MILLONES "),
            new TestRecord(100000000, @"CIEN MILLONES "),
            new TestRecord(1000000000, @"MIL MILLONES "),
            new TestRecord(10000000000, @"DIEZ MIL MILLONES "),
            new TestRecord(100000000000, @"CIEN MIL MILLONES "),
            new TestRecord(1000000000000, @"UN BILLON "),
            new TestRecord(10000000000000, @"DIEZ BILLONES "),
            new TestRecord(100000000000000, @"CIEN BILLONES "),
            new TestRecord(1000000000000000, @"MIL BILLONES "),
            new TestRecord(10000000000000000, @"DIEZ MIL BILLONES "),
            new TestRecord(100000000000000000, @"CIEN MIL BILLONES "),
            new TestRecord(1000000000000000000, @"UN TRILLON "),
            new TestRecord(1000001000000000, @"MIL BILLONES MIL MILLONES "),
            new TestRecord(Int64.MinValue, @"MENOS NUEVE TRILLONES DOCIENTOS VEINTITRES MIL TRECIENTOS SETENTA Y DOS BILLONES TREINTA Y SEIS MIL OCHOCIENTOS CINCUENTA Y CUATRO MILLONES SETECIENTOS SETENTA Y CINCO MIL OCHOCIENTOS OCHO PESOS "),
            new TestRecord(Int64.MaxValue, @"NUEVE TRILLONES DOCIENTOS VEINTITRES MIL TRECIENTOS SETENTA Y DOS BILLONES TREINTA Y SEIS MIL OCHOCIENTOS CINCUENTA Y CUATRO MILLONES SETECIENTOS SETENTA Y CINCO MIL OCHOCIENTOS SIETE PESOS "),
            new TestRecord(0, @"CERO"),   // no respeta la regla de un blanco al final
            new TestRecord(1, @"UN PESO "),
            new TestRecord(2, @"DOS PESOS "),
            new TestRecord(3, @"TRES PESOS "),
            new TestRecord(4, @"CUATRO PESOS "),
            new TestRecord(5, @"CINCO PESOS "),
            new TestRecord(6, @"SEIS PESOS "),
            new TestRecord(7, @"SIETE PESOS "),
            new TestRecord(8, @"OCHO PESOS "),
            new TestRecord(9, @"NUEVE PESOS "),
            new TestRecord(10, @"DIEZ PESOS "),
            new TestRecord(11, @"ONCE PESOS "),
            new TestRecord(12, @"DOCE PESOS "),
            new TestRecord(13, @"TRECE PESOS "),
            new TestRecord(14, @"CATORCE PESOS "),
            new TestRecord(15, @"QUINCE PESOS "),
            new TestRecord(16, @"DIECISÉIS PESOS "),
            new TestRecord(17, @"DIECISIETE PESOS "),
            new TestRecord(18, @"DIECIOCHO PESOS "),
            new TestRecord(19, @"DIECINUEVE PESOS "),
            new TestRecord(20, @"VEINTE PESOS "),
            new TestRecord(21, @"VEINTIUN PESOS "),
            new TestRecord(22, @"VEINTIDOS PESOS "),
            new TestRecord(23, @"VEINTITRES PESOS "),
            new TestRecord(24, @"VEINTICUATRO PESOS "),
            new TestRecord(25, @"VEINTICINCO PESOS "),
            new TestRecord(26, @"VEINTISEIS PESOS "),
            new TestRecord(27, @"VEINTISIETE PESOS "),
            new TestRecord(28, @"VEINTIOCHO PESOS "),
            new TestRecord(29, @"VEINTINUEVE PESOS "),
            new TestRecord(30, @"TREINTA PESOS "),
            new TestRecord(31, @"TREINTA Y UN PESOS "),
            new TestRecord(32, @"TREINTA Y DOS PESOS "),
            new TestRecord(33, @"TREINTA Y TRES PESOS "),
            new TestRecord(34, @"TREINTA Y CUATRO PESOS "),
            new TestRecord(40, @"CUARENTA PESOS "),
            new TestRecord(41, @"CUARENTA Y UN PESOS "),
            new TestRecord(50, @"CINCUENTA PESOS "),
            new TestRecord(52, @"CINCUENTA Y DOS PESOS "),
            new TestRecord(60, @"SESENTA PESOS "),
            new TestRecord(70, @"SETENTA PESOS "),
            new TestRecord(80, @"OCHENTA PESOS "),
            new TestRecord(90, @"NOVENTA PESOS "),
            new TestRecord(100, @"CIEN PESOS "),
            new TestRecord(101, @"CIENTO UN PESOS "),
            new TestRecord(200, @"DOCIENTOS PESOS "),
            new TestRecord(333, @"TRECIENTOS TREINTA Y TRES PESOS "),
            new TestRecord(456, @"CUATROCIENTOS CINCUENTA Y SEIS PESOS "),
            new TestRecord(01000, @"MIL PESOS "),
            new TestRecord(1000000, @"UN MILLON "),
            new TestRecord(1000000000000, @"UN BILLON "),
            new TestRecord(99, @"NOVENTA Y NUEVE PESOS "),
            new TestRecord(120, @"CIENTO VEINTE PESOS "),
            new TestRecord(1111111111, @"MIL CIENTO ONCE MILLONES CIENTO ONCE MIL CIENTO ONCE PESOS ")
        };
    }
    
    public class TestRecord
    {
        public long num;
        public string EnPalabras;
        public TestRecord(long num, string EnPalabras)
        {
            this.num = num;
            this.EnPalabras = EnPalabras;
        }
    }
}
