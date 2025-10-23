using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void Factorial_NumeroNegativo()
        {
            long resultado = Funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Factorial_Cero()
        {
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }


        [TestMethod]
        [DataRow(3, 6)]     
        [DataRow(5, 120)]   
        [DataRow(7, 5040)]  
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Contrasena_Null()
        {
            bool resultado = Funciones.EsContrasenyaValida(null);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasena_Vacia()
        {
            bool resultado = Funciones.EsContrasenyaValida("");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasena_Longitud()
        {
            bool resultado = Funciones.EsContrasenyaValida("12345#");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasena_Almohadilla()
        {
            bool resultado = Funciones.EsContrasenyaValida("12345678");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasena_True()
        {
            bool resultado = Funciones.EsContrasenyaValida("12345678#");
            Assert.IsTrue(resultado);
        }
    }
}
