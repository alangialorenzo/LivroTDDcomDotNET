using NUnit.Framework;

namespace Cap3
{
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        static void Main()
        {
            // O Teste no NUnit irá falhar
        }

        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }
    }
}
