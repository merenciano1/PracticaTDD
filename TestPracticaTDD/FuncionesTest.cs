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

        [TestMethod]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("12345678", false)]
        [DataRow("123456#", false)]
        [DataRow("1234567#", true)]
        [DataRow("contrasenya#segura", true)]
        public void TestEsContrasenyaValida(string contrasenya, bool resultadoEsperado)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
