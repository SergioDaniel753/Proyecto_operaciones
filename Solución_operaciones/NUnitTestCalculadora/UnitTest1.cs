using NUnit.Framework;
using Web_OperacionesN.Controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaGet1()
        {
            //Arrangespreparación
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculatorController calc = new CalculatorController();

            //Act=ejecución
            int resultado = calc.suma(num1, num2);
            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }
        
        [Test]
        public void TestSumaPost1()
        {
            //Arrangespreparación
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculatorController calc = new CalculatorController();

            //Act=ejecución
            int resultado = calc.sumar(num1, num2);
            //Assert=verificación
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestSumaGet2()
        {
            int num1 = 8;
            int num2 = 14;
            int esperado = 22;
            CalculatorController calc = new CalculatorController();

            int resultado = calc.suma(num1, num2);

            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestSumaPost2()
        {
            int num1 = 8;
            int num2 = 14;
            int esperado = 22;
            CalculatorController calc = new CalculatorController();

            int resultado = calc.sumar(num1, num2);

            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestSumaGet3()
        {
            int num1 = 14;
            int num2 = 16;
            int esperado = 30;
            CalculatorController calc = new CalculatorController();

            int resultado = calc.suma(num1, num2);

            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestSumaPost3()
        {
            int num1 = 14;
            int num2 = 16;
            int esperado = 30;
            CalculatorController calc = new CalculatorController();

            int resultado = calc.sumar(num1, num2);

            Assert.AreEqual(esperado, resultado);
        }

    }
}