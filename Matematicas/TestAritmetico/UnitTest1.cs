using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematicas;

namespace TestAritmetico
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int resultado = Arimeticas.sumar(2, 2);

            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void TestISBN()
        {
            int[] numeros = new int[]{9,7,8,0,7,1,6,7,0,3,4,4,0};

            bool resultado = Arimeticas.ISBN(numeros);

            Assert.AreEqual(true, resultado);
        }
    }
}
