using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void Factorial_NumeroNegativo()
        {
            int resultado = Funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Factorial_Cero()
        {
            int resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }

    }
}
