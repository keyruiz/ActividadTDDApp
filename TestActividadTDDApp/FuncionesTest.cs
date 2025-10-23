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
    }
}
