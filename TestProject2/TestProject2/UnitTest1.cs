using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculadora;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(4,CalculadoraEjemplo.suma(2,2));
            //El que esperamos obtener -> luego el resultado de la variable
        }
    }
}
