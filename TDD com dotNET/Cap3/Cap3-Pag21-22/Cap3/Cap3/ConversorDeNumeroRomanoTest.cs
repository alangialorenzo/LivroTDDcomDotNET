using NUnit.Framework;

namespace Cap3
{
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        static void Main()
        {
            // Agora o código rodará sem erros no NUnit
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
