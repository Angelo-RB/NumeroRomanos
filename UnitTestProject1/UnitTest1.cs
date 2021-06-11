using ConversorRomano.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConversorRomano.Test
{
    [TestClass]
    public class UnitTest1
    {
        ConversorNumeroIndoArabico conversor = new ConversorNumeroIndoArabico();

        [TestMethod]
        public void DeveRetornar_I()
        {
            Assert.AreEqual("I", conversor.ConversorNumeroArabicoPrimario(1));
        }

        [TestMethod]
        public void DeveRetornar_II()
        {
            Assert.AreEqual("II", conversor.ConversorNumeroArabicoPrimario(2));
        }

        [TestMethod]
        public void DeveRetornar_III()
        {
            Assert.AreEqual("III", conversor.ConversorNumeroArabicoPrimario(3));
        }

        [TestMethod]
        public void DeveRetornar_V()
        {
            Assert.AreEqual("V", conversor.ConversorNumeroArabicoPrimario(5));
        }

        [TestMethod]
        public void DeveRetornar_VI()
        {
            Assert.AreEqual("VI", conversor.ConversorNumeroArabicoPrimario(6));
        }

        [TestMethod]
        public void DeveRetornar_X()
        {
            Assert.AreEqual("X", conversor.ConversorNumeroArabicoPrimario(10));
        }

        [TestMethod]
        public void DeveRetornar_XI()
        {
            Assert.AreEqual("XI", conversor.ConversorNumeroArabicoPrimario(11));
        }

        [TestMethod]
        public void DeveRetornar_XX()
        {
            Assert.AreEqual("XX", conversor.ConversorNumeroArabicoPrimario(20));
        }

        [TestMethod]
        public void DeveRetornar_XL()
        {
            Assert.AreEqual("XL", conversor.ConversorNumeroArabicoPrimario(40));
        }

        [TestMethod]
        public void DeveRetornar_L()
        {
            Assert.AreEqual("L", conversor.ConversorNumeroArabicoPrimario(50));
        }

        [TestMethod]
        public void DeveRetornar_XC()
        {
            Assert.AreEqual("XC", conversor.ConversorNumeroArabicoPrimario(90));
        }

        [TestMethod]
        public void DeveRetornar_C()
        {
            Assert.AreEqual("C", conversor.ConversorNumeroArabicoPrimario(100));
        }

        [TestMethod]
        public void DeveRetornar_M()
        {
            Assert.AreEqual("M", conversor.ConversorNumeroArabicoPrimario(1000));
        }

        [TestMethod]
        public void DeveRetornar_MMM()
        {
            Assert.AreEqual("MMM", conversor.ConversorNumeroArabicoPrimario(3000));
        }
        
        [TestMethod]
        public void DeveRetornar_ĪV̄()
        {
            Assert.AreEqual("ĪV̄", conversor.ConversorNumeroArabicoPrimario(4000));
        }
        
        [TestMethod]
        public void DeveRetornar_V̄()
        {
            Assert.AreEqual("V̄", conversor.ConversorNumeroArabicoPrimario(5000));
        }

        [TestMethod]
        public void DeveRetornar_V̄Ī()
        {
            Assert.AreEqual("V̄Ī", conversor.ConversorNumeroArabicoPrimario(6000));
        }

        [TestMethod]
        public void DeveRetornar_V̄ĪĪ()
        {
            Assert.AreEqual("V̄ĪĪ", conversor.ConversorNumeroArabicoPrimario(7000));
        }

        [TestMethod]
        public void DeveRetornar_V̄ĪĪĪ()
        {
            Assert.AreEqual("V̄ĪĪĪ", conversor.ConversorNumeroArabicoPrimario(8000));
        }

        [TestMethod]
        public void DeveRetornar_ĪX̄()
        {
            Assert.AreEqual("ĪX̄", conversor.ConversorNumeroArabicoPrimario(9000));
        }

        [TestMethod]
        public void DeveRetornar_X̄()
        {
            Assert.AreEqual("X̄", conversor.ConversorNumeroArabicoPrimario(10000));
        }

    }
}
