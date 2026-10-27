using PracticaTDD;

namespace TestPracticaTDD
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod] //JoMeRu2627
        [DataRow(0, 1)]
        [DataRow(-1, -1)]
        [DataRow(-89, -1)]
        [DataRow(1, 1)]
        [DataRow(4, 24)]
        [DataRow(5, 120)]
        public void TestCalcularFactorial(int numero, long resultadoEsperado)
        {
            var resultado = Funciones.CalcularFactorial(numero);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
