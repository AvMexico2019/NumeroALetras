using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroALetras;
using System;
using System.Diagnostics;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLong()
        {
            Trace.WriteLine("Pruebas unitarias para el tipo de datos long");
            using (var sw = new StringWriter())
            {
                NumerosAPalabras aPalabras = new NumerosAPalabras();
                for (int i = 0; i < ExpectedResult.Result.Length; i++)
                {
                    Trace.WriteLine(aPalabras.enLetras(ExpectedResult.Result[i].num));
                    Trace.WriteLine(ExpectedResult.Result[i].EnPalabras);
                    Assert.AreEqual(ExpectedResult.Result[i].EnPalabras, aPalabras.enLetras(ExpectedResult.Result[i].num));
                }
            }
        }
    }
}
